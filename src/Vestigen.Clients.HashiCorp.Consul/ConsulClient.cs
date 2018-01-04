namespace Vestigen.Clients.HashiCorp.Consul
{
    public class ConsulClient : HashiCorpClient<IConsulAuthenticator, IConsulSerializer, IConsulEndpoints>, IConsulClient
    {
        public ConsulClient(IConsulAuthenticator authenticator, IConsulSerializer serializer) : base(authenticator, serializer)
        {
            Endpoints = new ConsulEndpoints(this);
        }

        public sealed override IConsulEndpoints Endpoints { get; protected set; }
    }
}