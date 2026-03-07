using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientFinancialRatiosTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Standard Subscription Endpoints

    [TestMethod]
    [DataRow("AAPL", Period.All, 0)]
    [DataRow("MSFT", Period.Year, 10)]
    [DataRow("GOOGL", Period.Quarter, 5)]
    public async Task GetLiquidityRatiosAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetLiquidityRatiosAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL", Period.All, 0)]
    [DataRow("TSLA", Period.Year, 15)]
    public async Task GetSolvencyRatiosAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetSolvencyRatiosAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("NVDA", Period.All, 0)]
    [DataRow("AMD", Period.Quarter, 10)]
    public async Task GetEfficiencyRatiosAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetEfficiencyRatiosAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("IBM", Period.All, 0)]
    [DataRow("ORCL", Period.Year, 5)]
    public async Task GetProfitabilityRatiosAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetProfitabilityRatiosAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("META", Period.All, 0)]
    [DataRow("NFLX", Period.Quarter, 20)]
    public async Task GetValuationRatiosAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetValuationRatiosAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
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
