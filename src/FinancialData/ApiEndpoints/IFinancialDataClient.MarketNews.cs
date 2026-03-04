using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving market news and press releases from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Press Releases - Premium Subscription
    Task<FinancialDataResponse<List<PressRelease>>> GetPressReleasesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<PressRelease>>.PremiumSubscriptionNotImplemented();

    // SEC Press Releases - Premium Subscription
    Task<FinancialDataResponse<List<SecPressRelease>>> GetSecPressReleasesAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<SecPressRelease>>.PremiumSubscriptionNotImplemented();

    // Fed Press Releases - Premium Subscription
    Task<FinancialDataResponse<List<FedPressRelease>>> GetFedPressReleasesAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<FedPressRelease>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}