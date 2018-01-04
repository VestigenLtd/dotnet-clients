using System;
using System.Threading.Tasks;
using Vestigen.Clients.HashiCorp.Vault.Endpoints;
using Xunit;
using Xunit.Abstractions;

namespace Vestigen.Clients.HashiCorp.Vault.IntegrationTests.Endpoints
{
    public class VaultClientSystemBackendTests
    {
        private ITestOutputHelper _outputHelper;
        private readonly VaultClient _client;

        public VaultClientSystemBackendTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;

            _client = new VaultClient(new VaultAuthenticator("http://127.0.0.1:8200"), new VaultSerializer() );
        }

        [Fact]
        public async Task GetSealStatus_AssumingUnsealedWorkingVaultWithNoParameters_ReturnsValidSealStatus()
        {
            // Arrange
            var sut = new VaultClientSystemEndpoint(_client);

            // Act
            var capture = await sut.GetSealStatus();

            // Assert
            Assert.NotNull(capture);
            Assert.NotNull(capture.Version);
            Assert.NotNull(capture.ClusterName);
            Assert.True(capture.KeyShares == 1);
            Assert.True(capture.KeyThreshold == 1);
            Assert.False(capture.IsSealed);
            Assert.Equal(0, capture.UnsealProgress);
            Assert.NotEqual(Guid.Empty, capture.ClusterId);
        }

        [Fact]
        public async Task GetHealth_AssumingUnsealedWorkingVaultWithNoParameters_ReturnsValidHealth()
        {
            // Arrange
            var start = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds - 5;
            var end = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds + 5;
            var sut = new VaultClientSystemEndpoint(_client);

            // Act
            var capture = await sut.GetHealth();

            // Assert
            Assert.NotNull(capture);
            Assert.NotNull(capture.Version);
            Assert.NotNull(capture.ClusterName);
            Assert.InRange(capture.ServerTimestampUtc, start, end);
            Assert.True(capture.ServerTimestampUtc <= end);
            Assert.True(capture.IsInitialized);
            Assert.False(capture.IsSealed);
            Assert.False(capture.IsStandby);
            Assert.NotEqual(Guid.Empty, capture.ClusterId);
        }

        [Fact]
        public async Task GetLeader_AssumingUnsealedWorkingVaultWithNoParameters_ReturnsValidLeader()
        {
            // Arrange
            var sut = new VaultClientSystemEndpoint(_client);

            // Act
            var capture = await sut.GetLeader();

            // Assert
            Assert.NotNull(capture);
            Assert.NotNull(capture.LeaderAddress);
            Assert.NotNull(capture.LeaderClusterAddress);         
            Assert.False(capture.IsHighlyAvailable);
            Assert.False(capture.IsLeader);
        }
    }
}
