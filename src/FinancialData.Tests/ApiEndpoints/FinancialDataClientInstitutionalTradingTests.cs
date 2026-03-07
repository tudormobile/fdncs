using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientInstitutionalTradingTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow(0)]
    [DataRow(50)]
    [DataRow(100)]
    public async Task GetInstitutionalInvestorsAsync_ReturnsPremiumSubscriptionNotImplemented(int offset)
    {
        // Act
        var response = await _client.GetInstitutionalInvestorsAsync(offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL", 0)]
    [DataRow("MSFT", 10)]
    [DataRow("GOOGL", 25)]
    public async Task GetInstitutionalHoldingsAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetInstitutionalHoldingsAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("0001067983", 0)]
    [DataRow("0000102909", 15)]
    public async Task GetInstitutionalPortfolioStatisticsAsync_ReturnsPremiumSubscriptionNotImplemented(string investorCik, int offset)
    {
        // Act
        var response = await _client.GetInstitutionalPortfolioStatisticsAsync(investorCik, offset);

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
