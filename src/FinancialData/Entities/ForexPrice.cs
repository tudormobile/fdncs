namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily historical price data for a forex currency pair.
/// <para>See: https://financialdata.net/documentation#forex_prices</para>
/// </summary>
public record ForexPrice
{
    /// <summary>
    /// Gets or sets the trading symbol of the forex pair.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the date of the price record.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets or sets the opening rate.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets or sets the highest rate.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets or sets the lowest rate.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets or sets the closing rate.
    /// </summary>
    public decimal Close { get; init; }
}
