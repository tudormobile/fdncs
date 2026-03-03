using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

public partial interface IFinancialDataClient
{
    // Supress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    Task<FinancialDataResponse<List<IndexSymbol>>> GetIndexSymbolsAsync(CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<IndexSymbol>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<IndexQuote>>> GetIndexQuotesAsync(IEnumerable<string> identifiers, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<IndexQuote>>.PremiumSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<IndexPrice>>> GetIndexPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<IndexPrice>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<IndexConstituent>>> GetIndexConstituentsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<IndexConstituent>>.StandardSubscriptionNotImplemented();
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or members
}