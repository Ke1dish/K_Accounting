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
    public class Currency : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(3)]
        public string Code { get; set; }

        [MaxLength(5)]
        public string Symbol { get; set; }

        [Required]
        [Precision(18, 6)]
        public decimal Rate { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        public Currency() { }

        public Currency(string name, string code, decimal rate)
        {
            Name = name;
            Code = code;
            Rate = rate;
        }
    }
}
