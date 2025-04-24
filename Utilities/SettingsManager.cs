using System.Text.Json;
using K_Accounting.Models;
using System.Windows.Forms;
using System.Diagnostics;
using static K_Accounting.Models.AppSettings;

namespace K_Accounting.Utilities
{
    class SettingsManager
    {
        private static readonly string SettingsFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "K_Accounting");

        private static readonly string SettingsPath = Path.Combine(
            SettingsFolder,
            "settings.json");

        public static AppSettings LoadSettings()
        {
            try
            {
                if (File.Exists(SettingsPath))
                {
                    var json = File.ReadAllText(SettingsPath);
                    return JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
                }
            }
            catch (Exception ex)
            {
                // Логирование ошибки при необходимости
                Console.WriteLine($"Error loading settings: {ex.Message}");
            }

            return new AppSettings();
        }

        public static void SaveSettings(AppSettings settings)
        {
            try
            {
                Directory.CreateDirectory(SettingsFolder);
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(settings, options);
                File.WriteAllText(SettingsPath, json);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                Console.WriteLine($"Error saving settings: {ex.Message}");
            }
        }

        public static void SaveGridSettings(DataGridView grid)
        {
            try
            {
                var settings = LoadSettings();
                var gridSettings = new GridSettings();

                foreach (DataGridViewColumn col in grid.Columns)
                {
                    gridSettings.Columns.Add(new GridColumnSettings
                    {
                        Name = col.Name,
                        Width = col.Width,
                        Visible = col.Visible,
                        MinimumWidth = col.MinimumWidth,
                        DisplayIndex = col.DisplayIndex,
                    });
                }

                settings.GridsSettings[grid.Name] = gridSettings;
                SaveSettings(settings);

            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                Debug.WriteLine($"Error saving grid settings: {ex.Message}");
            }
        }

        public static void LoadGridSettings(DataGridView grid)
        {
            var settings = LoadSettings();
            if (!settings.GridsSettings.TryGetValue(grid.Name, out var gridSettings))
                return;

            // Восстанавливаем только если столбцы существуют
            if (grid.Columns.Count == 0) return;

            // Восстанавливаем порядок и видимость столбцов
            var columnsDict = grid.Columns.Cast<DataGridViewColumn>()
                .ToDictionary(c => c.Name, c => c);

            foreach (var colSetting in gridSettings.Columns
                .OrderBy(c => c.DisplayIndex))
            {
                if (!columnsDict.TryGetValue(colSetting.Name, out var column))
                    continue;

                column.Visible = colSetting.Visible;
                column.DisplayIndex = Math.Min(colSetting.DisplayIndex, grid.Columns.Count - 1);
                column.Width = colSetting.Width;
                column.MinimumWidth = colSetting.MinimumWidth;
            }
        }

        public static void SaveSortSettings(DataGridView grid, string sortColumn, bool ascending)
        {
            try
            {
                var settings = LoadSettings();
                settings.GridsSortSettings[grid.Name] = new SortSettings
                {
                    SortColumn = sortColumn,
                    SortAscending = ascending
                };
                SaveSettings(settings);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                Debug.WriteLine($"Error saving sort settings: {ex.Message}");
            }
        }

        public static SortSettings LoadSortSettings(DataGridView grid)
        {
            var settings = LoadSettings();
            return settings.GridsSortSettings.TryGetValue(grid.Name, out var sortSettings)
                ? sortSettings
                : new SortSettings();
        }

        public static void SavePanelVisibility(bool isVisible)
        {
            try
            {
                var settings = LoadSettings();
                settings.IsPanelVisible = isVisible;
                SaveSettings(settings);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                Debug.WriteLine($"Error saving panel visibility: {ex.Message}");
            }
        }

        public static bool LoadPanelVisibility()
        {
            var settings = LoadSettings();
            return settings.IsPanelVisible;
        }

        public static void SavePanelWidgetsSettings(FlowLayoutPanel panel, CheckedListBox listBox)
        {
            try
            {
                var settings = LoadSettings();
                var widgetSettings = new List<WidgetSettings>();

                foreach (var item in listBox.Items.Cast<WidgetItem>())
                {
                    widgetSettings.Add(new WidgetSettings
                    {
                        DisplayName = item.DisplayText,
                        IsVisible = item.Widget.Visible,
                        OrderIndex = panel.Controls.GetChildIndex(item.Widget)
                    });
                }

                settings.PanelWidgetsSettings[panel.Name] = widgetSettings;
                SaveSettings(settings);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                Debug.WriteLine($"Error saving panel widgets settings: {ex.Message}");
            }
        }

        public static void LoadPanelWidgetsSettings(FlowLayoutPanel panel, CheckedListBox listBox)
        {
            var settings = LoadSettings();
            if (!settings.PanelWidgetsSettings.TryGetValue(panel.Name, out var widgetSettings))
                return;

            panel.SuspendLayout();
            listBox.BeginUpdate();

            try
            {
                listBox.Items.Clear();
                var controls = panel.Controls.Cast<System.Windows.Forms.Control>().ToList();

                var orderedControls = controls
                    .OrderBy(c => widgetSettings
                        .FirstOrDefault(ws => ws.DisplayName == c.Tag?.ToString())?.OrderIndex ?? int.MaxValue)
                    .ToList();

                panel.Controls.Clear();
                panel.Controls.AddRange(orderedControls.ToArray());

                foreach (var setting in widgetSettings.OrderBy(ws => ws.OrderIndex))
                {
                    var control = orderedControls
                        .FirstOrDefault(c => c.Tag?.ToString() == setting.DisplayName);

                    if (control == null) continue;

                    listBox.Items.Add(new WidgetItem
                    {
                        Widget = control,
                        DisplayText = setting.DisplayName
                    }, setting.IsVisible);

                    control.Visible = setting.IsVisible;
                }
            }
            finally
            {
                panel.ResumeLayout(true);
                listBox.EndUpdate();
            }
        }
    }
}
