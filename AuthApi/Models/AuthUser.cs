using System.ComponentModel.DataAnnotations;

namespace AuthApi.Models
{
    public enum AuthRoles
    {
        AdminSetter,
        Admin,
        Client
    }
    public class AuthUser: AuditLight
    {
        [Key]
        public long AuthUserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthRoles Role { get; set; }

    }
}