// BudgetWidgetModel.cs
using K_Accounting.Data;
using K_Accounting.Models;
using K_Accounting.Widgets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace K_Accounting.Widgets
{
    public class BudgetWidget
    {
        public decimal MonthlyLimit { get; set; }
        public decimal Spent { get; set; }
        public decimal Remaining => MonthlyLimit - Spent;
        public string Progress { get; set; }
        public string TopOverCategory { get; set; }

        public static BudgetWidget GetData()
        {
            using var db = new AppDbContext();

            var today = DateTime.Today;
            var firstDay = new DateTime(today.Year, today.Month, 1);
            var lastDay = firstDay.AddMonths(1).AddDays(-1);

            return new BudgetWidget
            {
                MonthlyLimit = GetMonthlyLimit(db),
                Spent = db.Expenses
                    .Where(e => e.Date >= firstDay && e.Date <= lastDay)
                    .Sum(e => e.Amount),
                Progress = $"{today.Day}/{DateTime.DaysInMonth(today.Year, today.Month)}",
                //TopOverCategory = GetTopOverCategory(db, firstDay, lastDay)
            };
        }

        private static decimal GetMonthlyLimit(AppDbContext db)
        {
            // Ваша логика получения лимита
            return 50000; // Пример
        }

        private static string GetTopOverCategory(/*...*/)
        {
            // Логика определения категории
            return "Продукты";
        }
    }
}