namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily historical price data for a forex currency pair.
/// <para>See: https://financialdata.net/documentation#forex_prices</para>
/// </summary>
public record ForexPrice
{
    /// <summary>
    /// Gets the trading symbol of the forex pair.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the date of the price record.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the opening rate.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest rate.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest rate.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing rate.
    /// </summary>
    public decimal Close { get; init; }
}
