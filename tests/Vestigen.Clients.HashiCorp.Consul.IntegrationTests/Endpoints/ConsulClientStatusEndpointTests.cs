using System.Collections.Generic;
using System.Threading.Tasks;
using Vestigen.Clients.HashiCorp.Consul.Endpoints;
using Xunit;
using Xunit.Abstractions;

namespace Vestigen.Clients.HashiCorp.Consul.IntegrationTests.Endpoints
{
    public class ConsulClientStatusEndpointTests
    {
        private ITestOutputHelper _outputHelper;
        private readonly ConsulClient _client;

        public ConsulClientStatusEndpointTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;

            _client = new ConsulClient(new ConsulAuthenticator("http://127.0.0.1:8500"), new ConsulSerializer() );
        }

        [Fact]
        public async Task GetLeader_WithNoParameters_ReturnsValidStatusLeader()
        {
            // Arrange
            var sut = new ConsulClientStatusEndpoint(_client);

            // Act
            var capture = await sut.GetLeader();

            // Assert
            Assert.NotNull(capture);
            Assert.IsType<string>(capture);
        }

        [Fact]
        public async Task GetPeers_WithNoParameters_ReturnsValidStatusLeader()
        {
            // Arrange
            var sut = new ConsulClientStatusEndpoint(_client);

            // Act
            var capture = await sut.GetPeers();

            // Assert
            Assert.NotNull(capture);
            Assert.IsType<List<string>>(capture);
        }
    }
}
