namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily historical price data for international stocks.
/// <para>See: https://financialdata.net/documentation#international_stock_prices</para>
/// </summary>
public record InternationalStockPrice
{
    /// <summary>
    /// Gets the trading symbol of the international stock.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the date of the price record.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the opening price for the trading day.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest price during the trading day.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest price during the trading day.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing price for the trading day.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets the trading volume for the day.
    /// </summary>
    public decimal Volume { get; init; }
}
