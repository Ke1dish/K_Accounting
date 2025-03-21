using System.ComponentModel.DataAnnotations;

namespace K_Accounting.Models
{
    public class DbVersion : BaseEntity
    {
        public int Version { get; set; }
        public string ScriptName { get; set; }
        public DateTime AppliedAt { get; set; }
        public string MigrationId { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false; // Добавляем значение по умолчанию

    }
}
