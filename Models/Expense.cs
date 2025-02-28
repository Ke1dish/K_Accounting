using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Accounting.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace K_Accounting.Models
{
    public class Expense : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        [Precision(18, 2)]
        public decimal Amount { get; set; }

        [Required]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Required]
        public int SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }

        [Required]
        public int AdditionalId { get; set; }

        [ForeignKey("AdditionalId")]
        public virtual Additional Additional { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }

        public bool IsTemplate { get; set; }
    }
}
