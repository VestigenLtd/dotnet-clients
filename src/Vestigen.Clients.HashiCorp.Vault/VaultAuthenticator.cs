using System.Threading;
using Microsoft.Extensions.Options;

namespace Vestigen.Clients.HashiCorp.Vault
{
    public class VaultAuthenticator :  IVaultAuthenticator
    {
        private readonly IOptions<VaultAuthenticatorOptions> _options;
        private readonly CancellationTokenSource _cancellation;

        public VaultAuthenticator(string address, string token = null) 
            : this(new VaultAuthenticatorOptions { Address = address, Token = token })
        {
        }

        public VaultAuthenticator(IOptions<VaultAuthenticatorOptions> options)
        {
            _options = options;
            _cancellation = new CancellationTokenSource();

            if (_options.Value.Token != null)
            {
                // TODO: Start a long running task here that refreshes tokens automatically
                // using the cancellation source to spin it down correctly.
            }
        }

        public string Address => _options.Value.Address;

        public string Token => _options.Value.Token;

        public string TokenHeader => "X-Vault-Token";

        public void Dispose()
        {
            _cancellation.Cancel();
        }
    }
}