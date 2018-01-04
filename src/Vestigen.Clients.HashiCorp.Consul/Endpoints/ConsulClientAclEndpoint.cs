namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientAclEndpoint : IConsulClientAclEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientAclEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}