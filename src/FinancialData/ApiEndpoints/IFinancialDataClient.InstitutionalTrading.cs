using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving institutional trading and holdings data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Institutional Investors - Premium Subscription
    Task<FinancialDataResponse<List<InstitutionalInvestor>>> GetInstitutionalInvestorsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InstitutionalInvestor>>.PremiumSubscriptionNotImplemented();

    // Institutional Holdings - Premium Subscription
    Task<FinancialDataResponse<List<InstitutionalHolding>>> GetInstitutionalHoldingsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InstitutionalHolding>>.PremiumSubscriptionNotImplemented();

    // Institutional Portfolio Statistics - Premium Subscription
    Task<FinancialDataResponse<List<InstitutionalPortfolioStatistics>>> GetInstitutionalPortfolioStatisticsAsync(string investorCik, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InstitutionalPortfolioStatistics>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}