namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientTransactionsEndpoint : IConsulClientTransactionsEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientTransactionsEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}