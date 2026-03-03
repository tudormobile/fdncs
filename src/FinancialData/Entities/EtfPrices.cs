namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily price information for an ETF, including open, high, low, close, and volume.
/// <para>See: https://financialdata.net/documentation#ETF_prices</para>
/// </summary>
public record EtfPrices
{
    /// <summary>
    /// Gets or sets the trading symbol of the ETF.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the date of the price record.
    /// </summary>
    public DateOnly? Date { get; init; }

    /// <summary>
    /// Gets or sets the opening price of the ETF for the trading period.
    /// </summary>
    public decimal? Open { get; init; }

    /// <summary>
    /// Gets or sets the highest price recorded during the trading period.
    /// </summary>
    public decimal? High { get; init; }

    /// <summary>
    /// Gets or sets the lowest price recorded during the trading period.
    /// </summary>
    public decimal? Low { get; init; }

    /// <summary>
    /// Gets or sets the closing price of the ETF for the trading period.
    /// </summary>
    public decimal? Close { get; init; }

    /// <summary>
    /// Gets or sets the total traded volume for the ETF.
    /// </summary>
    public decimal? Volume { get; init; }
}
/* ref: https://financialdata.net/documentation#ETF_prices
{
    "trading_symbol": "SPY",
    "date": "2024-12-03",
    "open": 603.39,
    "high": 604.16,
    "low": 602.341,
    "close": 603.91,
    "volume": 26906630.0
  }
*/