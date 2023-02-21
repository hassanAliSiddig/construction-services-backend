using System.ComponentModel.DataAnnotations;

namespace ConstructionApi.Models
{
    public class ConstructionRequest: AuditLight
    {
        [Key]
        public long ConstructionRequestID { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }

        public long? PaymentID { get; set; }
        public Payment? Payment { get; set; }

        public long ClientID { get; set; }
        public Client Client { get; set; }

        public long ProjectID { get; set; }
        public Project Project { get; set; }

        public long StatusID { get; set; }
        public ConstructionRequestStatus Status { get; set; }

        public long CompanyID { get; set; }
        public Company Company { get; set; }
    }
}
