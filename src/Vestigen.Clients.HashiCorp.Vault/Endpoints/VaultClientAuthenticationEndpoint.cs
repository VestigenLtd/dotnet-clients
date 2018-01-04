namespace Vestigen.Clients.HashiCorp.Vault.Endpoints
{
    public class VaultClientAuthenticationEndpoint : IVaultClientAuthenticationEndpoint
    {
        private IVaultClient _vaultClient;

        public VaultClientAuthenticationEndpoint(IVaultClient vaultClient)
        {
            _vaultClient = vaultClient;
        }
    }
}