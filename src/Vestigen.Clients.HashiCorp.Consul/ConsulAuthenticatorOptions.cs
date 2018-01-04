using Microsoft.Extensions.Options;

namespace Vestigen.Clients.HashiCorp.Consul
{
    public class ConsulAuthenticatorOptions : IOptions<ConsulAuthenticatorOptions>
    {
        public static ConsulAuthenticatorOptions Default = new ConsulAuthenticatorOptions();

        public string Address { get; set; } = "https://localhost:8500";
        public string Token { get; set; }

        ConsulAuthenticatorOptions IOptions<ConsulAuthenticatorOptions>.Value => this;
    }
}