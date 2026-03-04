namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents the latest one-minute price data for a security for the current week.
/// <para>See: https://financialdata.net/documentation#latest_prices</para>
/// </summary>
public record LatestPrice
{
    /// <summary>
    /// Gets the trading symbol of the security.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the timestamp of the price record (UTC).
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// Gets the opening price for the one-minute period.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest price during the one-minute period.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest price during the one-minute period.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing price for the one-minute period.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets the trading volume for the one-minute period.
    /// </summary>
    public decimal Volume { get; init; }
}
