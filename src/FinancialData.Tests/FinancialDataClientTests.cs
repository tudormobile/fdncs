using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests;

[TestClass]
public class FinancialDataClientTests
{
    public TestContext TestContext { get; set; } // MSTest will set this property

    [TestMethod]
    public void GetBuilder_ReturnsInterface()
    {
        // Arrange & Act
        var builder = IFinancialDataClient.GetBuilder();

        // Assert
        Assert.IsNotNull(builder);
        Assert.IsInstanceOfType<IFinancialDataClientBuilder>(builder);
        Assert.IsInstanceOfType<FinancialDataClientBuilder>(builder);
    }

    [TestMethod]
    public void FinancialDataClient_Create_WithArguments_CreatesClient()
    {
        // Arrange
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler();
        using var httpClient = new HttpClient(mockHandler);
        var serializer = new FinancialDataSerializer();
        var logger = new MockLogger();

        // Act
        var client = IFinancialDataClient.Create(apiKey, httpClient, serializer, logger);

        // Assert
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.AreEqual(logger, ((FinancialDataClient)client).Logger);
        Assert.AreEqual(serializer, ((FinancialDataClient)client).Serializer);
        Assert.AreEqual(httpClient, ((FinancialDataClient)client).HttpClient);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetApiResultAsync_ReturnsApiResult()
    {
        // Arrange
        var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""registrant_name"": ""Apple Inc."",
    ""time"": ""2025-09-02 15:56:00"",
    ""price"": 238.08,
    ""change"": 8.36,
    ""percentage_change"": 3.64
  }";
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var uriString = "https://www.example.com";

        // Act
        var response = await client.GetApiResultAsync<StockQuote>(uriString, TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.AreEqual("AAPL", response.Data.TradingSymbol);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetApiResultAsync_WithHttpRequestException_ReturnsApiResult()
    {
        // Arrange
        var apiKey = "some-api-key";
        var message = "some error message";
        var exception = new HttpRequestException(message);
        using var mockHandler = new MockHttpMessageHandler() { AlwaysThrows = exception };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var uriString = "https://www.example.com";

        // Act
        var response = await client.GetApiResultAsync<StockQuote>(uriString, TestContext.CancellationToken);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual(message, response.Error);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetApiResultAsync_WithJsonException_ReturnsApiResult()
    {
        // Arrange
        var apiKey = "some-api-key";
        var message = "some error message";
        var exception = new JsonException(message);
        using var mockHandler = new MockHttpMessageHandler() { AlwaysThrows = exception };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var uriString = "https://www.example.com";

        // Act
        var response = await client.GetApiResultAsync<StockQuote>(uriString, TestContext.CancellationToken);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.Contains("JSON", response.Error);
        Assert.Contains(uriString, response.Error);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetApiResultAsync_WithException_ReturnsApiResult()
    {
        // Arrange
        var apiKey = "some-api-key";
        var message = "some error message";
        var exception = new Exception(message);
        using var mockHandler = new MockHttpMessageHandler() { AlwaysThrows = exception };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var uriString = "https://www.example.com";

        // Act
        var response = await client.GetApiResultAsync<StockQuote>(uriString, TestContext.CancellationToken);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.Contains("API", response.Error);
        Assert.Contains(uriString, response.Error);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetApiResultAsync_AppendsApiKey()
    {
        // Arrange
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = "{}" };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var uriString = "https://www.example.com";

        // Act
        var response = await client.GetApiResultAsync<StockQuote>(uriString, TestContext.CancellationToken);

        // Assert
        Assert.Contains(apiKey, mockHandler.ProvidedRequestUri!.PathAndQuery);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetApiResultAsync_WithQueryUri_AppendsApiKey()
    {
        // Arrange
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = "{}" };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var uriString = "https://www.example.com?test=1";

        // Act
        var response = await client.GetApiResultAsync<StockQuote>(uriString, TestContext.CancellationToken);

        // Assert
        Assert.Contains(apiKey, mockHandler.ProvidedRequestUri!.PathAndQuery);
    }

    [TestMethod]
    public async Task FinancialDataClient_GetApiResultAsync_WithCancellation_ReturnsApiResult()
    {
        // Arrange
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = "{}" };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var uriString = "https://www.example.com";

        // Create a pre-cancelled token
        var cts = new CancellationTokenSource();
        cts.Cancel();

        // Act
        var response = await client.GetApiResultAsync<StockQuote>(uriString, cts.Token);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.Contains("API", response.Error);
        Assert.Contains(uriString, response.Error);
    }




    [ExcludeFromCodeCoverage]
    class MockLogger : ILogger
    {
#pragma warning disable CS8633 // Nullability in constraints for type parameter doesn't match the constraints for type parameter in implicitly implemented interface method'.
        public IDisposable BeginScope<TState>(TState state) => null!;
#pragma warning restore CS8633 // Nullability in constraints for type parameter doesn't match the constraints for type parameter in implicitly implemented interface method'.
        public bool IsEnabled(LogLevel logLevel) => true;
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            // No-op
        }
    }

}
