using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientMutualFundsTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow("VFIAX", 0)]
    [DataRow("FXAIX", 10)]
    [DataRow("SWPPX", 25)]
    public async Task GetMutualFundStatisticsAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetMutualFundStatisticsAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("VFIAX", 0)]
    [DataRow("VTSAX", 15)]
    public async Task GetMutualFundHoldingsAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetMutualFundHoldingsAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(50)]
    [DataRow(100)]
    public async Task GetMutualFundSymbolsAsync_ReturnsPremiumSubscriptionNotImplemented(int offset)
    {
        // Act
        var response = await _client.GetMutualFundSymbolsAsync(offset);

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
