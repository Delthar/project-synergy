using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Synergy.Entities
{
    public class Message
    {

       
            [Key]
            public int MessageID { get; set; }
            public int ChannelID { get; set; }
            [ForeignKey("ChannelID")]
            public Channel Channel { get; set; }
            public int UserID { get; set; }
            [ForeignKey("UserID")]
            public User User { get; set; }
            [Required]
            public string Content { get; set; }
            public DateTime Timestamp { get; set; }
        }

    }

