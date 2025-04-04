using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Accounting.Reports
{
    public class IncomeVsExpensesReport : ReportBase
    {
        public IncomeVsExpensesReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Доходы vs Расходы",
                TitleFontSize = 14,
                DefaultFont = "Arial",
                Subtitle = $"Период: {_startDate:yyyy MMMM} - {_endDate:yyyy MMMM}"
            };

            var months = GetMonthsInRange(_startDate, _endDate);
            var incomeData = GetIncomeData(months);
            var expenseData = GetExpenseData(months);

            // Проверка на отсутствие данных
            if (!incomeData.Any() && !expenseData.Any())
            {
                model.Title += " (нет данных)";
                return model;
            }

            // Вычисление максимальной суммы
            var maxTotal = Math.Max(
                incomeData.Any() ? incomeData.Max(d => d.Total) : 0,
                expenseData.Any() ? expenseData.Max(d => d.Total) : 0
            );

            // Настройка осей
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Месяцы",
                GapWidth = 0.3
            };
            categoryAxis.Labels.AddRange(months.Select(m => m.ToString("MMM yyyy")));

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Maximum = (int)maxTotal + 10,//* 1.1, // Запас 10% для визуализации
                Title = "Сумма (руб)",
                StringFormat = "N0"
            };

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            // Создание серий
            var incomeSeries = new BarSeries
            {
                Title = "Доходы",
                FillColor = OxyColors.SteelBlue,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            var expenseSeries = new BarSeries
            {
                Title = "Расходы",
                FillColor = OxyColors.Orange,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            // Заполнение данными
            for (int i = 0; i < months.Count; i++)
            {
                var month = months[i];
                var income = incomeData.FirstOrDefault(d => d.Month == month)?.Total ?? 0;
                var expense = expenseData.FirstOrDefault(d => d.Month == month)?.Total ?? 0;

                incomeSeries.Items.Add(new BarItem((double)income) { CategoryIndex = i });
                expenseSeries.Items.Add(new BarItem((double)expense) { CategoryIndex = i });

                // Подсветка дефицита
                if (expense > income)
                {
                    model.Annotations.Add(new RectangleAnnotation
                    {
                        Layer = AnnotationLayer.BelowSeries,
                        Fill = OxyColor.FromAColor(30, OxyColors.Red),
                        MinimumY = i - 0.4,
                        MaximumY = i + 0.4,
                        MinimumX = 0,
                        MaximumX = (double)Math.Max(maxTotal, expense) // Защита от переполнения
                    });
                }
            }

            model.Series.Add(incomeSeries);
            model.Series.Add(expenseSeries);

            // Настройка легенды
            model.Legends.Add(new Legend
            {
                LegendPosition = LegendPosition.TopRight,
                LegendBackground = OxyColors.White
            });

            return model;
        }

        private List<DateTime> GetMonthsInRange(DateTime start, DateTime end)
        {
            var months = new List<DateTime>();
            for (var dt = start.Date; dt <= end.Date; dt = dt.AddMonths(1))
            {
                months.Add(new DateTime(dt.Year, dt.Month, 1));
            }
            return months;
        }

        private List<MonthlyData> GetIncomeData(List<DateTime> months)
        {
            return _context.Incomes
                .Include(e => e.Account)
                    .ThenInclude(a => a.Currency)
                .Where(e => !e.IsDeleted &&
                            e.Date >= _startDate &&
                            e.Date <= _endDate)
                .AsEnumerable()
                .GroupBy(e => new DateTime(e.Date.Year, e.Date.Month, 1))
                .Select(g => new MonthlyData
                {
                    Month = g.Key,
                    Total = g.Sum(e => e.Amount * e.Account.Currency.Rate)
                })
                .ToList();
        }

        private List<MonthlyData> GetExpenseData(List<DateTime> months)
        {
            return _context.Expenses
                .Include(e => e.Account)
                    .ThenInclude(a => a.Currency)
                .Where(e => !e.IsDeleted &&
                            e.Date >= _startDate &&
                            e.Date <= _endDate)
                .AsEnumerable()
                .GroupBy(e => new DateTime(e.Date.Year, e.Date.Month, 1))
                .Select(g => new MonthlyData
                {
                    Month = g.Key,
                    Total = g.Sum(e => e.Amount * e.Account.Currency.Rate)
                })
                .ToList();
        }

        private class MonthlyData
        {
            public DateTime Month { get; set; }
            public decimal Total { get; set; }
        }

        public override Control[] GetFilterControls() => Array.Empty<Control>();
        public override void ApplyFilters(Dictionary<string, object> filters) { }
        public override Dictionary<string, object> GetFilterValues() => new();
    }
}