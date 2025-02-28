using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Accounting.Interfaces;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.ComponentModel.DataAnnotations.Schema;

namespace K_Accounting.Models
{
    public class Account : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [Precision(18, 2)]
        public decimal Balance { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual Currency Currency { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        public Account() { }

        public Account(string name, decimal balance, int currencyId)
        {
            Name = name;
            Balance = balance;
            CurrencyId = currencyId;
        }
    }
}
