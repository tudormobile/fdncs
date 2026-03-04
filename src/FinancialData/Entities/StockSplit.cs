namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents stock split data including execution date and split multiplier.
/// <para>See: https://financialdata.net/documentation#stock_splits</para>
/// </summary>
public record StockSplit
{
    /// <summary>
    /// Gets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the central index key (CIK) assigned by the SEC.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets the execution date of the stock split.
    /// </summary>
    public DateOnly ExecutionDate { get; init; }

    /// <summary>
    /// Gets the ratio that represents how a stock has been split, typically expressed as a string (for example, "2:1").
    /// </summary>
    /// <remarks>The split ratio indicates the proportion by which shares are divided during a stock split.
    /// The value should follow the expected format (such as "2:1" or "3:2") to ensure correct interpretation.
    /// </remarks>
    public string? SplitRatio { get; init; }

}
