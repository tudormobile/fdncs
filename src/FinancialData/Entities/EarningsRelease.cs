namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents earnings release information including actual and predicted earnings, release timing, and market cap.
/// <para>See: https://financialdata.net/documentation#earnings_releases</para>
/// </summary>
public record EarningsRelease
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the central index key (CIK) assigned by the SEC.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the market capitalization.
    /// </summary>
    public decimal MarketCap { get; init; }

    /// <summary>
    /// Gets or sets the fiscal quarter end date.
    /// </summary>
    public string? FiscalQuarterEndDate { get; init; }

    /// <summary>
    /// Gets or sets the actual earnings per share.
    /// </summary>
    public decimal EarningsPerShare { get; init; }

    /// <summary>
    /// Gets or sets the forecasted earnings per share.
    /// </summary>
    public decimal EarningsPerShareForecast { get; init; }

    /// <summary>
    /// Gets or sets the percentage surprise (difference between actual and forecast).
    /// </summary>
    public decimal PercentageSurprise { get; init; }

    /// <summary>
    /// Gets or sets the number of analyst forecasts.
    /// </summary>
    public int NumberOfForecasts { get; init; }

    /// <summary>
    /// Gets or sets the conference call time (EST).
    /// </summary>
    public DateTime ConferenceCallTime { get; init; }
}
