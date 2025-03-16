using System.ComponentModel.DataAnnotations;

namespace K_Accounting.Models
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        public Category() { }

        public Category(string name)
        {
            Name = name;
        }
    }
}
