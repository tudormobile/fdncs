namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a real-time or recent quote for an ETF, including price, change, and percentage change.
/// <para>See: https://financialdata.net/documentation#ETF_quotes</para>
/// </summary>
public record EtfQuotes
{
    /// <summary>
    /// Gets or sets the trading symbol of the ETF.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the description of the ETF.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Gets or sets the time of the quote.
    /// </summary>
    public DateTime? Time { get; init; }

    /// <summary>
    /// Gets or sets the current price of the ETF.
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
/* ref: https://financialdata.net/documentation#ETF_quotes
{
    "trading_symbol": "SPY",
    "description": "SPDR S&P 500 ETF Trust",
    "time": "2025-09-02 15:59:30",
    "price": 642.41,
    "change": 2.14,
    "percentage_change": 0.33
  }
*/