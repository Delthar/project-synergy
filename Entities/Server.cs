
namespace Synergy.Entities
{
    public class Server
    {
        public int ServerID { get; set; }
        public string? Name { get; set; }
        public string Image { get; set; }

        public List<User>? Users { get; set; }
        public List<Role>? Roles { get; set; }

        public Server()
        {
            ServerID = 0;
            Image = "~/testimage.jpg";
        }

        public Server(int ServerID, string Image)
        {
            this.ServerID = ServerID;
            this.Image = Image;
        }
    }
}
