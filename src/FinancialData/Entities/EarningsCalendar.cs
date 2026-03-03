namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an upcoming earnings release on the earnings calendar.
/// <para>See: https://financialdata.net/documentation#earnings_calendar</para>
/// </summary>
public record EarningsCalendar
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the fiscal quarter end date.
    /// </summary>
    public string? FiscalQuarterEndDate { get; init; }

    /// <summary>
    /// Gets or sets the report date.
    /// </summary>
    public DateOnly ReportDate { get; init; }

    /// <summary>
    /// Gets or sets the conference call time (EST).
    /// </summary>
    public DateTime ConferenceCallTime { get; init; }

    /// <summary>
    /// Gets or sets the forecasted earnings per share.
    /// </summary>
    public decimal EarningsPerShareForecast { get; init; }
}
