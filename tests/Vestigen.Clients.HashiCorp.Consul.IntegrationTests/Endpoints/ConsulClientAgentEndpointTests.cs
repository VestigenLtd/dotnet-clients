using System.Threading.Tasks;
using Vestigen.Clients.HashiCorp.Consul.Endpoints;
using Xunit;
using Xunit.Abstractions;

namespace Vestigen.Clients.HashiCorp.Consul.IntegrationTests.Endpoints
{
    public class ConsulClientAgentEndpointTests
    {
        private ITestOutputHelper _outputHelper;
        private readonly ConsulClient _client;

        public ConsulClientAgentEndpointTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;

            _client = new ConsulClient(new ConsulAuthenticator("http://127.0.0.1:8500"), new ConsulSerializer() );
        }

        [Fact]
        public async Task GetMembers_WithNoParameters_ReturnsListOfMembers()
        {
            // Arrange
            var sut = new ConsulClientAgentEndpoint(_client);

            // Act
            var capture = await sut.GetMembers();

            // Assert
            Assert.NotNull(capture);
        }

        [Fact]
        public async Task GetSelf_WithNoParameters_ReturnsSelf()
        {
            // Arrange
            var sut = new ConsulClientAgentEndpoint(_client);

            // Act
            var capture = await sut.GetSelf();

            // Assert
            Assert.NotNull(capture);
        }
    }
}
