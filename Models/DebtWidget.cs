// K_Accounting/Widgets/DebtWidgetModel.cs
using K_Accounting.Data;
using K_Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace K_Accounting.Widgets
{
    public class DebtWidget
    {
        public DebtSummary GivenDebts { get; set; } = new DebtSummary();
        public DebtSummary ReceivedDebts { get; set; } = new DebtSummary();

        public class DebtSummary
        {
            public decimal TotalAmount { get; set; }
            public decimal OverdueAmount { get; set; }
            public DateTime? NextDueDate { get; set; }
        }

        public static DebtWidget GetData()
        {
            using var db = new AppDbContext();
            var model = new DebtWidget();

            // Обработка выданных долгов (Given)
            model.GivenDebts = ProcessDebts(db, DebtType.Given);

            // Обработка полученных долгов (Received)
            model.ReceivedDebts = ProcessDebts(db, DebtType.Received);

            return model;
        }

        private static DebtSummary ProcessDebts(AppDbContext db, DebtType debtType)
        {
            var today = DateTime.Today;
            var debts = db.Debts
                .Include(d => d.Payments)
                .Where(d => d.Type == debtType &&
                           d.Status == DebtStatus.Active &&
                           !d.IsDeleted);

            var summary = new DebtSummary
            {
                TotalAmount = debts.Sum(d => d.RemainingAmount),
                OverdueAmount = debts
                    .Where(d => d.DueDate < today)
                    .Sum(d => d.RemainingAmount),
                NextDueDate = debts
                    .Where(d => d.DueDate >= today)
                    .OrderBy(d => d.DueDate)
                    .Select(d => d.DueDate)
                    .FirstOrDefault()
            };

            return summary;
        }
    }
}