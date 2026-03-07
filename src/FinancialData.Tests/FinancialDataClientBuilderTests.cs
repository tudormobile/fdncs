namespace FinancialData.Tests;

using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;
using Tudormobile.FinancialData;

[TestClass]
public class FinancialDataClientBuilderTests
{
    [TestMethod]
    public void Build_WithValidConfiguration_ReturnsClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var apiKey = "test-api-key";
        var builder = new FinancialDataClientBuilder();
        builder.WithHttpClient(httpClient);
        builder.WithApiKey(apiKey);

        // Act
        var client = builder.Build();

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
    }

    [TestMethod]
    public void Build_WithoutHttpClient_ThrowsInvalidOperationException()
    {
        // Arrange
        var apiKey = "test-api-key";
        var builder = new FinancialDataClientBuilder();
        builder.WithApiKey(apiKey);

        // Act & Assert
        var exception = Assert.ThrowsExactly<InvalidOperationException>(() => builder.Build());
        Assert.Contains("HttpClient", exception.Message);
    }

    [TestMethod]
    public void Build_WithoutApiKey_ThrowsInvalidOperationException()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var builder = new FinancialDataClientBuilder();
        builder.WithHttpClient(httpClient);

        // Act & Assert
        var exception = Assert.ThrowsExactly<InvalidOperationException>(() => builder.Build());
        Assert.Contains("API key", exception.Message);
    }

    [TestMethod]
    public void Build_WithEmptyApiKey_ThrowsArgumentException()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var builder = new FinancialDataClientBuilder();
        builder.WithHttpClient(httpClient);

        // Act & Assert
        Assert.ThrowsExactly<ArgumentException>(() => builder.WithApiKey("   "));
    }

    [TestMethod]
    public void WithHttpClient_WithValidClient_ReturnsBuilderInstance()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var builder = new FinancialDataClientBuilder();

        // Act
        var result = builder.WithHttpClient(httpClient);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreSame(builder, result);
    }

    [TestMethod]
    public void WithHttpClient_WithNullClient_ThrowsArgumentNullException()
    {
        // Arrange
        var builder = new FinancialDataClientBuilder();

        // Act & Assert
        Assert.ThrowsExactly<ArgumentNullException>(() => builder.WithHttpClient(null!));
    }

    [TestMethod]
    public void WithApiKey_WithValidKey_ReturnsBuilderInstance()
    {
        // Arrange
        var apiKey = "test-api-key";
        var builder = new FinancialDataClientBuilder();

        // Act
        var result = builder.WithApiKey(apiKey);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreSame(builder, result);
    }

    [TestMethod]
    public void WithApiKey_WithNullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var builder = new FinancialDataClientBuilder();

        // Act & Assert
        Assert.ThrowsExactly<ArgumentNullException>(() => builder.WithApiKey(null!));
    }

    [TestMethod]
    public void WithApiKey_WithEmptyKey_ThrowsArgumentException()
    {
        // Arrange
        var builder = new FinancialDataClientBuilder();

        // Act & Assert
        Assert.ThrowsExactly<ArgumentException>(() => builder.WithApiKey(string.Empty));
    }

    [TestMethod]
    public void WithApiKey_WithWhitespaceKey_ThrowsArgumentException()
    {
        // Arrange
        var builder = new FinancialDataClientBuilder();

        // Act & Assert
        Assert.ThrowsExactly<ArgumentException>(() => builder.WithApiKey("   "));
    }

    [TestMethod]
    public void WithSerializer_WithValidSerializer_ReturnsBuilderInstance()
    {
        // Arrange
        var serializer = FinancialDataSerializer.Instance;
        var builder = new FinancialDataClientBuilder();

        // Act
        var result = builder.WithSerializer(serializer);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreSame(builder, result);
    }

    [TestMethod]
    public void WithSerializer_WithNullSerializer_ThrowsArgumentNullException()
    {
        // Arrange
        var builder = new FinancialDataClientBuilder();

        // Act & Assert
        Assert.ThrowsExactly<ArgumentNullException>(() => builder.WithSerializer(null!));
    }

    [TestMethod]
    public void AddLogging_WithValidLogger_ReturnsBuilderInstance()
    {
        // Arrange
        var logger = new MockLogger();
        var builder = new FinancialDataClientBuilder();

        // Act
        var result = builder.AddLogging(logger);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreSame(builder, result);
    }

    [TestMethod]
    public void FluentInterface_WithAllMethods_ReturnsClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var logger = new MockLogger();
        var serializer = FinancialDataSerializer.Instance;
        var apiKey = "test-api-key";

        // Act
        var client = new FinancialDataClientBuilder()
            .WithHttpClient(httpClient)
            .WithApiKey(apiKey)
            .WithSerializer(serializer)
            .AddLogging(logger)
            .Build();

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
    }

    [TestMethod]
    public void FluentInterface_WithMinimalConfiguration_ReturnsClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var apiKey = "test-api-key";

        // Act
        var client = new FinancialDataClientBuilder()
            .WithHttpClient(httpClient)
            .WithApiKey(apiKey)
            .Build();

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
    }

    [TestMethod]
    public void ApiKey_AfterSet_ReturnsCorrectValue()
    {
        // Arrange
        var apiKey = "test-api-key";
        var builder = new FinancialDataClientBuilder();
        builder.WithApiKey(apiKey);

        // Act
        var result = builder.ApiKey;

        // Assert
        Assert.AreEqual(apiKey, result);
    }

    [TestMethod]
    public void ApiKey_BeforeSet_ReturnsEmptyString()
    {
        // Arrange
        var builder = new FinancialDataClientBuilder();

        // Act
        var result = builder.ApiKey;

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [TestMethod]
    public void Serializer_AfterSet_ReturnsCorrectValue()
    {
        // Arrange
        var serializer = FinancialDataSerializer.Instance;
        var builder = new FinancialDataClientBuilder();
        builder.WithSerializer(serializer);

        // Act
        var result = builder.Serializer;

        // Assert
        Assert.AreSame(serializer, result);
    }

    [TestMethod]
    public void Serializer_BeforeSet_ReturnsNull()
    {
        // Arrange
        var builder = new FinancialDataClientBuilder();

        // Act
        var result = builder.Serializer;

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Build_WithCustomSerializer_PassesSerializerToClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var apiKey = "test-api-key";
        var serializer = FinancialDataSerializer.Instance;
        var builder = new FinancialDataClientBuilder();
        builder.WithHttpClient(httpClient);
        builder.WithApiKey(apiKey);
        builder.WithSerializer(serializer);

        // Act
        var client = builder.Build();

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
    }

    [TestMethod]
    public void Build_WithLogger_PassesLoggerToClient()
    {
        // Arrange
        using var httpClient = new HttpClient();
        var logger = new MockLogger();
        var apiKey = "test-api-key";
        var builder = new FinancialDataClientBuilder();
        builder.WithHttpClient(httpClient);
        builder.WithApiKey(apiKey);
        builder.AddLogging(logger);

        // Act
        var client = builder.Build();

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
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

