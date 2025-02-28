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
    public class Income : BaseEntity
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
        public int SourceId { get; set; }

        [ForeignKey("SourceId")]
        public virtual Source Source { get; set; }

        [MaxLength(1000)]
        public string Comment { get; set; }
    }
}
