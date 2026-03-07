using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientCryptoCurrenciesTests
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
    [DataRow(10)]
    [DataRow(100)]
    public async Task GetCryptoSymbolsAsync_ReturnsPremiumSubscriptionNotImplemented(int offset)
    {
        // Act
        var response = await _client.GetCryptoSymbolsAsync(offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("BTC")]
    [DataRow("ETH")]
    [DataRow("USDT")]
    public async Task GetCryptoInformationAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetCryptoInformationAsync(identifier);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    public async Task GetCryptoQuotesAsync_ReturnsPremiumSubscriptionNotImplemented()
    {
        // Arrange
        var identifiers = new[] { "BTC", "ETH", "USDT" };

        // Act
        var response = await _client.GetCryptoQuotesAsync(identifiers);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("BTC", 0)]
    [DataRow("ETH", 50)]
    public async Task GetCryptoPricesAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetCryptoPricesAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    public async Task GetCryptoMinutePricesAsync_ReturnsPremiumSubscriptionNotImplemented()
    {
        // Arrange
        var identifier = "BTC";
        var date = new DateOnly(2024, 1, 15);
        var offset = 0;

        // Act
        var response = await _client.GetCryptoMinutePricesAsync(identifier, date, offset);

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
