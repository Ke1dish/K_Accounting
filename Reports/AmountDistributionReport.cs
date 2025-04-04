using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace K_Accounting.Reports
{
    public class AmountDistributionReport : ReportBase
    {
        private const int BinCount = 10; // Количество интервалов

        public AmountDistributionReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Распределение сумм",
                TitleFontSize = 14,
                DefaultFont = "Arial",
                Subtitle = $"Период: {_startDate:dd.MM.yyyy} - {_endDate:dd.MM.yyyy}"
            };

            var amounts = GetFilteredAmounts();
            if (!amounts.Any())
            {
                model.Title += " (нет данных)";
                return model;
            }

            var (bins, counts) = CalculateHistogram(amounts);
            var series = CreateHistogramSeries(bins, counts);
            ConfigureAxes(model, bins.Max());

            model.Series.Add(series);
            return model;
        }

        private List<decimal> GetFilteredAmounts()
        {
            var amounts = new List<decimal>();

            // Фильтрация по типу операций
            var showIncomes = _currentFilters.TryGetValue("ShowIncomes", out var showIncomesVal)
                ? (bool)showIncomesVal
                : true;
            var showExpenses = _currentFilters.TryGetValue("ShowExpenses", out var showExpensesVal)
                ? (bool)showExpensesVal
                : true;

            if (showIncomes)
            {
                amounts.AddRange(_context.Incomes
                    .Include(i => i.Account)
                        .ThenInclude(a => a.Currency)
                    .Where(i => !i.IsDeleted && i.Date >= _startDate && i.Date <= _endDate)
                    .Select(i => i.Amount * i.Account.Currency.Rate));
            }

            if (showExpenses)
            {
                amounts.AddRange(_context.Expenses
                    .Include(e => e.Account)
                        .ThenInclude(a => a.Currency)
                    .Where(e => !e.IsDeleted && e.Date >= _startDate && e.Date <= _endDate)
                    .Select(e => e.Amount * e.Account.Currency.Rate));
            }

            return amounts;
        }

        private (decimal[] bins, int[] counts) CalculateHistogram(List<decimal> amounts)
        {
            if (!amounts.Any()) return (Array.Empty<decimal>(), Array.Empty<int>());

            var maxAmount = amounts.Max();
            var binSize = Math.Ceiling((double)maxAmount / BinCount);

            var bins = Enumerable.Range(0, BinCount)
                .Select(i => (decimal)(i * binSize))
                .ToArray();

            var counts = new int[BinCount];
            foreach (var amount in amounts)
            {
                var binIndex = (int)((double)amount / binSize);
                if (binIndex >= BinCount) binIndex = BinCount - 1;
                counts[binIndex]++;
            }

            return (bins, counts);
        }

        private BarSeries CreateHistogramSeries(decimal[] bins, int[] counts)
        {
            var series = new BarSeries
            {
                Title = "Количество операций",
                FillColor = OxyColors.SteelBlue,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            for (int i = 0; i < BinCount; i++)
            {
                series.Items.Add(new BarItem(counts[i]));
            }

            return series;
        }

        private void ConfigureAxes(PlotModel model, decimal maxBin)
        {
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,//.Bottom,
                Title = "Диапазоны сумм",
                GapWidth = 0.1
            };

            for (int i = 0; i < BinCount; i++)
            {
                var start = i * (double)maxBin / BinCount;
                var end = (i + 1) * (double)maxBin / BinCount;
                categoryAxis.Labels.Add($"{start:N0} - {end:N0} ₽");
            }

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,//.Left,
                Title = "Количество операций",
                Minimum = 0
            };

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);
        }

        public override Control[] GetFilterControls()
        {
            var typeComboBox = new ComboBox
            {
                Dock = DockStyle.Top,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Items = { "Все", "Доходы", "Расходы" },
                SelectedIndex = 0
            };

            // Восстановление сохраненного фильтра
            if (_currentFilters.TryGetValue("OperationType", out var savedValue))
            {
                typeComboBox.SelectedIndex = (string)savedValue switch
                {
                    "Доходы" => 1,
                    "Расходы" => 2,
                    _ => 0
                };
            }

            typeComboBox.SelectedIndexChanged += (s, e) =>
            {
                var selection = (string)typeComboBox.SelectedItem;
                _currentFilters["OperationType"] = selection;
                _currentFilters["ShowIncomes"] = selection != "Расходы";
                _currentFilters["ShowExpenses"] = selection != "Доходы";
                base.OnFilterChanged(EventArgs.Empty); // Вызов через базовый класс
                //OnFilterChanged?.Invoke(this, EventArgs.Empty);
            };

            return new Control[]
            {
                new Label { Text = "Тип операций:", Dock = DockStyle.Top },
                typeComboBox
            };
        }

        public override void ApplyDefaults() { }
    }
}