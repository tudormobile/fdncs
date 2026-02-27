using Microsoft.Extensions.Logging;

namespace Tudormobile.FinancialData;

internal class FinancialDataClientBuilder : IFinancialDataClientBuilder
{
    private HttpClient? _httpClient;
    private ILogger? _logger;
    private IFinancialDataSerializer? _serializer;
    private string? _apiKey;

    internal string ApiKey => _apiKey ?? string.Empty;
    internal IFinancialDataSerializer? Serializer => _serializer;

    public IFinancialDataClient Build()
    {
        if (_httpClient == null)
        {
            throw new InvalidOperationException("An HttpClient instance must be provided. Use WithHttpClient() to indicate what client instance to use.");
        }
        if (_apiKey == null || string.IsNullOrWhiteSpace(_apiKey))
        {
            throw new InvalidOperationException("An API key must be provided. Use WithApiKey() to indicate what API key to use.");
        }
        return new FinancialDataClient(_apiKey, _httpClient, _logger, _serializer);
    }

    public IFinancialDataClientBuilder AddLogging(ILogger logger)
    {
        _logger = logger;
        return this;
    }

    public IFinancialDataClientBuilder WithHttpClient(HttpClient httpClient)
    {
        ArgumentNullException.ThrowIfNull(httpClient);
        _httpClient = httpClient;
        return this;
    }

    public IFinancialDataClientBuilder WithSerializer(IFinancialDataSerializer serializer)
    {
        ArgumentNullException.ThrowIfNull(serializer);
        _serializer = serializer;
        return this;
    }

    public IFinancialDataClientBuilder WithApiKey(string apiKey)
    {
        ArgumentNullException.ThrowIfNull(apiKey);
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentException("API key cannot be empty or whitespace.", nameof(apiKey));
        }
        _apiKey = apiKey;
        return this;
    }
}