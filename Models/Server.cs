namespace Synergy.Models
{
    public class Server
    {
        public Int32 ServerID { get; set; }
        public String? Name { get; set; }
        public String Image { get; set; }
        
        public List<User>? Users { get; set; }
        public List<Role>? Roles { get; set; }

        public Server()
        {
            ServerID = 0;
            Image = "~/testimage.jpg";
        }

        public Server(Int32 ServerID, String Image)
        {
            this.ServerID = ServerID;
            this.Image = Image;
        }
    }
}
