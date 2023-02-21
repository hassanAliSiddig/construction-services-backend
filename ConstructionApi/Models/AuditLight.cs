namespace ConstructionApi.Models
{
    public enum EntityStatus
    {
        Disabled,
        Active,
        SoftlyDeleted
    }
    public class AuditLight
    {
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;
        public string AddedBy { get; set; } = string.Empty;
        public DateTime ChangedOn { get; set; } = DateTime.UtcNow;
        public string ChangedBy { get; set; } = String.Empty;
        public EntityStatus EntityStatus { get; set; } = EntityStatus.Active;
    }
}
