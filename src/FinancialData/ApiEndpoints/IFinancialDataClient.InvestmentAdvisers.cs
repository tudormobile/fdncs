using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving investment adviser data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Investment Adviser Names - Premium Subscription
    Task<FinancialDataResponse<List<InvestmentAdviserName>>> GetInvestmentAdviserNamesAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InvestmentAdviserName>>.PremiumSubscriptionNotImplemented();

    // Investment Adviser Information - Premium Subscription
    Task<FinancialDataResponse<List<InvestmentAdviserInformation>>> GetInvestmentAdviserInformationAsync(string crdNumber, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InvestmentAdviserInformation>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}