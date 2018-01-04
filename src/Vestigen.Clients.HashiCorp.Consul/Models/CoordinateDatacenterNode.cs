namespace Vestigen.Clients.HashiCorp.Consul.Models
{
    public class CoordinateDatacenterNode
    {
        [JsonProperty("node")]
        public string NodeName { get; set; }

        public string Segment { get; set; }

        [JsonProperty("coord")]
        public Coordinate Coordinate { get; set; }
    }
}