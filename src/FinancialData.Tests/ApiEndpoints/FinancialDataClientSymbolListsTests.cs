using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientSymbolListsTests
{
    public TestContext TestContext { get; set; } = null!;

    #region GetStockSymbolsAsync Tests

    [TestMethod]
    [DataRow(0)]
    [DataRow(50)]
    [DataRow(100)]
    public async Task GetStockSymbolsAsync_WithValidResponse_ReturnsSymbols(int offset)
    {
        // Arrange
        var json = """
        [
            {"trading_symbol": "AAPL", "name": "Apple Inc."},
            {"trading_symbol": "MSFT", "name": "Microsoft Corporation"}
        ]
        """;
        using var mockHandler = new MockHttpMessageHandler { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create("test-api-key", httpClient);

        // Act
        var response = await client.GetStockSymbolsAsync(offset, TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.AreEqual(2, response.Data.Count);
    }

    #endregion

    #region GetInternationalStockSymbolsAsync Tests

    [TestMethod]
    [DataRow(0)]
    [DataRow(100)]
    public async Task GetInternationalStockSymbolsAsync_WithValidResponse_ReturnsSymbols(int offset)
    {
        // Arrange
        var json = """
        [
            {"trading_symbol": "SHEL.L", "name": "Shell PLC"},
            {"trading_symbol": "BP.L", "name": "BP PLC"}
        ]
        """;
        using var mockHandler = new MockHttpMessageHandler { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create("test-api-key", httpClient);

        // Act
        var response = await client.GetInternationalStockSymbolsAsync(offset, TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.AreEqual(2, response.Data.Count);
    }

    #endregion

    #region GetEtfSymbolsAsync Tests

    [TestMethod]
    [DataRow(0)]
    [DataRow(50)]
    public async Task GetEtfSymbolsAsync_WithValidResponse_ReturnsSymbols(int offset)
    {
        // Arrange
        var json = """
        [
            {"trading_symbol": "SPY", "name": "SPDR S&P 500 ETF Trust"},
            {"trading_symbol": "QQQ", "name": "Invesco QQQ Trust"}
        ]
        """;
        using var mockHandler = new MockHttpMessageHandler { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create("test-api-key", httpClient);

        // Act
        var response = await client.GetEtfSymbolsAsync(offset, TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.AreEqual(2, response.Data.Count);
    }

    #endregion

    #region GetCommoditySymbolsAsync Tests

    [TestMethod]
    [DataRow(0)]
    [DataRow(25)]
    public async Task GetCommoditySymbolsAsync_WithValidResponse_ReturnsSymbols(int offset)
    {
        // Arrange
        var json = """
        [
            {"trading_symbol": "GC", "name": "Gold Futures"},
            {"trading_symbol": "CL", "name": "Crude Oil Futures"}
        ]
        """;
        using var mockHandler = new MockHttpMessageHandler { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create("test-api-key", httpClient);

        // Act
        var response = await client.GetCommoditySymbolsAsync(offset, TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.AreEqual(2, response.Data.Count);
    }

    #endregion

    #region GetOtcSymbolsAsync Tests

    [TestMethod]
    [DataRow(0)]
    [DataRow(75)]
    public async Task GetOtcSymbolsAsync_WithValidResponse_ReturnsSymbols(int offset)
    {
        // Arrange
        var json = """
        [
            {"trading_symbol": "QTUM", "name": "OTC Stock 1"},
            {"trading_symbol": "BOTY", "name": "OTC Stock 2"}
        ]
        """;
        using var mockHandler = new MockHttpMessageHandler { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create("test-api-key", httpClient);

        // Act
        var response = await client.GetOtcSymbolsAsync(offset, TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.AreEqual(2, response.Data.Count);
    }

    #endregion
}
