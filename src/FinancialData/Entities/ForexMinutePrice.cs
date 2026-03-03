namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents one-minute historical price data for a forex currency pair.
/// <para>See: https://financialdata.net/documentation#forex_minute_prices</para>
/// </summary>
public record ForexMinutePrice
{
    /// <summary>
    /// Gets or sets the trading symbol of the forex pair.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the timestamp of the minute price record (UTC).
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// Gets or sets the opening rate for the one-minute period.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets or sets the highest rate during the one-minute period.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets or sets the lowest rate during the one-minute period.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets or sets the closing rate for the one-minute period.
    /// </summary>
    public decimal Close { get; init; }
}
