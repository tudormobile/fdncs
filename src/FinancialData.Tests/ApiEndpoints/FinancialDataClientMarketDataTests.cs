namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientMarketDataTests
{
    private IFinancialDataClient _client = null!;

    public TestContext TestContext { get; set; } // MSTest will set this property


    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    [TestMethod]
    public async Task FinancialDataClient_GetStockPricesAsync_ReturnsApiResult()
    {
        // Arrange
        var json = @"[
  {
    ""trading_symbol"": ""MSFT"",
    ""date"": ""2024-12-04"",
    ""open"": 433.03,
    ""high"": 439.67,
    ""low"": 432.63,
    ""close"": 437.42,
    ""volume"": 26009430.0
  }
]";
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var identifier = "MSFT";

        // Act
        var response = await client.GetStockPricesAsync(identifier, cancellationToken: TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.HasCount(1, response.Data);
        Assert.AreEqual(identifier, response.Data[0].TradingSymbol);
        Assert.AreEqual(new DateOnly(2024, 12, 4), response.Data[0].Date);
        Assert.AreEqual(433.03m, response.Data[0].Open);
        Assert.AreEqual(439.67m, response.Data[0].High);
        Assert.AreEqual(432.63m, response.Data[0].Low);
        Assert.AreEqual(437.42m, response.Data[0].Close);
        Assert.AreEqual(26009430.0m, response.Data[0].Volume);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetCommodityPricesAsync_ReturnsApiResult()
    {
        // Arrange
        var json = @"[
  {
    ""trading_symbol"": ""ZC"",
    ""date"": ""2024-12-03"",
    ""open"": 425.0,
    ""high"": 428.0,
    ""low"": 422.75,
    ""close"": 423.25,
    ""volume"": 4078.0
  }]";
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var identifier = "ZC";

        // Act
        var response = await client.GetCommodityPricesAsync(identifier, cancellationToken: TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.HasCount(1, response.Data);
        Assert.AreEqual(identifier, response.Data[0].TradingSymbol);
        Assert.AreEqual(4078m, response.Data[0].Volume);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetOtcPricesAsync_ReturnsApiResult()
    {
        // Arrange
        var json = @"[
  {
    ""trading_symbol"": ""AABB"",
    ""date"": ""2024-12-04"",
    ""open"": 0.0271,
    ""high"": 0.0271,
    ""low"": 0.024,
    ""close"": 0.0248,
    ""volume"": 6592169.0
  },
  {
    ""trading_symbol"": ""AABB"",
    ""date"": ""2024-12-03"",
    ""open"": 0.0235,
    ""high"": 0.029,
    ""low"": 0.0235,
    ""close"": 0.0265,
    ""volume"": 6828867.0
  }
]";
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var identifier = "AABB";

        // Act
        var response = await client.GetOtcPricesAsync(identifier, cancellationToken: TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.HasCount(2, response.Data);
        Assert.AreEqual(identifier, response.Data[0].TradingSymbol);
        Assert.AreEqual(identifier, response.Data[1].TradingSymbol);
        Assert.AreEqual(0.0271m, response.Data[0].Open);
        Assert.AreEqual(0.0235m, response.Data[1].Open);
    }
    [TestMethod]
    public async Task FinancialDataClient_GetOtcVolumesAsync_ReturnsApiResult()
    {
        // Arrange
        var json = @"[
  {
    ""trading_symbol"": ""AABB"",
    ""title_of_security"": ""Asia Broadband Inc Common Stock"",
    ""month_start_date"": ""2024-10-01"",
    ""monthly_volume"": 140366022,
    ""previous_monthly_volume"": 263720143,
    ""volume_year_to_date"": 2237440816
  },
  {
    ""trading_symbol"": ""AABB"",
    ""title_of_security"": ""Asia Broadband Inc Common Stock"",
    ""month_start_date"": ""2024-09-01"",
    ""monthly_volume"": 263720143,
    ""previous_monthly_volume"": 692420804,
    ""volume_year_to_date"": 2097074794
  }
]";
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var identifier = "AABB";

        // Act
        var response = await client.GetOtcVolumesAsync(identifier, cancellationToken: TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.HasCount(2, response.Data);
        Assert.AreEqual(identifier, response.Data[0].TradingSymbol);
        Assert.AreEqual(identifier, response.Data[1].TradingSymbol);
    }

    #region Premium Subscription Endpoints

    [TestMethod]
    public async Task GetStockQuotesAsync_ReturnsPremiumSubscriptionNotImplemented()
    {
        // Arrange
        var identifiers = new[] { "MSFT", "AAPL", "GOOGL" };

        // Act
        var response = await _client.GetStockQuotesAsync(identifiers);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("MSFT", 0)]
    [DataRow("AAPL", 10)]
    public async Task GetLatestPricesAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetLatestPricesAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    #endregion

    #region Standard Subscription Endpoints

    [TestMethod]
    [DataRow("SHEL.L")]
    [DataRow("BP.L")]
    public async Task GetInternationalStockPricesAsync_ReturnsStandardSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetInternationalStockPricesAsync(identifier);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    public async Task GetMinutePricesAsync_ReturnsStandardSubscriptionNotImplemented()
    {
        // Arrange
        var identifier = "MSFT";
        var date = new DateTimeOffset(2024, 1, 15, 0, 0, 0, TimeSpan.Zero);
        var offset = 0;

        // Act
        var response = await _client.GetMinutePricesAsync(identifier, date, offset);

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
