// K_Accounting/Widgets/IncomeWidgetModel.cs
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace K_Accounting.Widgets
{
    public class IncomeWidget
    {
        public List<IncomeSource> TopSources { get; set; } = new List<IncomeSource>();

        public class IncomeSource
        {
            public string Name { get; set; }
            public decimal TotalAmount { get; set; }
        }

        public static IncomeWidget GetData()
        {
            using var db = new AppDbContext();

            var rawData = db.Incomes
                .Include(i => i.Source)
                .Where(i => !i.IsDeleted && i.Source != null)
                .Select(i => new
                {
                    i.Amount,
                    SourceName = i.Source.Name
                })
                .ToList();

            return new IncomeWidget
            {
                TopSources = rawData
                    .GroupBy(i => i.SourceName)
                    .Select(g => new IncomeSource
                    {
                        Name = g.Key ?? "Без источника",
                        TotalAmount = g.Sum(x => x.Amount)
                    })
                    .OrderByDescending(x => x.TotalAmount)
                    .Take(3)
                    .ToList()
            };
        }
    }
}