namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents real-time quote data for a cryptocurrency including price, volume, and market cap.
/// <para>See: https://financialdata.net/documentation#crypto_quotes</para>
/// </summary>
public record CryptoQuote
{
    /// <summary>
    /// Gets or sets the trading symbol of the cryptocurrency.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the timestamp of the quote (UTC).
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// Gets or sets the current price.
    /// </summary>
    public decimal Price { get; init; }

    /// <summary>
    /// Gets or sets the 24-hour trading volume.
    /// </summary>
    public decimal Volume { get; init; }

    /// <summary>
    /// Gets or sets the market capitalization.
    /// </summary>
    public decimal MarketCap { get; init; }

    /// <summary>
    /// Gets or sets the 24-hour price change percentage.
    /// </summary>
    public decimal PercentChange { get; init; }
}
