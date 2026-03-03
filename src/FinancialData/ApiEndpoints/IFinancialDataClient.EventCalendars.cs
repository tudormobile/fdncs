using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving event calendar data from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Earnings Calendar - Standard Subscription
    Task<FinancialDataResponse<List<EarningsCalendar>>> GetEarningsCalendarAsync(DateOnly? date = null, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EarningsCalendar>>.StandardSubscriptionNotImplemented();

    // IPO Calendar - Standard Subscription
    Task<FinancialDataResponse<List<IpoCalendar>>> GetIpoCalendarAsync(DateOnly? date = null, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<IpoCalendar>>.StandardSubscriptionNotImplemented();

    // Splits Calendar - Standard Subscription
    Task<FinancialDataResponse<List<SplitsCalendar>>> GetSplitsCalendarAsync(DateOnly? date = null, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<SplitsCalendar>>.StandardSubscriptionNotImplemented();

    // Dividends Calendar - Standard Subscription
    Task<FinancialDataResponse<List<DividendsCalendar>>> GetDividendsCalendarAsync(DateOnly? date = null, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<DividendsCalendar>>.StandardSubscriptionNotImplemented();

    // Economic Calendar - Premium Subscription
    Task<FinancialDataResponse<List<EconomicCalendar>>> GetEconomicCalendarAsync(string? country = null, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EconomicCalendar>>.PremiumSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}