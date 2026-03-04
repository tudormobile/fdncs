using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving miscellaneous financial data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Earnings Releases - Standard Subscription
    Task<FinancialDataResponse<List<EarningsRelease>>> GetEarningsReleasesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EarningsRelease>>.StandardSubscriptionNotImplemented();

    // Initial Public Offerings - Standard Subscription
    Task<FinancialDataResponse<List<InitialPublicOffering>>> GetInitialPublicOfferingsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InitialPublicOffering>>.StandardSubscriptionNotImplemented();

    // Stock Splits - Standard Subscription
    Task<FinancialDataResponse<List<StockSplit>>> GetStockSplitsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<StockSplit>>.StandardSubscriptionNotImplemented();

    // Dividends - Standard Subscription
    Task<FinancialDataResponse<List<Dividend>>> GetDividendsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<Dividend>>.StandardSubscriptionNotImplemented();

    // Short Interest - Premium Subscription
    Task<FinancialDataResponse<List<ShortInterest>>> GetShortInterestAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<ShortInterest>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}