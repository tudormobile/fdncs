namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a single stock quote, including trading symbol, registrant name, time, price, and price changes.
/// </summary>
public record StockQuote
{
    /// <summary>
    /// The trading symbol of the stock.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// The registrant name associated with the stock.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// The timestamp of the quote.
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// The quoted price of the stock.
    /// </summary>
    public decimal Price { get; init; }

    /// <summary>
    /// The absolute change in price since the previous quote.
    /// </summary>
    public decimal Change { get; init; }

    /// <summary>
    /// The percentage change in price since the previous quote.
    /// </summary>
    public decimal PercentageChange { get; init; }
}
/* ref: https://financialdata.net/documentation#stock_quotes
{
    "trading_symbol": "AAPL",
    "registrant_name": "Apple Inc.",
    "time": "2025-09-02 15:56:00",
    "price": 238.08,
    "change": 8.36,
    "percentage_change": 3.64
  }
*/
