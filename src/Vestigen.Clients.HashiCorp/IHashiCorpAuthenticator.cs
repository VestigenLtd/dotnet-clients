using System;

namespace Vestigen.Clients.HashiCorp
{
    public interface IHashiCorpAuthenticator : IDisposable
    {
        string Address { get; }

        string Token { get; }

        string TokenHeader { get; }
    }
}