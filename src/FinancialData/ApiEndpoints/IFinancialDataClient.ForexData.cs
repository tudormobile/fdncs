using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving forex (foreign exchange) data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Forex Symbols - Premium Subscription
    Task<FinancialDataResponse<List<ForexSymbol>>> GetForexSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<ForexSymbol>>.PremiumSubscriptionNotImplemented();

    // Forex Quotes - Premium Subscription
    Task<FinancialDataResponse<List<ForexQuote>>> GetForexQuotesAsync(IEnumerable<string> identifiers, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<ForexQuote>>.PremiumSubscriptionNotImplemented();

    // Forex Prices - Premium Subscription
    Task<FinancialDataResponse<List<ForexPrice>>> GetForexPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<ForexPrice>>.PremiumSubscriptionNotImplemented();

    // Forex Minute Prices - Premium Subscription
    Task<FinancialDataResponse<List<ForexMinutePrice>>> GetForexMinutePricesAsync(string identifier, DateOnly date, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<ForexMinutePrice>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}