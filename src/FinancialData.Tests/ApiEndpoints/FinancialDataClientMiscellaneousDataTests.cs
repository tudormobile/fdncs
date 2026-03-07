namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientMiscellaneousDataTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Standard Subscription Endpoints

    [TestMethod]
    [DataRow("AAPL", 0)]
    [DataRow("MSFT", 10)]
    [DataRow("GOOGL", 20)]
    public async Task GetEarningsReleasesAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetEarningsReleasesAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow(0)]
    [DataRow(25)]
    public async Task GetInitialPublicOfferingsAsync_ReturnsStandardSubscriptionNotImplemented(int offset)
    {
        // Act
        var response = await _client.GetInitialPublicOfferingsAsync(offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL", 0)]
    [DataRow("TSLA", 5)]
    public async Task GetStockSplitsAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetStockSplitsAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("MSFT", 0)]
    [DataRow("JNJ", 10)]
    public async Task GetDividendsAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetDividendsAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    #endregion

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow("GME", 0)]
    [DataRow("AMC", 10)]
    public async Task GetShortInterestAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetShortInterestAsync(identifier, offset);

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
