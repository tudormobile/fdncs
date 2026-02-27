namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily price data for a commodity.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#commodity_prices
/// </remarks>
public record CommodityPrice
{
    /// <summary>
    /// The trading symbol of the commodity (e.g., "ZC").
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

/* ref: https://financialdata.net/documentation#commodity_prices
{
    "trading_symbol": "ZC",
    "date": "2024-12-03",
    "open": 425.0,
    "high": 428.0,
    "low": 422.75,
    "close": 423.25,
    "volume": 4078.0
}
*/
