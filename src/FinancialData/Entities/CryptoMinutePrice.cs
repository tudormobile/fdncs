namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents one-minute historical price data for a cryptocurrency.
/// <para>See: https://financialdata.net/documentation#crypto_minute_prices</para>
/// </summary>
public record CryptoMinutePrice
{
    /// <summary>
    /// Gets or sets the trading symbol of the cryptocurrency.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the timestamp of the minute price record (UTC).
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// Gets or sets the opening price for the one-minute period.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets or sets the highest price during the one-minute period.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets or sets the lowest price during the one-minute period.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets or sets the closing price for the one-minute period.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets or sets the trading volume for the one-minute period.
    /// </summary>
    public decimal Volume { get; init; }
}
