namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents stock split data including execution date and split multiplier.
/// <para>See: https://financialdata.net/documentation#stock_splits</para>
/// </summary>
public record StockSplit
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the central index key (CIK) assigned by the SEC.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the execution date of the stock split.
    /// </summary>
    public DateOnly ExecutionDate { get; init; }

    /// <summary>
    /// Gets or sets the split multiplier (e.g., 2.0 for 2-for-1 split).
    /// </summary>
    public decimal Multiplier { get; init; }
}
