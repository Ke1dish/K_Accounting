// K_Accounting/Widgets/ProfitWidgetModel.cs
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace K_Accounting.Widgets
{
    public class ProfitWidget
    {
        public decimal CurrentMonthIncome { get; set; }
        public decimal PreviousMonthIncome { get; set; }
        public decimal IncomeChangePercent { get; set; }

        public decimal CurrentMonthExpense { get; set; }
        public decimal PreviousMonthExpense { get; set; }
        public decimal ExpenseChangePercent { get; set; }

        public DateTime? BestDay { get; set; }
        public DateTime? WorstDay { get; set; }

        public static ProfitWidget GetData()
        {
            using var db = new AppDbContext();

            var today = DateTime.Today;
            var currentMonthStart = new DateTime(today.Year, today.Month, 1);
            var previousMonthStart = currentMonthStart.AddMonths(-1);

            // Получение данных о приходах
            var incomeData = GetIncomeData(db, currentMonthStart, previousMonthStart);

            // Получение данных о расходах
            var expenseData = GetExpenseData(db, currentMonthStart, previousMonthStart);

            // Поиск лучшего/худшего дня
            var dailyStats = GetDailyStats(db, currentMonthStart);

            return new ProfitWidget
            {
                CurrentMonthIncome = incomeData.Current,
                PreviousMonthIncome = incomeData.Previous,
                IncomeChangePercent = CalculateChangePercent(incomeData.Previous, incomeData.Current),

                CurrentMonthExpense = expenseData.Current,
                PreviousMonthExpense = expenseData.Previous,
                ExpenseChangePercent = CalculateChangePercent(expenseData.Previous, expenseData.Current),

                BestDay = dailyStats.BestDay,
                WorstDay = dailyStats.WorstDay
            };
        }

        private static (decimal Current, decimal Previous) GetIncomeData(
            AppDbContext db,
            DateTime currentStart,
            DateTime previousStart)
        {
            var current = db.Incomes
                .Where(x => x.Date >= currentStart && x.Date < currentStart.AddMonths(1))
                .Sum(x => x.Amount);

            var previous = db.Incomes
                .Where(x => x.Date >= previousStart && x.Date < previousStart.AddMonths(1))
                .Sum(x => x.Amount);

            return (current, previous);
        }

        private static (decimal Current, decimal Previous) GetExpenseData(
            AppDbContext db,
            DateTime currentStart,
            DateTime previousStart)
        {
            var current = db.Expenses
                .Where(x => x.Date >= currentStart && x.Date < currentStart.AddMonths(1))
                .Sum(x => x.Amount);

            var previous = db.Expenses
                .Where(x => x.Date >= previousStart && x.Date < previousStart.AddMonths(1))
                .Sum(x => x.Amount);

            return (current, previous);
        }

        private static decimal CalculateChangePercent(decimal previous, decimal current)
        {
            if (previous == 0) return current == 0 ? 0 : 100 * Math.Sign(current);
            return Math.Round((current - previous) / previous * 100, 1);
        }

        private static (DateTime? BestDay, DateTime? WorstDay) GetDailyStats(
            AppDbContext db,
            DateTime monthStart)
        {
            var endDate = monthStart.AddMonths(1);

            // Получаем доходы по дням
            var incomesByDay = db.Incomes
                .Where(i => i.Date >= monthStart && i.Date < endDate)
                .GroupBy(i => i.Date.Date)
                .Select(g => new { Date = g.Key, Income = g.Sum(i => i.Amount) })
                .ToList();

            // Получаем расходы по дням
            var expensesByDay = db.Expenses
                .Where(e => e.Date >= monthStart && e.Date < endDate)
                .GroupBy(e => e.Date.Date)
                .Select(g => new { Date = g.Key, Expense = g.Sum(e => e.Amount) })
                .ToList();

            // Объединяем данные
            var dailyStats = from i in incomesByDay
                             join e in expensesByDay on i.Date equals e.Date into joined
                             from j in joined.DefaultIfEmpty()
                             select new
                             {
                                 i.Date,
                                 Income = i.Income,
                                 Expense = j?.Expense ?? 0
                             };

            var ordered = dailyStats
                .OrderByDescending(d => d.Income - d.Expense)
                .ToList();

            return (
                ordered.FirstOrDefault()?.Date,
                ordered.LastOrDefault()?.Date
            );
        }
    }
}