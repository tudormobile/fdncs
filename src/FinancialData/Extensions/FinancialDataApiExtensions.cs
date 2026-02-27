using Microsoft.Extensions.Logging;

namespace Tudormobile.FinancialData.Extensions;

/// <summary>
/// Extension methods for the <see cref="FinancialDataApi"/> class, providing additional functionality and convenience methods for working with financial data clients.
/// </summary>
public static class FinancialDataApiExtensions
{
    // Extension block - receiver type only. These methods appear as static methods on FinancialData.
    extension(FinancialDataApi)
    {
        /// <summary>
        /// Creates and initializes a new instance of the <see cref="IFinancialDataClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key used for authenticating requests to the financial data service.</param>
        /// <param name="httpClient">The HTTP client used for sending requests to the API.</param>
        /// <param name="logger">Optional logger instance for logging diagnostic information. If null, a NullLogger will be used.</param>
        /// <param name="serializer">Optional serializer instance for serializing and deserializing API data. If null, the internal serializer will be used.</param>
        public static IFinancialDataClient CreateClient(
            string apiKey,
            HttpClient httpClient,
            IFinancialDataSerializer serializer,
            ILogger logger) => new FinancialDataClient(apiKey, httpClient, logger, serializer);

        /// <summary>
        /// Creates and initializes a new instance of the <see cref="IFinancialDataClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key used for authenticating requests to the financial data service.</param>
        /// <param name="httpClient">The HTTP client used for sending requests to the API.</param>
        /// <param name="logger">Optional logger instance for logging diagnostic information. If null, a NullLogger will be used.</param>
        public static IFinancialDataClient CreateClient(
            string apiKey,
            HttpClient httpClient,
            ILogger logger) => new FinancialDataClient(apiKey, httpClient, logger, serializer: null);

        /// <summary>
        /// Creates a new builder for configuring and constructing an instance of an Financial Data client.
        /// </summary>
        /// <returns>An <see cref="IFinancialDataClientBuilder"/> that can be used to configure and build an <see
        /// cref="IFinancialDataClient"/> instance.</returns>
        public static IFinancialDataClientBuilder GetClientBuilder() => new FinancialDataClientBuilder();

    }
}
