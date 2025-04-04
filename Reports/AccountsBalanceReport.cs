using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Accounting.Data;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Reports
{
    // Отчет "Баланс счетов"
    public class AccountsBalanceReport : ReportBase
    {
        public AccountsBalanceReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Баланс счетов",
                DefaultFont = "Arial",
                TitleFontSize = 14
            };

            var accounts = _context.Accounts
                .Include(a => a.Currency)
                .Where(a => !a.IsDeleted)
                //.OrderByDescending(a => a.Balance) // Сортировка по убыванию баланса
                .ToList();

            var series = new BarSeries
            {
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:N0} ₽",
                FillColor = OxyColor.FromRgb(70, 130, 180) // Цвет столбцов
            };

            // Собираем названия счетов и балансы
            var categories = new List<string>();
            foreach (var account in accounts)
            {
                series.Items.Add(new BarItem((double)account.Balance));
                categories.Add($"{account.Name}\n({account.Currency?.Symbol})"); // Название + валюта
            }

            // Добавляем оси
            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                ItemsSource = categories,
                Title = "Счета",
                Key = "AccountsAxis"
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Minimum = 0,
                Title = "Сумма",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            model.Series.Add(series);
            return model;
        }

        public override Control[] GetFilterControls() => new Control[0];

        public override Dictionary<string, object> GetFilterValues() => new();
        public override void ApplyFilters(Dictionary<string, object> filters) { }

    }
}
