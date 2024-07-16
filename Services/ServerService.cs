using Synergy.Models;

namespace Synergy.Services
{
    public class ServerService
    {
        private List<Server> serverList;

        public ServerService()
        {
            serverList = new List<Server>();

            for (int i = 0; i < 36; i++) serverList.Add(new Server(i, "/testimage.jpg"));
        }

        public List<Server> GetServerList() => serverList;

        public async Task<Server> GetServerByServerID(Int32 ServerID) => await Task.Run(() => serverList.Where(server => server.ServerID == ServerID).FirstOrDefault() ?? new Server());
    }
}
