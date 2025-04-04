using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Accounting.Reports
{
    public class DistributionExpensesReport : ReportBase
    {
        public DistributionExpensesReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Распределение расходов",
                TitleFontSize = 14,
                DefaultFont = "Arial",
                TitlePadding = 15,
                Subtitle = $"Период: {_startDate:dd.MM.yyyy} - {_endDate:dd.MM.yyyy}"
            };

            var expenses = _context.Expenses
                .Include(e => e.Category)
                .Include(e => e.Account)
                    .ThenInclude(a => a.Currency)
                .Where(e => !e.IsDeleted &&
                            e.Date >= _startDate &&
                            e.Date <= _endDate)
                .ToList();

            if (!expenses.Any()) return model;

            var groupedData = expenses
                .GroupBy(e => e.Category.Name)
                .Select(g => new
                {
                    Category = g.Key,
                    Total = g.Sum(e => e.Amount * e.Account.Currency.Rate)
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.5,
                OutsideLabelFormat = "{2:0}%",
                TickDistance = 0.2,
                AngleSpan = 360,
                StartAngle = 0,
                FontSize = 12,
                Diameter = 0.8,
                ExplodedDistance = 0.05
            };

            var colors = new[]
            {
                OxyColors.RoyalBlue,
                OxyColors.OrangeRed,
                OxyColors.ForestGreen,
                OxyColors.Goldenrod,
                OxyColors.MediumPurple,
                OxyColors.Turquoise
            };

            for (int i = 0; i < groupedData.Count; i++)
            {
                pieSeries.Slices.Add(new PieSlice(
                    groupedData[i].Category,
                    (double)groupedData[i].Total)
                {
                    Fill = colors[i % colors.Length],
                    IsExploded = i == 0
                });
            }

            model.Legends.Add(new Legend
            {
                LegendPosition = LegendPosition.RightTop,
                LegendBackground = OxyColors.White,
                LegendBorder = OxyColors.Black,
                LegendBorderThickness = 1
            });

            model.Series.Add(pieSeries);
            return model;
        }

        public override Control[] GetFilterControls() => Array.Empty<Control>();
        public override void ApplyFilters(Dictionary<string, object> filters) { }
        public override Dictionary<string, object> GetFilterValues() => new();
    }
}