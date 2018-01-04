namespace Vestigen.Clients.HashiCorp
{
    public interface IHashiCorpSerializer
    {
        string Serialize<T>(T content);

        T Deserialize<T>(string content);
    }
}