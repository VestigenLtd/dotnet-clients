using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public interface IConsulClientStatusEndpoint
    {
        Task<string> GetLeader();
        Task<List<string>> GetPeers();
    }
}