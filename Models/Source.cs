using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Accounting.Interfaces;

namespace K_Accounting.Models
{
    public class Source : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        public Source() { }

        public Source(string name)
        {
            Name = name;
        }
    }
}
