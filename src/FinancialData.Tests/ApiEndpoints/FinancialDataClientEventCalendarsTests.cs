using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientEventCalendarsTests
{
    private IFinancialDataClient _client = null!;

    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    #region Standard Subscription Endpoints

    [TestMethod]
    [DataRow(null, 0)]
    [DataRow("2024-01-15", 0)]
    [DataRow("2024-06-30", 10)]
    public async Task GetEarningsCalendarAsync_ReturnsStandardSubscriptionNotImplemented(string? dateStr, int offset)
    {
        // Arrange
        DateOnly? date = dateStr != null ? DateOnly.Parse(dateStr) : null;

        // Act
        var response = await _client.GetEarningsCalendarAsync(date, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow(null, 0)]
    [DataRow("2024-03-01", 5)]
    public async Task GetIpoCalendarAsync_ReturnsStandardSubscriptionNotImplemented(string? dateStr, int offset)
    {
        // Arrange
        DateOnly? date = dateStr != null ? DateOnly.Parse(dateStr) : null;

        // Act
        var response = await _client.GetIpoCalendarAsync(date, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow(null, 0)]
    [DataRow("2024-02-20", 15)]
    public async Task GetSplitsCalendarAsync_ReturnsStandardSubscriptionNotImplemented(string? dateStr, int offset)
    {
        // Arrange
        DateOnly? date = dateStr != null ? DateOnly.Parse(dateStr) : null;

        // Act
        var response = await _client.GetSplitsCalendarAsync(date, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow(null, 0)]
    [DataRow("2024-04-10", 20)]
    public async Task GetDividendsCalendarAsync_ReturnsStandardSubscriptionNotImplemented(string? dateStr, int offset)
    {
        // Arrange
        DateOnly? date = dateStr != null ? DateOnly.Parse(dateStr) : null;

        // Act
        var response = await _client.GetDividendsCalendarAsync(date, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    #endregion

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow(null, 0)]
    [DataRow("US", 0)]
    [DataRow("UK", 10)]
    public async Task GetEconomicCalendarAsync_ReturnsPremiumSubscriptionNotImplemented(string? country, int offset)
    {
        // Act
        var response = await _client.GetEconomicCalendarAsync(country, offset);

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
