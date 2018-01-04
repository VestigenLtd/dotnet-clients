using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vestigen.Clients.HashiCorp.Consul.Endpoints;
using Vestigen.Clients.HashiCorp.Consul.Models;
using Xunit;
using Xunit.Abstractions;

namespace Vestigen.Clients.HashiCorp.Consul.IntegrationTests.Endpoints
{
    public class ConsulClientCoordinatesEndpointTests
    {
        private ITestOutputHelper _outputHelper;
        private readonly ConsulClient _client;

        public ConsulClientCoordinatesEndpointTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;

            _client = new ConsulClient(new ConsulAuthenticator("http://127.0.0.1:8500"), new ConsulSerializer() );
        }

        [Fact]
        public async Task GetLeader_WithNoParameters_ReturnsValidStatusLeader()
        {
            // Arrange
            var sut = new ConsulClientCoordinatesEndpoint(_client);

            // Act
            var capture = await sut.GetDatacenters();

            // Assert
            Assert.NotNull(capture);
            Assert.NotEmpty(capture);

            var datacenter = capture[0];
            Assert.NotNull(datacenter.DatacenterName);
            Assert.NotNull(datacenter.AreaId);
            Assert.NotNull(datacenter.Coordinates);
            Assert.NotEmpty(datacenter.Coordinates);

            var coordinates = datacenter.Coordinates [0];
            Assert.NotNull(coordinates.NodeName);
            Assert.NotNull(coordinates.Segment);
            Assert.NotNull(coordinates.Coordinate);
            Assert.NotNull(coordinates.Coordinate.Vector);
        }

        [Fact]
        public async Task GetPeers_WithNullDatacenter_ReturnsListOfDatacenters()
        {
            // Arrange
            var sut = new ConsulClientCoordinatesEndpoint(_client);

            // Act
            var capture = await sut.GetNodes(null);

            // Assert
            Assert.NotNull(capture);
            Assert.NotEmpty(capture);

            var node = capture[0];
            Assert.NotNull(node.NodeName);
            Assert.NotNull(node.Segment);
            Assert.NotNull(node.Coordinate);
            Assert.NotNull(node.Coordinate.Vector);
        }

        [Fact]
        public async Task GetPeers_WithValidDatacenter_ReturnsListOfNodes()
        {
            // Arrange
            var sut = new ConsulClientCoordinatesEndpoint(_client);

            // Act
            var capture = await sut.GetNodes("dc1");

            // Assert
            Assert.NotNull(capture);
            Assert.NotEmpty(capture);

            var node = capture[0];
            Assert.NotNull(node.NodeName);
            Assert.NotNull(node.Segment);
            Assert.NotNull(node.Coordinate);
            Assert.NotNull(node.Coordinate.Vector);
        }

        [Fact]
        public async Task GetPeers_WithInvalidDatacenter_ThrowsClientException()
        {
            // Arrange
            var sut = new ConsulClientCoordinatesEndpoint(_client);

            // Act
            var capture = new Func<Task<List<CoordinateDatacenterNode>>>(() => sut.GetNodes("dc2"));

            // Assert
            await Assert.ThrowsAsync<HashiCorpClientRequestException>(capture);
        }
    }
}
