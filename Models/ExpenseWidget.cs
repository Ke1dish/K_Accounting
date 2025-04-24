// Класс модели ExpenseWidgetModel.cs
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace K_Accounting.Widgets
{
    public class ExpenseWidget
    {
        public List<CategoryExpense> TopCategories { get; set; } = new List<CategoryExpense>();

        public class CategoryExpense
        {
            public string CategoryName { get; set; }
            public decimal TotalAmount { get; set; }
        }

        public static ExpenseWidget GetData()
        {
            using var db = new AppDbContext();

            var rawData = db.Expenses
                .Include(e => e.Category)
                .Where(e => !e.IsDeleted && e.Category != null)
                .Select(e => new
                {
                    e.Amount,
                    CategoryName = e.Category.Name
                })
                .ToList();

            return new ExpenseWidget
            {
                TopCategories = rawData
                    .GroupBy(e => e.CategoryName)
                    .Select(g => new CategoryExpense
                    {
                        CategoryName = g.Key ?? "Без категории",
                        TotalAmount = g.Sum(x => x.Amount)
                    })
                    .OrderByDescending(x => x.TotalAmount)
                    .Take(3)
                    .ToList()
            };
        }
    }
}