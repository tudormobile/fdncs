using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientMarketIndexesTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Standard Subscription Endpoints

    [TestMethod]
    public async Task GetIndexSymbolsAsync_ReturnsStandardSubscriptionNotImplemented()
    {
        // Act
        var response = await _client.GetIndexSymbolsAsync();

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("^GSPC", 0)]
    [DataRow("^DJI", 10)]
    [DataRow("^IXIC", 20)]
    public async Task GetIndexPricesAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetIndexPricesAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("^GSPC", 0)]
    [DataRow("^DJI", 50)]
    public async Task GetIndexConstituentsAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetIndexConstituentsAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    #endregion

    #region Premium Subscription Endpoints

    [TestMethod]
    public async Task GetIndexQuotesAsync_ReturnsPremiumSubscriptionNotImplemented()
    {
        // Arrange
        var identifiers = new[] { "^GSPC", "^DJI", "^IXIC" };

        // Act
        var response = await _client.GetIndexQuotesAsync(identifiers);

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
