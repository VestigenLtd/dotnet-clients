using System;
using System.Threading;
using Vestigen.Clients.HashiCorp.Consul.Endpoints;

namespace Vestigen.Clients.HashiCorp.Consul
{
    public class ConsulEndpoints : IConsulEndpoints
    {
        private readonly Lazy<IConsulClientAclEndpoint> _endpointAcl;
        private readonly Lazy<IConsulClientAgentEndpoint> _endpointAgent;
        private readonly Lazy<IConsulClientCatalogEndpoint> _endpointCatalog;
        private readonly Lazy<IConsulClientCoordinatesEndpoint> _endpointCoordinates;
        private readonly Lazy<IConsulClientEventsEndpoint> _endpointEvents;
        private readonly Lazy<IConsulClientHealthEndpoint> _endpointHealth;
        private readonly Lazy<IConsulClientKeyValuesEndpoint> _endpointKeyValues;
        private readonly Lazy<IConsulClientOperatorEndpoint> _endpointOperator;
        private readonly Lazy<IConsulClientSessionsEndpoint> _endpointSessions;
        private readonly Lazy<IConsulClientSnapshotsEndpoint> _endpointSnapshots;
        private readonly Lazy<IConsulClientStatusEndpoint> _endpointStatus;
        private readonly Lazy<IConsulClientTransactionsEndpoint> _endpointTransactions;

        internal ConsulEndpoints(IConsulClient client)
        {
            _endpointAcl = new Lazy<IConsulClientAclEndpoint>(() => new ConsulClientAclEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointAgent = new Lazy<IConsulClientAgentEndpoint>(() => new ConsulClientAgentEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointCatalog = new Lazy<IConsulClientCatalogEndpoint>(() => new ConsulClientCatalogEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointCoordinates = new Lazy<IConsulClientCoordinatesEndpoint>(() => new ConsulClientCoordinatesEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointEvents = new Lazy<IConsulClientEventsEndpoint>(() => new ConsulClientEventsEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointHealth = new Lazy<IConsulClientHealthEndpoint>(() => new ConsulClientHealthEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointKeyValues = new Lazy<IConsulClientKeyValuesEndpoint>(() => new ConsulClientKeyValuesEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointOperator = new Lazy<IConsulClientOperatorEndpoint>(() => new ConsulClientOperatorEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointSessions = new Lazy<IConsulClientSessionsEndpoint>(() => new ConsulClientSessionsEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointSnapshots = new Lazy<IConsulClientSnapshotsEndpoint>(() => new ConsulClientSnapshotsEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointStatus = new Lazy<IConsulClientStatusEndpoint>(() => new ConsulClientStatusEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointTransactions = new Lazy<IConsulClientTransactionsEndpoint>(() => new ConsulClientTransactionsEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
        }

        public IConsulClientAclEndpoint Acl => _endpointAcl.Value;

        public IConsulClientAgentEndpoint Agent => _endpointAgent.Value;

        public IConsulClientCatalogEndpoint Catalog => _endpointCatalog.Value;

        public IConsulClientCoordinatesEndpoint Coordinates => _endpointCoordinates.Value;

        public IConsulClientEventsEndpoint Events => _endpointEvents.Value;

        public IConsulClientHealthEndpoint Health => _endpointHealth.Value;

        public IConsulClientKeyValuesEndpoint KeyValues => _endpointKeyValues.Value;

        public IConsulClientOperatorEndpoint Operator => _endpointOperator.Value;

        public IConsulClientSessionsEndpoint Sessions => _endpointSessions.Value;

        public IConsulClientSnapshotsEndpoint Snapshots => _endpointSnapshots.Value;

        public IConsulClientStatusEndpoint Status => _endpointStatus.Value;

        public IConsulClientTransactionsEndpoint Transactions => _endpointTransactions.Value;
    }
}