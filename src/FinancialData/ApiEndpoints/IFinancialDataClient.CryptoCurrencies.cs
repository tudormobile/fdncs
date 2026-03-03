using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving cryptocurrency data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Crypto Symbols - Premium Subscription
    Task<FinancialDataResponse<List<CryptoSymbol>>> GetCryptoSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<CryptoSymbol>>.PremiumSubscriptionNotImplemented();

    // Crypto Information - Premium Subscription
    Task<FinancialDataResponse<List<CryptoInformation>>> GetCryptoInformationAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<CryptoInformation>>.PremiumSubscriptionNotImplemented();

    // Crypto Quotes - Premium Subscription
    Task<FinancialDataResponse<List<CryptoQuote>>> GetCryptoQuotesAsync(IEnumerable<string> identifiers, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<CryptoQuote>>.PremiumSubscriptionNotImplemented();

    // Crypto Prices - Premium Subscription
    Task<FinancialDataResponse<List<CryptoPrice>>> GetCryptoPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<CryptoPrice>>.PremiumSubscriptionNotImplemented();

    // Crypto Minute Prices - Premium Subscription
    Task<FinancialDataResponse<List<CryptoMinutePrice>>> GetCryptoMinutePricesAsync(string identifier, DateOnly date, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<CryptoMinutePrice>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}