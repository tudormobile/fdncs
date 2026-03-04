namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily historical option price data including open, high, low, close, and volume.
/// <para>See: https://financialdata.net/documentation#option_prices</para>
/// </summary>
public record OptionPrice
{
    /// <summary>
    /// Gets the option contract name.
    /// </summary>
    public string? ContractName { get; init; }

    /// <summary>
    /// Gets the date of the price record.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the opening price.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest price.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest price.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing price.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets the trading volume.
    /// </summary>
    public decimal Volume { get; init; }
}
