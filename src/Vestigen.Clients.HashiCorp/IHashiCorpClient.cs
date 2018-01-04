using System.Collections.Specialized;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Vestigen.Clients.HashiCorp
{
    public interface IHashiCorpClient<out TAuthenticator, out TSerializer, out TEndpoints> 
        where TAuthenticator : IHashiCorpAuthenticator
        where TSerializer : IHashiCorpSerializer
        where TEndpoints : IHashiCorpEndpoints
    {
        TAuthenticator Authenticator { get; }

        TSerializer Serializer { get; }

        TEndpoints Endpoints { get; }

        Task<string> SendRequest(HttpMethod method, string address, NameValueCollection headers = null, string body = null, CancellationToken? ct = null);
    }
}