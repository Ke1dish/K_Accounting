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
    public class BalanceDynamicReport : ReportBase
    {
        public BalanceDynamicReport(AppDbContext context, DateTime startDate, DateTime endDate)
            : base(context, startDate, endDate) { }

        public override PlotModel CreatePlotModel()
        {
            var model = new PlotModel
            {
                Title = "Динамика баланса счетов",
                TitleFontSize = 14,
                DefaultFont = "Arial"
            };

            // Получаем все счета с их валютами
            var accounts = _context.Accounts
                .Include(a => a.Currency)
                .Where(a => !a.IsDeleted)
                .ToList();

            if (!accounts.Any())
                return model;

            // Создаем временные точки (например, по дням/неделям/месяцам)
            var timePoints = GenerateTimePoints(_startDate, _endDate);

            // Добавляем оси
            model.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Дата",
                StringFormat = "dd.MM.yy",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Баланс",
                MajorGridlineStyle = LineStyle.Solid
            });

            // Для каждого аккаунта строим линию
            foreach (var account in accounts)
            {
                var lineSeries = new LineSeries
                {
                    Title = $"{account.Name} ({account.Currency?.Symbol})",
                    MarkerType = MarkerType.Circle,
                    MarkerSize = 4,
                    MarkerStroke = OxyColors.White
                };

                // Рассчитываем баланс на каждую временную точку
                foreach (var date in timePoints)
                {
                    var balance = CalculateAccountBalance(account, date);
                    lineSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), (double)balance));
                }

                model.Series.Add(lineSeries);
            }

            return model;
        }

        private List<DateTime> GenerateTimePoints(DateTime start, DateTime end)
        {
            var timePoints = new List<DateTime>();
            var totalDays = (end - start).TotalDays;

            // Выбираем интервал в зависимости от периода
            if (totalDays <= 31) // До 1 месяца - по дням
            {
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                    timePoints.Add(dt);
            }
            else if (totalDays <= 365) // До года - по неделям
            {
                for (var dt = start; dt <= end; dt = dt.AddDays(7))
                    timePoints.Add(dt);
            }
            else // Более года - по месяцам
            {
                for (var dt = start; dt <= end; dt = dt.AddMonths(1))
                    timePoints.Add(dt);
            }

            return timePoints;
        }

        private decimal CalculateAccountBalance(Account account, DateTime date)
        {
            // Начальный баланс
            var balance = account.Balance;

            // Вычитаем расходы после даты
            balance -= _context.Expenses
                .Where(e => e.AccountId == account.Id &&
                            e.Date > date &&
                            !e.IsDeleted)
                .Sum(e => e.Amount);

            // Добавляем приходы после даты
            balance += _context.Incomes
                .Where(i => i.AccountId == account.Id &&
                           i.Date > date &&
                           !i.IsDeleted)
                .Sum(i => i.Amount);

            // Конвертируем в базовую валюту (если нужно)
            return balance * (account.Currency?.Rate ?? 1m);
        }

        public override Control[] GetFilterControls() => new Control[0];

        public override Dictionary<string, object> GetFilterValues() => new();
        public override void ApplyFilters(Dictionary<string, object> filters) { }
    }
}