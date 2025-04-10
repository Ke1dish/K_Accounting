using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using K_Accounting.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Models
{
    public class DebtPayment : BaseEntity, ISoftDelete
    {
        [Required]
        public int DebtId { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        [Precision(18, 2)]
        public decimal Amount { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }

        // Навигационные свойства
        [ForeignKey("DebtId")]
        public virtual Debt Debt { get; set; }
    }
}