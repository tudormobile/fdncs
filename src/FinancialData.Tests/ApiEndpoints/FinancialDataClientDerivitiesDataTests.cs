using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientDerivitiesDataTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow("AAPL", null)]
    [DataRow("MSFT", "2024-01-15")]
    public async Task GetOptionChainAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, string? expirationDateStr)
    {
        // Arrange
        DateOnly? expirationDate = expirationDateStr != null ? DateOnly.Parse(expirationDateStr) : null;

        // Act
        var response = await _client.GetOptionChainAsync(identifier, expirationDate);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL250117C00150000", 0)]
    [DataRow("MSFT250117P00200000", 10)]
    public async Task GetOptionPricesAsync_ReturnsPremiumSubscriptionNotImplemented(string contractName, int offset)
    {
        // Act
        var response = await _client.GetOptionPricesAsync(contractName, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL250117C00150000", 0)]
    [DataRow("TSLA250117C00250000", 20)]
    public async Task GetOptionGreeksAsync_ReturnsPremiumSubscriptionNotImplemented(string contractName, int offset)
    {
        // Act
        var response = await _client.GetOptionGreeksAsync(contractName, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(50)]
    public async Task GetFuturesSymbolsAsync_ReturnsPremiumSubscriptionNotImplemented(int offset)
    {
        // Act
        var response = await _client.GetFuturesSymbolsAsync(offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("ES", 0)]
    [DataRow("NQ", 10)]
    public async Task GetFuturesPricesAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetFuturesPricesAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    #endregion

    #region Helper Methods

    private static IFinancialDataClient CreateTestClient()
    {
        using var mockHandler = new MockHttpMessageHandler();
        var httpClient = new HttpClient(mockHandler);
        return IFinancialDataClient.Create("test-api-key", httpClient);
    }

    #endregion
}
