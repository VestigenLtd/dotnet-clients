namespace Vestigen.Clients.HashiCorp.Consul
{
    public interface IConsulClient : IHashiCorpClient<IConsulAuthenticator, IConsulSerializer, IConsulEndpoints>
    {
    }
}