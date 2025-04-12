using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using K_Accounting.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Models
{
    public class Goal : BaseEntity, ISoftDelete
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal TargetAmount { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual Currency Currency { get; set; }

        [Required]
        public DateTime TargetDate { get; set; }

        [Precision(18, 2)]
        public decimal CurrentAmount { get; set; } = 0;

        [Required]
        [MaxLength(20)]
        public GoalStatus Status { get; set; } = GoalStatus.Active;

        public DateTime? ReminderDate { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }
    }

}