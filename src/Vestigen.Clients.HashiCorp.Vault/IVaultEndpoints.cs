using Vestigen.Clients.HashiCorp.Vault.Endpoints;

namespace Vestigen.Clients.HashiCorp.Vault
{
    public interface IVaultEndpoints : IHashiCorpEndpoints
    {
        IVaultClientSystemEndpoint System { get; }
        IVaultClientAuthenticationEndpoint Authentication { get; }
        IVaultClientSecretEndpoint Secrets { get; }
    }
}