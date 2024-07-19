using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Synergy.Entities
{
    public class UserServer
    {

            public int UserID { get; set; }
            [ForeignKey("UserID")]
            public User User { get; set; }

            public int ServerID { get; set; }
            [ForeignKey("ServerID")]
            public Server Server { get; set; }

            [Key, Column(Order = 0)]
            public int UserServerID { get; set; }
        }

    }

