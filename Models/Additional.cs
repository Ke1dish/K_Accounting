using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using K_Accounting.Interfaces;

namespace K_Accounting.Models
{
    public class Additional : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        public Additional() { }

        public Additional(string name)
        {
            Name = name;
        }
    }
}
