using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

public partial interface IFinancialDataClient
{
    // Supress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    Task<FinancialDataResponse<List<EtfQuotes>>> GetEtfQuotesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EtfQuotes>>.PremiumSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<EtfPrices>>> GetEtfPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EtfPrices>>.PremiumSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<EtfHoldings>>> GetEtfHoldingsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EtfHoldings>>.PremiumSubscriptionNotImplemented();
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or members
}