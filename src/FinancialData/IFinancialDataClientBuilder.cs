using Microsoft.Extensions.Logging;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides a fluent interface for configuring and building instances of <see cref="IFinancialDataClient"/>.
/// </summary>
public interface IFinancialDataClientBuilder
{
    /// <summary>
    /// Builds and returns a configured instance of <see cref="IFinancialDataClient"/> using the settings specified through the builder.
    /// </summary>
    /// <returns>A fully configured <see cref="IFinancialDataClient"/> instance ready to interact with the financial data API.</returns>
    IFinancialDataClient Build();

    /// <summary>
    /// Configures the client builder to use the specified API key for authenticating requests to the financial data
    /// service.
    /// </summary>
    /// <param name="apiKey">The API key used to authenticate requests. This value must be a non-empty string and cannot be null.</param>
    /// <returns>The current builder instance configured to use the specified API key.</returns>
    IFinancialDataClientBuilder WithApiKey(string apiKey);

    /// <summary>
    /// Configures the builder to use the specified HTTP client for sending requests to the financial data API.
    /// </summary>
    /// <remarks>Use this method to provide a custom-configured HttpClient, for example to set custom headers,
    /// proxies, or timeouts. If not set, a default HttpClient may be used by the implementation.</remarks>
    /// <param name="httpClient">The HTTP client instance to use for all outgoing API requests. Cannot be null. The caller is responsible for
    /// managing the lifetime of the provided client.</param>
    /// <returns>The current builder instance configured to use the specified HTTP client.</returns>
    IFinancialDataClientBuilder WithHttpClient(HttpClient httpClient);

    /// <summary>
    /// Configures the builder to use the specified serializer for handling API response data.
    /// </summary>
    /// <param name="serializer">The serializer instance to use for serializing and deserializing API data. Cannot be null.</param>
    /// <returns>The current instance of the client builder for method chaining.</returns>
    IFinancialDataClientBuilder WithSerializer(IFinancialDataSerializer serializer);

    /// <summary>
    /// Adds the specified logger to the client builder for capturing diagnostic and operational messages.
    /// </summary>
    /// <param name="logger">The logger instance to use for logging client activity. Cannot be null.</param>
    /// <returns>The current instance of the client builder for method chaining.</returns>
    IFinancialDataClientBuilder AddLogging(ILogger logger);

}
