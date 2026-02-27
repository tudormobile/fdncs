namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily OTC (Over-the-Counter) price data for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#OTC_prices
/// </remarks>
public record OtcPrice
{
    /// <summary>
    /// The trading symbol of the security (e.g., "AABB").
    /// </summary>
    public string? TradingSymbol { get; set; }

    /// <summary>
    /// The date for the price record (format: yyyy-MM-dd).
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// The opening price for the trading day.
    /// </summary>
    public decimal Open { get; set; }

    /// <summary>
    /// The highest price reached during the trading day.
    /// </summary>
    public decimal High { get; set; }

    /// <summary>
    /// The lowest price reached during the trading day.
    /// </summary>
    public decimal Low { get; set; }

    /// <summary>
    /// The closing price for the trading day.
    /// </summary>
    public decimal Close { get; set; }

    /// <summary>
    /// The trading volume for the day.
    /// </summary>
    public decimal Volume { get; set; }
}

/* ref: https://financialdata.net/documentation#OTC_prices
{
    "trading_symbol": "AABB",
    "date": "2024-12-04",
    "open": 0.0271,
    "high": 0.0271,
    "low": 0.024,
    "close": 0.0248,
    "volume": 6592169.0
}
*/
