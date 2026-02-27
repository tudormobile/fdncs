using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Tudormobile.FinancialData.Extensions;

/// <summary>
/// Provides extension methods for registering Financial Data client services with an <see cref="IServiceCollection"/>.
/// </summary>
/// <remarks>Use these extension methods to add and configure Financial Data API clients in ASP.NET Core dependency
/// injection containers. This enables applications to access financial data using strongly-typed
/// services.</remarks>
public static class FinancialDataServiceCollectionExtensions
{
    /// <summary>
    /// Adds Financial Data client services to the specified <see cref="IServiceCollection"/>.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection"/> to add services to.</param>
    /// <param name="configure">The action used to configure the <see cref="IFinancialDataClientBuilder"/>.</param>
    /// <returns>The <see cref="IServiceCollection"/> so that additional calls can be chained.</returns>
    public static IServiceCollection AddFinancialDataClient(
        this IServiceCollection services,
        Action<IFinancialDataClientBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configure);

        // Create a builder to capture configuration
        var builder = new FinancialDataClientBuilder();
        configure(builder);

        // Register HttpClient for FinancialDataClient
        services.AddHttpClient(nameof(IFinancialDataClient));
        // Register IFinancialDataClient with a factory that provides the API key
        services.AddScoped<IFinancialDataClient>(sp =>
        {
            var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
            var logger = sp.GetRequiredService<ILogger<IFinancialDataClient>>();

            // Use the captured options from the builder
            return new FinancialDataClient(builder.ApiKey, httpClientFactory, logger, builder.Serializer);
        });

        return services;
    }
}