using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Synergy.Entities
{
    public class UserRole
    {
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public Role Role { get; set; }

        [Key, Column(Order = 0)]
        public int UserRoleID { get; set; }
    }

}
