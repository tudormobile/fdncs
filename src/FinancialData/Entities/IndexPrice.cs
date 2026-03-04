namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily price information for a market index, including open, high, low, close, and volume.
/// <para>See: https://financialdata.net/documentation#index_prices</para>
/// </summary>
public record IndexPrice
{
    /// <summary>
    /// Gets the trading symbol of the market index.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the date of the price record.
    /// </summary>
    public DateOnly? Date { get; init; }

    /// <summary>
    /// Gets the opening price of the index for the trading period.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest price recorded during the trading period.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest price recorded during the trading period.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing price of the index for the trading period.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets the total traded volume for the index.
    /// </summary>
    public decimal Volume { get; init; }
}
/* ref: https://financialdata.net/documentation#index_prices
{
    "trading_symbol": "^GSPC",
    "date": "2025-06-13",
    "open": 6000.56,
    "high": 6026.16,
    "low": 5963.21,
    "close": 5976.97,
    "volume": 5258910000.0
  }
*/