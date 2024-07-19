using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Synergy.Entities
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public int ServerID { get; set; }
        [ForeignKey("ServerID")]
        public Server Server { get; set; }
        [Required, MaxLength(50)]
        public string RoleName { get; set; }

        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public List<Permission> Permissions { get; set; } = new List<Permission>();
    }
}