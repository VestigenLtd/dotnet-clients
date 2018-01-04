using System.Collections.Generic;
using System.Threading.Tasks;
using Vestigen.Clients.HashiCorp.Consul.Models;

namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public interface IConsulClientAgentEndpoint
    {
        Task<List<AgentMember>> GetMembers();
        Task<AgentSelf> GetSelf();
    }
}