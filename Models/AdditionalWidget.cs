// K_Accounting/Widgets/AdditionalWidgetModel.cs
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace K_Accounting.Widgets
{
    public class AdditionalWidget
    {
        public List<AdditionalItem> TopAdditionals { get; set; } = new List<AdditionalItem>();

        public class AdditionalItem
        {
            public string Name { get; set; }
            public decimal TotalAmount { get; set; }
        }

        public static AdditionalWidget GetData()
        {
            //using var db = new AppDbContext();

            //return new AdditionalWidget
            //{
            //    TopAdditionals = db.Expenses
            //        .Include(e => e.Additional)
            //        .Where(e => !e.IsDeleted && e.Additional != null)
            //        .GroupBy(e => e.Additional.Name)
            //        .Select(g => new AdditionalItem
            //        {
            //            Name = g.Key ?? "Без названия",
            //            TotalAmount = g.Sum(e => e.Amount)
            //        })
            //        .OrderByDescending(x => x.TotalAmount)
            //        .Take(3)
            //        .ToList()
            //};



            using var db = new AppDbContext();

            var rawData = db.Expenses
                .Include(e => e.Additional)
                .Where(e => !e.IsDeleted && e.Additional != null)
                .Select(e => new
                {
                    e.Amount,
                    e.Additional.Name
                })
                .ToList(); // Получаем минимальные данные

            var processed = rawData
                .GroupBy(e => e.Name)
                .Select(g => new AdditionalItem
                {
                    Name = g.Key ?? "Без названия",
                    TotalAmount = g.Sum(x => x.Amount)
                })
                .OrderByDescending(x => x.TotalAmount)
                .Take(3)
                .ToList();

            return new AdditionalWidget
            {
                TopAdditionals = processed
            };
        }
    }
}