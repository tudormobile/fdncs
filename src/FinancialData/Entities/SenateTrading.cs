namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a stock transaction by a U.S. Senator.
/// <para>See: https://financialdata.net/documentation#senate_trading</para>
/// </summary>
public record SenateTrading
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the name of the Senator.
    /// </summary>
    public string? SenatorName { get; init; }

    /// <summary>
    /// Gets or sets the date of the transaction.
    /// </summary>
    public DateOnly TransactionDate { get; init; }

    /// <summary>
    /// Gets or sets the disclosure date.
    /// </summary>
    public DateOnly DisclosureDate { get; init; }

    /// <summary>
    /// Gets or sets the transaction type (e.g., Purchase, Sale).
    /// </summary>
    public string? TransactionType { get; init; }

    /// <summary>
    /// Gets or sets the asset type (e.g., Stock, Stock Option).
    /// </summary>
    public string? AssetType { get; init; }

    /// <summary>
    /// Gets or sets the amount range of the transaction.
    /// </summary>
    public string? AmountRange { get; init; }

    /// <summary>
    /// Gets or sets additional comments.
    /// </summary>
    public string? Comment { get; init; }
}
