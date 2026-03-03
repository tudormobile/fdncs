namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily historical futures price data including open, high, low, close, and volume.
/// <para>See: https://financialdata.net/documentation#futures_prices</para>
/// </summary>
public record FuturesPrice
{
    /// <summary>
    /// Gets or sets the trading symbol of the futures contract.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the date of the price record.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets or sets the opening price.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets or sets the highest price.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets or sets the lowest price.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets or sets the closing price.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets or sets the trading volume.
    /// </summary>
    public decimal Volume { get; init; }
}
