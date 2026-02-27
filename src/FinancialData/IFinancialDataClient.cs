namespace Tudormobile.FinancialData;

/// <summary>
/// Interface to provide methods for interacting with the financial data API.
/// </summary>
public partial interface IFinancialDataClient
{
    /// <summary>
    /// Creates a new instance of an object that implements the IFinancialDataClient interface using the specified API
    /// key, HTTP client, and optional serializer.
    /// </summary>
    /// <remarks>Ensure that the provided HttpClient is properly configured for the intended use, including
    /// any necessary headers or settings.</remarks>
    /// <param name="apiKey">The API key used to authenticate requests to the financial data service. This parameter cannot be null or empty.</param>
    /// <param name="httpClient">The HttpClient instance used to send HTTP requests to the financial data service. It is recommended to reuse the
    /// same instance for multiple requests.</param>
    /// <param name="serializer">An optional serializer used for serializing and deserializing financial data. If not specified, a default
    /// serializer is used.</param>
    /// <returns>An instance of IFinancialDataClient that can be used to interact with the financial data service.</returns>
    public static IFinancialDataClient Create(
        string apiKey,
        HttpClient httpClient,
        IFinancialDataSerializer? serializer = null) => new FinancialDataClient(apiKey, httpClient, null, serializer);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="uriString"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<FinancialDataResponse<T>> GetApiResultAsync<T>(string uriString, CancellationToken cancellationToken);

    // Financial Data API Endpoints


}
