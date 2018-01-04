namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientSessionsEndpoint : IConsulClientSessionsEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientSessionsEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}