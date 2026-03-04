namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents one-minute historical price data for a forex currency pair.
/// <para>See: https://financialdata.net/documentation#forex_minute_prices</para>
/// </summary>
public record ForexMinutePrice
{
    /// <summary>
    /// Gets the trading symbol of the forex pair.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the timestamp of the minute price record (UTC).
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// Gets the opening rate for the one-minute period.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest rate during the one-minute period.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest rate during the one-minute period.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing rate for the one-minute period.
    /// </summary>
    public decimal Close { get; init; }
}
