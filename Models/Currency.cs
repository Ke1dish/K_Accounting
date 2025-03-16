using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace K_Accounting.Models
{
    public class Currency : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(5)]
        public string Symbol { get; set; }

        [Required]
        [Precision(18, 6)]
        public decimal Rate { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        public Currency() { }

        public Currency(string name, decimal rate)
        {
            Name = name;
            Rate = rate;
        }
    }
}
