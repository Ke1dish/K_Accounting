// K_Accounting/Widgets/AccountWidget.cs
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace K_Accounting.Widgets
{
    public class AccountWidgetModel
    {
        public decimal TotalBalance { get; set; }
        public decimal YesterdayIncome { get; set; }
        public decimal YesterdayExpense { get; set; }
        public decimal TodayIncome { get; set; }
        public decimal TodayExpense { get; set; }

        public static AccountWidgetModel GetData()
        {
            using var db = new AppDbContext();

            var yesterday = DateTime.Today.AddDays(-1);
            var today = DateTime.Today;

            return new AccountWidgetModel
            {
                TotalBalance = CalculateTotalBalance(db),
                YesterdayIncome = GetIncomeForDate(db, yesterday),
                YesterdayExpense = GetExpenseForDate(db, yesterday),
                TodayIncome = GetIncomeForDate(db, today),
                TodayExpense = GetExpenseForDate(db, today)
            };
        }

        private static decimal CalculateTotalBalance(AppDbContext db)
        {
            return db.Accounts
                .Include(a => a.Currency)
                .AsEnumerable()
                .Sum(a => a.Balance * a.Currency.Rate);
        }

        private static decimal GetIncomeForDate(AppDbContext db, DateTime date)
        {
            return db.Incomes
                .Where(i => i.Date.Date == date)
                .Sum(i => i.Amount);
        }

        private static decimal GetExpenseForDate(AppDbContext db, DateTime date)
        {
            return db.Expenses
                .Where(e => e.Date.Date == date)
                .Sum(e => e.Amount);
        }
    }
}