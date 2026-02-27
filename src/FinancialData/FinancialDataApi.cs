namespace Tudormobile.FinancialData;

/// <summary>
/// Provides factory methods for creating clients that interact with financial data APIs.
/// </summary>
/// <remarks>This static class enables the creation of financial data clients with customizable HTTP communication
/// and serialization options. Use this class to obtain instances of clients that can access various financial data
/// services. The created clients can be configured with a specific HTTP client and serializer to suit different
/// application requirements.</remarks>
public static class FinancialDataApi
{
    /// <summary>
    /// Creates and initializes a new instance of the <see cref="IFinancialDataClient"/> class.
    /// </summary>
    /// <param name="apiKey">The API key used for authenticating requests to the financial data service.</param>
    /// <param name="httpClient">The HTTP client used for sending requests to the API.</param>
    /// <param name="serializer">Optional serializer instance for serializing and deserializing API data. If null, the internal serializer will be used.</param>
    public static IFinancialDataClient CreateClient(
        string apiKey,
        HttpClient httpClient,
        IFinancialDataSerializer? serializer = null) => IFinancialDataClient.Create(apiKey, httpClient, serializer);

    /// <summary>
    /// The root URI for the financial data API.
    /// </summary>
    public readonly static string RootUri = "https://financialdata.net/api/v1/";

    /// <summary>
    /// The Financial Data API version.
    /// </summary>
    public static readonly string ApiVersion = "v1";
}
