namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientEventsEndpoint : IConsulClientEventsEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientEventsEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}