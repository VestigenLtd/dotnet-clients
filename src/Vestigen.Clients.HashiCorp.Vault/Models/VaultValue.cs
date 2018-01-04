using System.Collections.Generic;

namespace Vestigen.Clients.HashiCorp.Vault.Models
{
    public class VaultValue
    {
        public string Path { get; set; }

        public List<VaultValueItem> Values { get; set; }
    }
}
