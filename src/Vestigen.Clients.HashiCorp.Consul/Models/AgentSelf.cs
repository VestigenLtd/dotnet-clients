using System.Collections.Generic;

namespace Vestigen.Clients.HashiCorp.Consul.Models
{
    public class AgentSelf
    {
        public AgentSelfConfig Config { get; set; }

        public Dictionary<string, object> DebugConfig { get; set; }

        public Dictionary<string, string> Meta { get; set; }

        public Coordinate Coordinate { get; set; }

        public AgentMember Member { get; set; }

        public AgentSelfStatistics Stats { get; set; }
    }
}