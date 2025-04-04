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
    public class TopExpensesReport : ReportBase
    {
        public TopExpensesReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Топ расходов",
                TitleFontSize = 14,
                DefaultFont = "Arial",
                TitlePadding = 15
            };

            // Получаем расходы за период
            var expenses = _context.Expenses
                .Include(e => e.Category)
                .Include(e => e.SubCategory)
                .Include(e => e.Account)
                    .ThenInclude(a => a.Currency)
                .Where(e => !e.IsDeleted &&
                            e.Date >= _startDate &&
                            e.Date <= _endDate)
                .ToList();

            if (!expenses.Any())
                return model;

            // Группируем по категориям/подкатегориям и суммируем
            var grouped = expenses
                .GroupBy(e => $"{e.Category.Name}: {e.SubCategory.Name}")
                .Select(g => new
                {
                    Name = g.Key,
                    Total = g.Sum(e => e.Amount * e.Account.Currency.Rate) // Конвертация в базовую валюту
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

            // Добавляем основные категории
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