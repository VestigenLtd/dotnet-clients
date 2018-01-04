namespace Vestigen.Clients.HashiCorp.Vault
{
    public interface IVaultClient : IHashiCorpClient<IVaultAuthenticator, IVaultSerializer, IVaultEndpoints>
    {
    }
}