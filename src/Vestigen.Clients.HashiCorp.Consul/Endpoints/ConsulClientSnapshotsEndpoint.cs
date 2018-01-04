namespace Vestigen.Clients.HashiCorp.Consul.Endpoints
{
    public class ConsulClientSnapshotsEndpoint : IConsulClientSnapshotsEndpoint
    {
        private readonly IConsulClient _consulClient;

        public ConsulClientSnapshotsEndpoint(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }
    }
}