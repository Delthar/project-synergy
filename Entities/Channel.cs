using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Synergy.Entities
{
    public class Channel
    {
        [Key]
        public int ChannelID { get; set; }
        public int? ServerID { get; set; }  
        [ForeignKey("ServerID")]
        public Server Server { get; set; }
        [Required, MaxLength(100)]
        public string ChannelName { get; set; }
        public bool IsDirect { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
        public List<UserChannel> UserChannels { get; set; } = new List<UserChannel>();
    }

}
