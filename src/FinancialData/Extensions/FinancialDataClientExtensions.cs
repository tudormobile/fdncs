using Microsoft.Extensions.Logging;

namespace Tudormobile.FinancialData.Extensions;

/// <summary>
/// Provides extension methods for working with instances of <see cref="IFinancialDataClient"/>.
/// </summary>
/// <remarks>
/// This class contains static methods that extend the functionality of <see cref="IFinancialDataClient"/>
/// implementations, enabling fluent configuration and builder patterns. These extensions are intended to simplify
/// client setup and integration scenarios.
/// <para>
/// The code uses the newer C# extension method syntax with the 'extension' keyword for better readability and conciseness.
/// </para>
/// </remarks>
public static class FinancialDataClientExtensions
{
    // Extension block - receiver type only. These methods appear as static methods on IFinancialDataClient.
    extension(IFinancialDataClient)
    {
        /// <summary>
        /// Creates a new builder for configuring and constructing an instance of a Financial Data client.
        /// </summary>
        /// <returns>An <see cref="IFinancialDataClientBuilder"/> that can be used to configure and build an <see
        /// cref="IFinancialDataClient"/> instance.</returns>
        public static IFinancialDataClientBuilder GetBuilder() => new FinancialDataClientBuilder();

        /// <summary>
        /// Creates and initializes a new instance of the <see cref="IFinancialDataClient"/> class.
        /// </summary>
        /// <param name="apiKey">The API key used for authenticating requests to the financial data service.</param>
        /// <param name="httpClient">The HTTP client used for sending requests to the API.</param>
        /// <param name="logger">Optional logger instance for logging diagnostic information. If null, a NullLogger will be used.</param>
        /// <param name="serializer">Optional serializer instance for serializing and deserializing API data. If null, the internal serializer will be used.</param>
        public static IFinancialDataClient Create(
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
        public static IFinancialDataClient Create(
            string apiKey,
            HttpClient httpClient,
            ILogger logger) => new FinancialDataClient(apiKey, httpClient, logger, serializer: null);
    }

}
