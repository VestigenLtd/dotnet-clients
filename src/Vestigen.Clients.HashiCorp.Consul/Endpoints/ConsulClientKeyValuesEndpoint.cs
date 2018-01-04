namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientKeyValuesEndpoint : IConsulClientKeyValuesEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientKeyValuesEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}