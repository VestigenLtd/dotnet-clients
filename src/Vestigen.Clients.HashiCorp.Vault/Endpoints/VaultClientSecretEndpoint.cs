namespace Vestigen.Clients.HashiCorp.Vault.Endpoints
{
    public class VaultClientSecretEndpoint : IVaultClientSecretEndpoint
    {
        private IVaultClient _vaultClient;

        public VaultClientSecretEndpoint(IVaultClient vaultClient)
        {
            _vaultClient = vaultClient;
        }
    }
}