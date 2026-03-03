namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an insider trading transaction reported to the SEC.
/// <para>See: https://financialdata.net/documentation#insider_transactions</para>
/// </summary>
public record InsiderTransaction
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
    /// Gets or sets the name of the insider.
    /// </summary>
    public string? InsiderName { get; init; }

    /// <summary>
    /// Gets or sets the title/relationship of the insider to the company.
    /// </summary>
    public string? InsiderTitle { get; init; }

    /// <summary>
    /// Gets or sets the date of the transaction.
    /// </summary>
    public DateOnly TransactionDate { get; init; }

    /// <summary>
    /// Gets or sets the filing date with the SEC.
    /// </summary>
    public DateOnly FilingDate { get; init; }

    /// <summary>
    /// Gets or sets the transaction type (e.g., Purchase, Sale).
    /// </summary>
    public string? TransactionType { get; init; }

    /// <summary>
    /// Gets or sets the transaction code.
    /// </summary>
    public string? TransactionCode { get; init; }

    /// <summary>
    /// Gets or sets the number of shares transacted.
    /// </summary>
    public decimal Shares { get; init; }

    /// <summary>
    /// Gets or sets the price per share.
    /// </summary>
    public decimal Price { get; init; }

    /// <summary>
    /// Gets or sets the total value of the transaction.
    /// </summary>
    public decimal Value { get; init; }

    /// <summary>
    /// Gets or sets the number of shares owned after the transaction.
    /// </summary>
    public decimal SharesOwnedAfterTransaction { get; init; }

    /// <summary>
    /// Gets or sets the URL to the SEC filing.
    /// </summary>
    public string? SecFilingUrl { get; init; }
}
