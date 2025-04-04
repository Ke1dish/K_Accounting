using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Accounting.Reports
{
    public class AdditionalExpensesReport : ReportBase
    {
        public AdditionalExpensesReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Расходы по Упоминанию",
                TitleFontSize = 14,
                DefaultFont = "Arial",
                Subtitle = $"Период: {_startDate:dd.MM.yyyy} - {_endDate:dd.MM.yyyy}"
            };

            var expenses = _context.Expenses
                .Include(e => e.Additional)
                .Include(e => e.Account)
                    .ThenInclude(a => a.Currency)
                .Where(e => !e.IsDeleted &&
                            e.Date >= _startDate &&
                            e.Date <= _endDate)
                .ToList();

            if (!expenses.Any()) return model;

            // Группировка по названию дополнительного параметра
            var groupedData = expenses
                .GroupBy(e => e.Additional?.Name ?? "Без категории")
                .Select(g => new
                {
                    Label = g.Key,
                    Total = g.Sum(e => e.Amount * e.Account.Currency.Rate)
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            // Создаем круговую диаграмму
            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.5,
                //InsideLabelFormat = "{1}: {2:0}%",
                //OutsideLabelFormat = "{0}\n{1:N2} ₽",
                OutsideLabelFormat = "{2:0}%",
                FontSize = 12,
                Diameter = 0.8
            };

            // Цветовая палитра
            var colors = new[]
            {
                OxyColors.Blue,
                OxyColors.Green,
                OxyColors.Orange,
                OxyColors.Red,
                OxyColors.Purple
            };

            for (int i = 0; i < groupedData.Count; i++)
            {
                pieSeries.Slices.Add(new PieSlice(
                    groupedData[i].Label,
                    (double)groupedData[i].Total)
                {
                    Fill = colors[i % colors.Length],
                    IsExploded = i < 3
                });
            }

            model.Series.Add(pieSeries);
            return model;
        }

        public override Control[] GetFilterControls() => Array.Empty<Control>();
        public override void ApplyFilters(Dictionary<string, object> filters) { }
        public override Dictionary<string, object> GetFilterValues() => new();
    }
}