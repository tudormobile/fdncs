namespace FinancialData.Tests;

using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using Tudormobile.FinancialData;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

[TestClass]
public class FinancialDataApiTests
{
    [TestMethod]
    public void FinancialDataApi_RootUri_HasValue()
    {
        // Arrange & Act
        var rootUri = FinancialDataApi.RootUri;
        // Assert
        Assert.IsNotNull(rootUri);
        Assert.StartsWith("https://financialdata.net/api", rootUri);
        Assert.EndsWith("/", rootUri);
    }

    [TestMethod]
    public void FinancialDataApi_ApiVersion_ReturnsVersion()
    {
        // Arrange & Act
        var version = FinancialDataApi.ApiVersion;
        // Assert
        Assert.Contains("v1", version);
    }

    [TestMethod]
    public void FinancialDataApi_CreateClient_ReturnsClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var apiKey = "some key";
        // Act
        var client = FinancialDataApi.CreateClient(apiKey, httpClient);
        //Assert
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.AreEqual(httpClient, ((FinancialDataClient)client).HttpClient);

    }

    #region Extension Methods

    [TestMethod]
    public void FinancialDataApi_CreateClient_WithSerializer_ReturnsClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var apiKey = "some key";
        var serializer = new MockSerializer();
        // Act
        var client = FinancialDataApi.CreateClient(apiKey, httpClient, serializer);
        //Assert
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.AreEqual(httpClient, ((FinancialDataClient)client).HttpClient);
        Assert.AreEqual(serializer, ((FinancialDataClient)client).Serializer);
    }

    [TestMethod]
    public void FinancialDataApi_CreateClient_WithLogger_ReturnsClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var apiKey = "some key";
        var logger = new MockLogger();
        // Act
        var client = FinancialDataApi.CreateClient(apiKey, httpClient, logger);
        //Assert
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.AreEqual(httpClient, ((FinancialDataClient)client).HttpClient);
        Assert.AreEqual(logger, ((FinancialDataClient)client).Logger);

    }

    [TestMethod]
    public void FinancialDataApi_CreateClient_WithLoggerAndSerializer_ReturnsClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var apiKey = "some key";
        var logger = new MockLogger();
        var serializer = new MockSerializer();
        // Act
        var client = FinancialDataApi.CreateClient(apiKey, httpClient, serializer, logger);
        //Assert
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.AreEqual(httpClient, ((FinancialDataClient)client).HttpClient);
        Assert.AreEqual(logger, ((FinancialDataClient)client).Logger);
        Assert.AreEqual(serializer, ((FinancialDataClient)client).Serializer);
    }

    [TestMethod]
    public void FinancialDataApi_GetClientBuilder_ReturnsClientBuilder()
    {
        // Arrange & Act
        var client = FinancialDataApi.GetClientBuilder();
        //Assert
        Assert.IsInstanceOfType<IFinancialDataClientBuilder>(client);
    }


    #endregion

    [ExcludeFromCodeCoverage]
    class MockLogger : Microsoft.Extensions.Logging.ILogger
    {
#pragma warning disable CS8633 // Nullability in constraints for type parameter doesn't match the constraints for type parameter in implicitly implemented interface method'.
        public IDisposable BeginScope<TState>(TState state) => null!;
#pragma warning restore CS8633 // Nullability in constraints for type parameter doesn't match the constraints for type parameter in implicitly implemented interface method'.
        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel) => true;
        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            // No-op
        }
    }
    [ExcludeFromCodeCoverage]
    class MockSerializer : IFinancialDataSerializer
    {
        public string Serialize(BalanceSheet balanceSheet)
            => throw new NotImplementedException();

        public string Serialize(StockPrice stockPrice)
            => throw new NotImplementedException();

        public T Deserialize<T>(JsonDocument doc)
            => throw new NotImplementedException();
    }
}
