using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientEtfDataTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow("SPY", 0)]
    [DataRow("QQQ", 10)]
    [DataRow("IWM", 20)]
    public async Task GetEtfQuotesAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetEtfQuotesAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("SPY", 0)]
    [DataRow("VOO", 50)]
    public async Task GetEtfPricesAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetEtfPricesAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(100)]
    public async Task GetEtfHoldingsAsync_ReturnsPremiumSubscriptionNotImplemented(int offset)
    {
        // Act
        var response = await _client.GetEtfHoldingsAsync(offset);

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
