using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving derivatives data (options and futures) from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Option Chain - Premium Subscription
    Task<FinancialDataResponse<List<OptionChain>>> GetOptionChainAsync(string identifier, DateOnly? expirationDate = null, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<OptionChain>>.PremiumSubscriptionNotImplemented();

    // Option Prices - Premium Subscription
    Task<FinancialDataResponse<List<OptionPrice>>> GetOptionPricesAsync(string contractName, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<OptionPrice>>.PremiumSubscriptionNotImplemented();

    // Option Greeks - Premium Subscription
    Task<FinancialDataResponse<List<OptionGreeks>>> GetOptionGreeksAsync(string contractName, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<OptionGreeks>>.PremiumSubscriptionNotImplemented();

    // Futures Symbols - Premium Subscription
    Task<FinancialDataResponse<List<FuturesSymbol>>> GetFuturesSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<FuturesSymbol>>.PremiumSubscriptionNotImplemented();

    // Futures Prices - Premium Subscription
    Task<FinancialDataResponse<List<FuturesPrice>>> GetFuturesPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<FuturesPrice>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}