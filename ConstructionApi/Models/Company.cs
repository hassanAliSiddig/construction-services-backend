using System.ComponentModel.DataAnnotations;

namespace ConstructionApi.Models
{
    public class Company: AuditLight
    {
        [Key]
        public long CompanyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<ConstructionRequest> ConstructionRequests { get; set; }
    }
}
