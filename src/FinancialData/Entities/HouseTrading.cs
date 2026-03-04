namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a stock transaction by a U.S. House of Representatives member.
/// <para>See: https://financialdata.net/documentation#house_trading</para>
/// </summary>
public record HouseTrading
{
    /// <summary>
    /// Gets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the name of the House member.
    /// </summary>
    public string? RepresentativeName { get; init; }

    /// <summary>
    /// Gets the date of the transaction.
    /// </summary>
    public DateOnly TransactionDate { get; init; }

    /// <summary>
    /// Gets the disclosure date.
    /// </summary>
    public DateOnly DisclosureDate { get; init; }

    /// <summary>
    /// Gets the transaction type (e.g., Purchase, Sale).
    /// </summary>
    public string? TransactionType { get; init; }

    /// <summary>
    /// Gets the asset type (e.g., Stock, Stock Option).
    /// </summary>
    public string? AssetType { get; init; }

    /// <summary>
    /// Gets the amount range of the transaction.
    /// </summary>
    public string? AmountRange { get; init; }

    /// <summary>
    /// Gets additional comments.
    /// </summary>
    public string? Comment { get; init; }
}
