using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientBasicInformationTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Standard Subscription Endpoints

    [TestMethod]
    [DataRow("AAPL")]
    [DataRow("MSFT")]
    [DataRow("GOOGL")]
    public async Task GetCompanyInformationAsync_ReturnsStandardSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetCompanyInformationAsync(identifier);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL")]
    [DataRow("TSLA")]
    public async Task GetKeyMetricsAsync_ReturnsStandardSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetKeyMetricsAsync(identifier);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL", 0)]
    [DataRow("MSFT", 10)]
    [DataRow("GOOGL", 100)]
    public async Task GetMarketCapAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, int offset)
    {
        // Act
        var response = await _client.GetMarketCapAsync(identifier, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL")]
    [DataRow("IBM")]
    public async Task GetEmployeeCountAsync_ReturnsStandardSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetEmployeeCountAsync(identifier);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("NVDA")]
    [DataRow("AMD")]
    public async Task GetSecuritiesInformationAsync_ReturnsStandardSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetSecuritiesInformationAsync(identifier);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    #endregion

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow("AAPL")]
    [DataRow("MSFT")]
    public async Task GetInternationalCompanyInformationAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetInternationalCompanyInformationAsync(identifier);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("AAPL")]
    [DataRow("TSLA")]
    public async Task GetExecutiveCompensationAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier)
    {
        // Act
        var response = await _client.GetExecutiveCompensationAsync(identifier);

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
