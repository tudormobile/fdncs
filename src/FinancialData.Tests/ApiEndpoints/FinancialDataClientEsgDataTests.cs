using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientEsgDataTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow("AAPL", 0)]
    [DataRow("MSFT", 10)]
    [DataRow("GOOGL", 50)]
    public async Task GetEsgScoresAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetEsgScoresAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("TSLA", 0)]
    [DataRow("NVDA", 25)]
    public async Task GetEsgRatingsAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetEsgRatingsAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("Technology", 0)]
    [DataRow("Healthcare", 10)]
    public async Task GetIndustryEsgScoresAsync_ReturnsPremiumSubscriptionNotImplemented(string industry, int offset)
    {
        // Act
        var response = await _client.GetIndustryEsgScoresAsync(industry, offset);

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
