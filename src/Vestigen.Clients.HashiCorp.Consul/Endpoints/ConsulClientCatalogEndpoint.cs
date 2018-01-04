namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientCatalogEndpoint : IConsulClientCatalogEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientCatalogEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}