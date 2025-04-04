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
    public class IncomeSourcesReport : ReportBase
    {
        public IncomeSourcesReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Источники доходов",
                TitleFontSize = 14,
                DefaultFont = "Arial",
                TitlePadding = 15,
                Subtitle = $"Период: {_startDate:dd.MM.yyyy} - {_endDate:dd.MM.yyyy}"
            };

            var incomes = _context.Incomes
                .Include(i => i.Source)
                .Include(i => i.Account)
                    .ThenInclude(a => a.Currency)
                .Where(i => !i.IsDeleted &&
                            i.Date >= _startDate &&
                            i.Date <= _endDate)
                .ToList();

            if (!incomes.Any()) return model;

            var groupedData = incomes
                .GroupBy(i => i.Source.Name)
                .Select(g => new
                {
                    Source = g.Key,
                    Total = g.Sum(i => i.Amount * i.Account.Currency.Rate)
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
                OxyColors.SteelBlue,
                OxyColors.ForestGreen,
                OxyColors.Goldenrod,
                OxyColors.Tomato,
                OxyColors.MediumOrchid
            };

            for (int i = 0; i < groupedData.Count; i++)
            {
                var slice = new PieSlice(
                    groupedData[i].Source,
                    (double)groupedData[i].Total)
                {
                    Fill = colors[i % colors.Length]
                };
                pieSeries.Slices.Add(slice);
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
        public override void ApplyDefaults() { }
    }
}