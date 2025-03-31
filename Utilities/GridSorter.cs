using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using K_Accounting.Models;

namespace K_Accounting.Utilities
{
    public static class GridSorter
    {
        private static readonly ConcurrentDictionary<string, SortSettings> SortStates = new();

        public static void InitializeGrid(DataGridView grid, IEnumerable<object> dataSource)
        {
            //var sortSettings = SettingsManager.LoadSortSettings(grid);
            //var sortedData = SortData(dataSource, sortSettings.SortColumn, sortSettings.SortAscending);

            //grid.DataSource = sortedData;
            //UpdateSortIndicator(grid, sortSettings.SortColumn, sortSettings.SortAscending);

            var sortSettings = SettingsManager.LoadSortSettings(grid);
            var sortedData = SortData(dataSource, sortSettings.SortColumn, sortSettings.SortAscending);

            // Обновляем источник данных
            grid.DataSource = new BindingList<object>(sortedData.ToList());

            // Применяем визуальные настройки сортировки
            UpdateSortIndicator(grid, sortSettings.SortColumn, sortSettings.SortAscending);

            // Сохраняем текущее состояние сортировки
            if (!string.IsNullOrEmpty(sortSettings.SortColumn))
            {
                SortStates[grid.Name] = sortSettings;
            }
        }

        public static void HandleSorting(DataGridView grid, DataGridViewCellMouseEventArgs e, IEnumerable<object> currentData)
        {
            {
                var column = grid.Columns[e.ColumnIndex];
                var propertyName = column.DataPropertyName;
                var gridName = grid.Name;

                if (string.IsNullOrEmpty(propertyName)) return;

                // Получаем или создаем настройки сортировки для конкретного грида
                var currentSort = SortStates.GetOrAdd(gridName, new SortSettings());

                // Определяем новое направление сортировки
                if (currentSort.SortColumn == propertyName)
                {
                    currentSort.SortAscending = !currentSort.SortAscending;
                }
                else
                {
                    currentSort.SortColumn = propertyName;
                    currentSort.SortAscending = true;
                }

                try
                {
                    // Применяем сортировку
                    var sortedData = SortData(currentData, currentSort.SortColumn, currentSort.SortAscending);

                    // Обновляем DataSource с новым списком
                    grid.DataSource = new BindingList<object>(sortedData.ToList());

                    // Обновляем индикаторы
                    UpdateSortIndicator(grid, currentSort.SortColumn, currentSort.SortAscending);

                    // Сохраняем настройки
                    SortStates[gridName] = currentSort;
                    SettingsManager.SaveSortSettings(grid, currentSort.SortColumn, currentSort.SortAscending);

                    Debug.WriteLine($"Sorting: {grid.Name} | Column: {propertyName} | Asc: {currentSort.SortAscending}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Ошибка сортировки: {ex.Message}");
                }
            }
        }

        private static IEnumerable<object> SortData(IEnumerable<object> data, string propertyName, bool ascending)
        {
            if (string.IsNullOrEmpty(propertyName)) return data;

            try
            {
                var direction = ascending ? "asc" : "desc";
                var query = data.AsQueryable();
                return ((IQueryable)query).OrderBy($"{propertyName} {direction}").Cast<object>().ToList();
            }
            catch
            {
                return data;
            }

        }

        private static void UpdateSortIndicator(DataGridView grid, string sortColumn, bool ascending)
        {
            if (grid.InvokeRequired)
            {
                grid.Invoke(new Action(() => UpdateSortIndicator(grid, sortColumn, ascending)));
                return;
            }

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            var sortCol = grid.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.DataPropertyName == sortColumn);

            if (sortCol != null)
            {
                sortCol.HeaderCell.SortGlyphDirection = ascending
                    ? SortOrder.Ascending
                    : SortOrder.Descending;
            }
        }

        public static SortSettings GetCurrentSortSettings(string gridName)
        {
            return SortStates.TryGetValue(gridName, out var settings)
                ? settings
                : new SortSettings();
        }
    }
}
