using System;
using System.Threading;
using Vestigen.Clients.HashiCorp.Vault.Endpoints;

namespace Vestigen.Clients.HashiCorp.Vault
{
    public class VaultEndpoints : IVaultEndpoints
    {
        private readonly Lazy<IVaultClientSystemEndpoint> _endpointSystem;
        private readonly Lazy<IVaultClientAuthenticationEndpoint> _endpointAuthentication;
        private readonly Lazy<IVaultClientSecretEndpoint> _endpointSecrets;

        public VaultEndpoints(IVaultClient client)
        {
            _endpointSystem = new Lazy<IVaultClientSystemEndpoint>(() => new VaultClientSystemEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointAuthentication = new Lazy<IVaultClientAuthenticationEndpoint>(() => new VaultClientAuthenticationEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
            _endpointSecrets = new Lazy<IVaultClientSecretEndpoint>(() => new VaultClientSecretEndpoint(client), LazyThreadSafetyMode.PublicationOnly);
        }

        public IVaultClientSystemEndpoint System => _endpointSystem.Value;
        public IVaultClientAuthenticationEndpoint Authentication => _endpointAuthentication.Value;
        public IVaultClientSecretEndpoint Secrets => _endpointSecrets.Value;
    }
}