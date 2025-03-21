using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace K_Accounting.Models
{
    public class SubCategory : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [MaxLength(500)]
        public string Comment { get; set; }

        public SubCategory() { }

        public SubCategory(string name, int? categoryId)
        {
            Name = name;
            CategoryId = categoryId;
        }

        public bool RequireQuantity { get; set; } // вторая версия базы данных, добавление "Количества"

        public bool InheritQuantityRequirement { get; set; } // вторая версия базы данных, добавление "Количества"

    }
}
