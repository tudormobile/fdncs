using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

public partial interface IFinancialDataClient
{
    // Supress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    Task<FinancialDataResponse<List<LiquidityRatios>>> GetLiquidityRatiosAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<LiquidityRatios>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<SolvencyRatios>>> GetSolvencyRatiosAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
       => FinancialDataResponse<List<SolvencyRatios>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<EfficiencyRatios>>> GetEfficiencyRatiosAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
       => FinancialDataResponse<List<EfficiencyRatios>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<ProfitabilityRatios>>> GetProfitabilityRatiosAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
       => FinancialDataResponse<List<ProfitabilityRatios>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<ValuationRatios>>> GetValuationRatiosAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
       => FinancialDataResponse<List<ValuationRatios>>.StandardSubscriptionNotImplemented();
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or members
}