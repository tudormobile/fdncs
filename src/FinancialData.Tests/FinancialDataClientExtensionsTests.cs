using Microsoft.Extensions.Logging.Abstractions;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests;

[TestClass]
public class FinancialDataClientExtensionsTests
{
    [TestMethod]
    public void Create_WithAllParameters_ReturnsInitializedClient()
    {
        // Arrange
        var apiKey = "test-api-key";
        var httpClient = new HttpClient();
        var logger = NullLogger.Instance;
        var serializer = new TestFinancialDataSerializer();

        // Act
        var client = IFinancialDataClient.Create(apiKey, httpClient, serializer, logger);

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.IsInstanceOfType<FinancialDataClient>(client);
    }

    [TestMethod]
    public void Create_WithoutSerializer_ReturnsInitializedClient()
    {
        // Arrange
        var apiKey = "test-api-key";
        var httpClient = new HttpClient();
        var logger = NullLogger.Instance;

        // Act
        var client = IFinancialDataClient.Create(apiKey, httpClient, logger);

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.IsInstanceOfType<FinancialDataClient>(client);
    }

#pragma warning disable IDE0060 // Remove unused parameter
    [ExcludeFromCodeCoverage]
    private class TestFinancialDataSerializer : IFinancialDataSerializer
    {
        public static T? Deserialize<T>(string json) => default;
        public T Deserialize<T>(JsonDocument doc) => throw new NotImplementedException();
        public static string Serialize<T>(T obj) => string.Empty;
        public string Serialize(BalanceSheet balanceSheet) => throw new NotImplementedException();
        public string Serialize(StockPrice stockPrice) => throw new NotImplementedException();
    }
#pragma warning restore IDE0060 // Remove unused parameter
}
