namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a real-time or recent quote for a market index, including price, change, and percentage change.
/// <para>See: https://financialdata.net/documentation#index_quotes</para>
/// </summary>
public record IndexQuote
{
    /// <summary>
    /// Gets or sets the trading symbol of the market index.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the name of the market index.
    /// </summary>
    public string? IndexName { get; init; }

    /// <summary>
    /// Gets or sets the time of the quote.
    /// </summary>
    public DateTime? Time { get; init; }

    /// <summary>
    /// Gets or sets the current price of the index.
    /// </summary>
    public decimal? Price { get; init; }

    /// <summary>
    /// Gets or sets the price change.
    /// </summary>
    public decimal? Change { get; init; }

    /// <summary>
    /// Gets or sets the percentage change in price.
    /// </summary>
    public decimal? PercentageChange { get; init; }
}
/* ref: https://financialdata.net/documentation#index_quotes
{
    "trading_symbol": "^GSPC",
    "index_name": "S&P 500",
    "time": "2025-09-23 15:19:59",
    "price": 6656.92,
    "change": -36.83,
    "percentage_change": -0.55
  }
*/
