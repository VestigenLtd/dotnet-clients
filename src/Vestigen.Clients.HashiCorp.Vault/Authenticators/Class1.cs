namespace Vestigen.Clients.HashiCorp.Vault.Authenticators
{
    public class GitHubVaultAuthenticator : HashiCorpClientHandler, IVaultAuthenticator
    {
        private GitHubVaultAuthenticatorOptions _options;

        public GitHubVaultAuthenticator(string address, GitHubVaultAuthenticatorOptions options) : base(address)
        {
            Address = address;




        }

        public string Address { get; }
        public string Token { get; }
        public string TokenHeader { get; }

        public class GitHubVaultAuthenticatorOptions
        {
            [JsonProperty("token")]
            public string Token { get; set; }
        }
    }

    public class GitHubVaultAuthenticatorOptions
    {
        public string Token { get; set; }
    }
}
