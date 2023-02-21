using System.ComponentModel.DataAnnotations;

namespace ConstructionApi.Models
{
    public enum PaymentStatus
    {
        Pending,
        Failed,
        succeeded
    }
    public class Payment: AuditLight
    {
        [Key]
        public long PaymentID { get; set; }
        public double Amount { get; set; }
        public string OrderID { get; set; }
        public long? AuthCode { get; set; }
        public string? ResponseMessage { get; set; }
        public PaymentStatus Status { get; set; }
        public ConstructionRequest ConstructionRequest { get; set; }
    }
}