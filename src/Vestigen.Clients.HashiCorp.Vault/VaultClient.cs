namespace Vestigen.Clients.HashiCorp.Vault
{
    public class VaultClient : HashiCorpClient<IVaultAuthenticator, IVaultSerializer, IVaultEndpoints>, IVaultClient
    {
        public VaultClient(IVaultAuthenticator authenticator, IVaultSerializer serializer) : base(authenticator, serializer)
        {
            Endpoints = new VaultEndpoints(this);
        }

        public sealed override IVaultEndpoints Endpoints { get; protected set; }
    }
}