using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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

        [Precision(9, 3)]
        public decimal Quantity { get; set; } = 1;  // вторая версия базы данных, добавление "Количества"
        public bool IsAutoUnit { get; set; } = true;  // вторая версия базы данных, добавление "Количества"
    }
}
