using System.ComponentModel.DataAnnotations;

namespace ConstructionApi.Models
{
    public class ConstructionRequestStatus
    {
        [Key]
        public long ConstructionRequestStatusID { get; set; }
        public string Name { get; set; }

        public ICollection<ConstructionRequest> ConstructionRequests { get; set; }
    }
}
