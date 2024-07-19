using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Synergy.Entities
{
    public class Permission
    {
        [Key]
        public int PermissionID { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public Role Role { get; set; }
        [Required, MaxLength(20)]
        public string PermissionType { get; set; }
    }

}
