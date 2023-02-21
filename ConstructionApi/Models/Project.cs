using System.ComponentModel.DataAnnotations;

namespace ConstructionApi.Models
{
    public class Project:AuditLight
    {
        [Key]
        public long ProjectID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedCompletionDate { get; set; }
        public long StatusID { get; set; }
        public ProjectStatus Status { get; set; }

        public ICollection<ConstructionRequest> ConstructionRequests { get; set; }
    }
}
