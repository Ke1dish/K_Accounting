using System.ComponentModel.DataAnnotations.Schema;

namespace K_Accounting.Models
{
    // Базовый класс для всех сущностей с общими полями
    public abstract class BaseEntity : Interfaces.ISoftDelete
    {
        public int Id { get; set; }                                 // Уникальный номер записи
        public bool IsDeleted { get; set; } = false;                // Помечен на удаление?

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Дата создания

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }                    // Дата изменения
    }
}
