using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Synergy.Entities
{
    
    
        public class UserChannel
        {
            public int UserID { get; set; }
            [ForeignKey("UserID")]
            public User User { get; set; }
            public int ChannelID { get; set; }
            [ForeignKey("ChannelID")]
            public Channel Channel { get; set; }

            [Key, Column(Order = 0)]
            public int UserChannelID { get; set; }
        }

    
}
