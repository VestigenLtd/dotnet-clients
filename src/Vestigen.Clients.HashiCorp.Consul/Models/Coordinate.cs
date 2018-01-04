namespace Vestigen.Clients.HashiCorp.Consul.Models
{
    public class Coordinate
    {
        public double Adjustment { get; set; }
        public double Error { get; set; }
        public double Height { get; set; }

        [JsonProperty("vec")]
        public double[] Vector { get; set; }
    }
}