using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

public partial interface IFinancialDataClient
{
    // Supress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    Task<FinancialDataResponse<List<MutualFundStatistics>>> GetMutualFundStatisticsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<MutualFundStatistics>>.PremiumSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<MutualFundHoldings>>> GetMutualFundHoldingsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<MutualFundHoldings>>.PremiumSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<MutualFundSymbol>>> GetMutualFundSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<MutualFundSymbol>>.PremiumSubscriptionNotImplemented();
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or members
}