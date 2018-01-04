using Vestigen.Clients.HashiCorp.Consul.Endpoints;

namespace Vestigen.Clients.HashiCorp.Consul
{
    public interface IConsulEndpoints : IHashiCorpEndpoints
    {
        IConsulClientAclEndpoint Acl { get; }
        IConsulClientAgentEndpoint Agent { get; }
        IConsulClientCatalogEndpoint Catalog { get; }
        IConsulClientCoordinatesEndpoint Coordinates { get; }
        IConsulClientEventsEndpoint Events { get; }
        IConsulClientHealthEndpoint Health { get; }
        IConsulClientKeyValuesEndpoint KeyValues { get; }
        IConsulClientOperatorEndpoint Operator { get; }
        IConsulClientSessionsEndpoint Sessions { get; }
        IConsulClientSnapshotsEndpoint Snapshots { get; }
        IConsulClientStatusEndpoint Status { get; }
        IConsulClientTransactionsEndpoint Transactions { get; }
    }
}