using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Numerics;

namespace Synergy.Entities
{
    public class User
    {

        [Key]
        public int UserID { get; set; }
        [Required, MaxLength(50)]
        public string Username { get; set; }
        [Required, MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }
        public DateTime LastActive { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
        public List<UserChannel> UserChannels { get; set; } = new List<UserChannel>();
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public List<UserServer> UserServers { get; set; } = new List<UserServer>();
    }
}
