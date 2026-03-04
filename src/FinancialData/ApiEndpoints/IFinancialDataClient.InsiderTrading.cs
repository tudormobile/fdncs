using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving insider trading data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Insider Transactions - Premium Subscription
    Task<FinancialDataResponse<List<InsiderTransaction>>> GetInsiderTransactionsAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InsiderTransaction>>.PremiumSubscriptionNotImplemented();

    // Proposed Sales (Form 144) - Premium Subscription
    Task<FinancialDataResponse<List<ProposedSale>>> GetProposedSalesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<ProposedSale>>.PremiumSubscriptionNotImplemented();

    // Senate Trading - Premium Subscription
    Task<FinancialDataResponse<List<SenateTrading>>> GetSenateTradingAsync(string? identifier = null, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<SenateTrading>>.PremiumSubscriptionNotImplemented();

    // House Trading - Premium Subscription
    Task<FinancialDataResponse<List<HouseTrading>>> GetHouseTradingAsync(string? identifier = null, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<HouseTrading>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}