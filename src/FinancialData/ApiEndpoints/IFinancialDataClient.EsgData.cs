using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving ESG (Environmental, Social, Governance) data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // ESG Scores - Premium Subscription
    Task<FinancialDataResponse<List<EsgScore>>> GetEsgScoresAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EsgScore>>.PremiumSubscriptionNotImplemented();

    // ESG Ratings - Premium Subscription
    Task<FinancialDataResponse<List<EsgRating>>> GetEsgRatingsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EsgRating>>.PremiumSubscriptionNotImplemented();

    // Industry ESG Scores - Premium Subscription
    Task<FinancialDataResponse<List<IndustryEsgScore>>> GetIndustryEsgScoresAsync(string industry, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<IndustryEsgScore>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}