using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData.Extensions;

namespace FinancialData.Tests;

[TestClass]
public class FinancialDataServiceCollectionExtensionsTests
{
    [TestMethod]
    public void AddFinancialDataClient_WithValidConfiguration_RegistersService()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddHttpClient();

        // Act
        services.AddFinancialDataClient(builder =>
        {
            builder.WithApiKey("test-api-key");
        });

        var serviceProvider = services.BuildServiceProvider();
        var client = serviceProvider.GetService<IFinancialDataClient>();

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
        Assert.IsInstanceOfType<FinancialDataClient>(client);
    }

    [TestMethod]
    public void AddFinancialDataClient_ServiceLifetime_IsScoped()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddHttpClient();

        // Act
        services.AddFinancialDataClient(builder =>
        {
            builder.WithApiKey("test-api-key");
        });

        // Assert
        var descriptor = services.FirstOrDefault(s => s.ServiceType == typeof(IFinancialDataClient));
        Assert.IsNotNull(descriptor);
        Assert.AreEqual(ServiceLifetime.Scoped, descriptor.Lifetime);
    }

    [TestMethod]
    public void AddFinancialDataClient_ReturnsSameServiceCollection_ForChaining()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddHttpClient();

        // Act
        var result = services.AddFinancialDataClient(builder =>
        {
            builder.WithApiKey("test-api-key");
        });

        // Assert
        Assert.AreSame(services, result);
    }

    [TestMethod]
    public void AddFinancialDataClient_NullServices_ThrowsArgumentNullException()
    {
        // Arrange
        IServiceCollection services = null!;

        // Act & Assert
        Assert.ThrowsExactly<ArgumentNullException>(() =>
            services.AddFinancialDataClient(builder => builder.WithApiKey("test")));
    }

    [TestMethod]
    public void AddFinancialDataClient_NullConfigureAction_ThrowsArgumentNullException()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act & Assert
        Assert.ThrowsExactly<ArgumentNullException>(() =>
            services.AddFinancialDataClient(null!));
    }

    [TestMethod]
    public void AddFinancialDataClient_WithSerializer_RegistersClientWithSerializer()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddHttpClient();
        var testSerializer = new TestFinancialDataSerializer();

        // Act
        services.AddFinancialDataClient(builder =>
        {
            builder.WithApiKey("test-api-key");
            builder.WithSerializer(testSerializer);
        });

        var serviceProvider = services.BuildServiceProvider();
        var client = serviceProvider.GetService<IFinancialDataClient>();

        // Assert
        Assert.IsNotNull(client);
        Assert.IsInstanceOfType<IFinancialDataClient>(client);
    }

    [TestMethod]
    public void AddFinancialDataClient_ConfigureActionExecuted_BuilderReceivesConfiguration()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddHttpClient();
        var configureWasCalled = false;
        IFinancialDataClientBuilder? capturedBuilder = null;

        // Act
        services.AddFinancialDataClient(builder =>
        {
            configureWasCalled = true;
            capturedBuilder = builder;
            builder.WithApiKey("test-api-key");
        });

        // Assert
        Assert.IsTrue(configureWasCalled);
        Assert.IsNotNull(capturedBuilder);
        Assert.IsInstanceOfType<FinancialDataClientBuilder>(capturedBuilder);
    }

    [TestMethod]
    public void AddFinancialDataClient_ScopedLifetime_DifferentInstancesInDifferentScopes()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddHttpClient();

        services.AddFinancialDataClient(builder =>
        {
            builder.WithApiKey("test-api-key");
        });

        var serviceProvider = services.BuildServiceProvider();

        // Act
        IFinancialDataClient client1;
        IFinancialDataClient client2;
        IFinancialDataClient client3;

        using (var scope1 = serviceProvider.CreateScope())
        {
            client1 = scope1.ServiceProvider.GetRequiredService<IFinancialDataClient>();
            client2 = scope1.ServiceProvider.GetRequiredService<IFinancialDataClient>();
        }

        using (var scope2 = serviceProvider.CreateScope())
        {
            client3 = scope2.ServiceProvider.GetRequiredService<IFinancialDataClient>();
        }

        // Assert
        Assert.AreSame(client1, client2, "Clients in the same scope should be the same instance");
        Assert.AreNotSame(client1, client3, "Clients in different scopes should be different instances");
    }

    [TestMethod]
    public void AddFinancialDataClient_RegistersHttpClient_WithCorrectName()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddHttpClient();

        // Act
        services.AddFinancialDataClient(builder =>
        {
            builder.WithApiKey("test-api-key");
        });

        var serviceProvider = services.BuildServiceProvider();
        var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
        var httpClient = httpClientFactory.CreateClient(nameof(IFinancialDataClient));

        // Assert
        Assert.IsNotNull(httpClient);
    }

#pragma warning disable IDE0060
    [ExcludeFromCodeCoverage]
    private class TestFinancialDataSerializer : IFinancialDataSerializer
    {
        public static T? Deserialize<T>(string json) => default;
        public T Deserialize<T>(JsonDocument doc) => throw new NotImplementedException();
        public static string Serialize<T>(T obj) => string.Empty;
        public string Serialize(BalanceSheet balanceSheet) => throw new NotImplementedException();
        public string Serialize(StockPrice stockPrice) => throw new NotImplementedException();
    }
#pragma warning restore IDE0060
}
