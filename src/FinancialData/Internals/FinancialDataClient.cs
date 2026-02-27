using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Tudormobile.FinancialData;

internal class FinancialDataClient : IFinancialDataClient
{
    private readonly HttpClient _httpClient;
    private readonly ILogger _logger;
    private readonly IFinancialDataSerializer _serializer;
    private readonly string _apiKey;

    internal HttpClient HttpClient => _httpClient;
    internal ILogger Logger => _logger;
    internal IFinancialDataSerializer Serializer => _serializer;

    /// <summary>
    /// Initializes a new instance of the <see cref="FinancialDataApi"/> class.
    /// </summary>
    /// <param name="apiKey">The API key used for authenticating requests to the financial data service.</param>
    /// <param name="httpClient">The HTTP client used for sending requests to the API.</param>
    /// <param name="logger">Optional logger instance for logging diagnostic information. If null, a NullLogger will be used.</param>
    /// <param name="serializer">Optional serializer instance for serializing and deserializing API data. If null, the internal serializer will be used.</param>
    public FinancialDataClient(string apiKey, HttpClient httpClient, ILogger? logger = null, IFinancialDataSerializer? serializer = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey, nameof(apiKey));
        ArgumentNullException.ThrowIfNull(httpClient, nameof(httpClient));

        _apiKey = apiKey;
        _httpClient = httpClient;
        _logger = logger ?? Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance; ;
        _serializer = serializer ?? new FinancialDataSerializer();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FinancialDataApi"/> class.
    /// </summary>
    /// <param name="apiKey">The API key used for authenticating requests to the financial data service.</param>
    /// <param name="httpClientFactory">The factory used to create HTTP client instances for sending requests to the API. Cannot be null.</param>
    /// <param name="logger">Optional logger instance for logging diagnostic information. If null, a NullLogger will be used.</param>
    /// <param name="serializer">Optional serializer instance for serializing and deserializing API data. If null, the internal serializer will be used.</param>
    internal FinancialDataClient(string apiKey,
        IHttpClientFactory httpClientFactory,
        ILogger? logger = null,
        IFinancialDataSerializer? serializer = null) : this(apiKey, httpClientFactory.CreateClient(nameof(FinancialDataClient)), logger, serializer) { }

    /// <inheritdoc/>
    Task<FinancialDataResponse<T>> IFinancialDataClient.GetApiResultAsync<T>(string uriString, CancellationToken cancellationToken)
        => GetApiResultAsync<T>(uriString, _serializer.Deserialize<T>, cancellationToken);

    internal async Task<FinancialDataResponse<T>> GetApiResultAsync<T>(string uriString, Func<JsonDocument, T> builder, CancellationToken cancellationToken)
    {
        uriString = $"{FinancialDataApi.RootUri}{uriString}";
        try
        {
            var doc = await GetJsonDocumentAsync(uriString, cancellationToken);
            var data = builder(doc);
            return new FinancialDataResponse<T>(data: data);
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "HTTP request failed for URI: {Uri}", uriString);
            return new FinancialDataResponse<T>(error: ex.Message);
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "Failed to parse JSON response from URI: {Uri}", uriString);
            return new FinancialDataResponse<T>(error: $"Failed to parse JSON response from URI: {uriString}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to get API result from URI: {Uri}", uriString);
            return new FinancialDataResponse<T>(error: $"Failed to get API result from URI: {uriString}");
        }
    }

    private async Task<JsonDocument> GetJsonDocumentAsync(string uriString, CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogDebug("Requesting JSON document from: {Uri}", uriString);

            var uriWithApiKey = uriString.Contains('?')
                ? $"{uriString}&key={_apiKey}"
                : $"{uriString}?key={_apiKey}";
            var stream = await _httpClient.GetStreamAsync(uriWithApiKey, cancellationToken);
            var document = await JsonDocument.ParseAsync(stream, cancellationToken: cancellationToken);

            _logger.LogDebug("Successfully parsed JSON document from: {Uri}", uriString);

            return document;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "HTTP request failed for URI: {Uri}", uriString);
            throw;
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "Failed to parse JSON response from URI: {Uri}", uriString);
            throw;
        }
        catch (OperationCanceledException ex)
        {
            _logger.LogWarning(ex, "Request to {Uri} was canceled", uriString);
            throw;
        }
    }
}
