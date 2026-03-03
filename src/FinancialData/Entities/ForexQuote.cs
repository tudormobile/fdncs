namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents real-time quote data for a forex currency pair.
/// <para>See: https://financialdata.net/documentation#forex_quotes</para>
/// </summary>
public record ForexQuote
{
    /// <summary>
    /// Gets or sets the trading symbol of the forex pair.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the timestamp of the quote (UTC).
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// Gets or sets the bid price.
    /// </summary>
    public decimal Bid { get; init; }

    /// <summary>
    /// Gets or sets the ask price.
    /// </summary>
    public decimal Ask { get; init; }

    /// <summary>
    /// Gets or sets the current exchange rate.
    /// </summary>
    public decimal Rate { get; init; }
}
