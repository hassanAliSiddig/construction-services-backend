using System.ComponentModel.DataAnnotations;

namespace ConstructionApi.Models
{
    public class ProjectStatus
    {
        [Key]
        public long ProjectStatusID { get; set; }
        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}