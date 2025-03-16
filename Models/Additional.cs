using System.ComponentModel.DataAnnotations;

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
