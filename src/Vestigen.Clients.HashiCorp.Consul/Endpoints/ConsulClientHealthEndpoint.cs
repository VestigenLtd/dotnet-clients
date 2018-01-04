namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientHealthEndpoint : IConsulClientHealthEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientHealthEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}