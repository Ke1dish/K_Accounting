namespace K_Accounting.Models
{
    public class DbVersion : BaseEntity
    {
        public int Version { get; set; }
        public string ScriptName { get; set; }
        public DateTime AppliedAt { get; set; }
        public string MigrationId { get; set; }

    }
}
