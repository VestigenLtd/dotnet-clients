using System.Collections.Generic;

namespace Vestigen.Clients.HashiCorp.Consul.Models
{
    public class CoordinateDatacenter
    {
        [JsonProperty("datacenter")]
        public string DatacenterName { get; set; }

        public string AreaId { get; set; }

        public List<CoordinateDatacenterNode> Coordinates { get; set; }
    }
}