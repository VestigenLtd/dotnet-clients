using System.Collections.Specialized;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Vestigen.Clients.HashiCorp
{
    public abstract class HashiCorpClient<TAuthenticator, TSerializer, TEndpoints> : 
        HashiCorpClientHandler, 
        IHashiCorpClient<TAuthenticator, TSerializer, TEndpoints>
            where TAuthenticator : IHashiCorpAuthenticator
            where TSerializer : IHashiCorpSerializer
            where TEndpoints : IHashiCorpEndpoints
    {
        protected HashiCorpClient(TAuthenticator authenticator, TSerializer serializer) : base(authenticator.Address)
        {
            Authenticator = authenticator;
            Serializer = serializer;
        }

        public TAuthenticator Authenticator { get; }

        public TSerializer Serializer { get; }

        public abstract TEndpoints Endpoints { get; protected set; }   

        public override async Task<string> SendRequest(HttpMethod method, string address, NameValueCollection headers = null, string body = null, CancellationToken? ct = null)
        {
            if (headers == null)
            {
                headers = new NameValueCollection();
            }

            if (Authenticator.Token != null)
            {
                headers.Add(Authenticator.TokenHeader, Authenticator.Token);
            }

            return await base.SendRequest(method, address, headers, body, ct);
        }
    }
}