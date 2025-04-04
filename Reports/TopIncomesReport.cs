using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace K_Accounting.Reports
{
    public class TopIncomesReport : ReportBase
    {
        public TopIncomesReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Топ приходов",
                TitleFontSize = 14,
                DefaultFont = "Arial",
                TitlePadding = 15
            };

            // Получаем приходы за период
            var incomes = _context.Incomes
                .Include(i => i.Source)
                .Include(i => i.Account)
                    .ThenInclude(a => a.Currency)
                .Where(i => !i.IsDeleted &&
                            i.Date >= _startDate &&
                            i.Date <= _endDate)
                .ToList();

            if (!incomes.Any())
                return model;

            // Группируем по источникам и суммируем
            var grouped = incomes
                .GroupBy(i => i.Source.Name)
                .Select(g => new
                {
                    Name = g.Key,
                    Total = g.Sum(i => i.Amount * i.Account.Currency.Rate) // Конвертация в базовую валюту
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            // Берем топ-5 + остальные
            var topItems = grouped.Take(5).ToList();
            var others = grouped.Skip(5).Sum(x => x.Total);

            // Создаем серию для круговой диаграммы
            var pieSeries = new PieSeries
            {
                StrokeThickness = 2,
                //InsideLabelFormat = "{1}: {2:0}%",
                //OutsideLabelFormat = "{0}",
                OutsideLabelFormat = "{2:0}%",
                TickDistance = 0.3,
                TickRadialLength = 8,
                AngleSpan = 360,
                StartAngle = 0,
                FontSize = 12,
                Diameter = 0.9
            };

            // Добавляем основные источники
            foreach (var item in topItems)
            {
                pieSeries.Slices.Add(new PieSlice(
                    item.Name,
                    (double)item.Total)
                {
                    IsExploded = false
                });
            }

            // Добавляем сектор "Прочие" если есть
            if (others > 0)
            {
                pieSeries.Slices.Add(new PieSlice(
                    "Прочие",
                    (double)others)
                {
                    Fill = OxyColors.LightGray,
                    IsExploded = false
                });
            }

            model.Series.Add(pieSeries);
            return model;
        }

        public override Control[] GetFilterControls() => new Control[0];
        public override Dictionary<string, object> GetFilterValues() => new();
        public override void ApplyFilters(Dictionary<string, object> filters) { }
    }
}