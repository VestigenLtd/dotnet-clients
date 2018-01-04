namespace Vestigen.Clients.HashiCorp.Consul.Models
{
    public class AgentSelfStatisticsConsul
    {
        [JsonProperty("bootstrap")]
        public bool IsBootstrap { get; set; }

        [JsonProperty("known_datacenters")]
        public int KnownDatacenters { get; set; }

        [JsonProperty("leader_addr")]
        public string LeaderAddress { get; set; }

        [JsonProperty("server")]
        public bool IsServer { get; set; }

        [JsonProperty("leader")]
        public bool IsLeader { get; set; }
    }
}