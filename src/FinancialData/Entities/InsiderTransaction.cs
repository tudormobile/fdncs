namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an insider trading transaction reported to the SEC.
/// <para>See: https://financialdata.net/documentation#insider_transactions</para>
/// </summary>
public record InsiderTransaction
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
    /// Gets the name of the insider.
    /// </summary>
    public string? InsiderName { get; init; }

    /// <summary>
    /// Gets the title/relationship of the insider to the company.
    /// </summary>
    public string? InsiderTitle { get; init; }

    /// <summary>
    /// Gets the date of the transaction.
    /// </summary>
    public DateOnly TransactionDate { get; init; }

    /// <summary>
    /// Gets the filing date with the SEC.
    /// </summary>
    public DateOnly FilingDate { get; init; }

    /// <summary>
    /// Gets the transaction type (e.g., Purchase, Sale).
    /// </summary>
    public string? TransactionType { get; init; }

    /// <summary>
    /// Gets the transaction code.
    /// </summary>
    public string? TransactionCode { get; init; }

    /// <summary>
    /// Gets the number of shares transacted.
    /// </summary>
    public decimal Shares { get; init; }

    /// <summary>
    /// Gets the price per share.
    /// </summary>
    public decimal Price { get; init; }

    /// <summary>
    /// Gets the total value of the transaction.
    /// </summary>
    public decimal Value { get; init; }

    /// <summary>
    /// Gets the number of shares owned after the transaction.
    /// </summary>
    public decimal SharesOwnedAfterTransaction { get; init; }

    /// <summary>
    /// Gets the URL to the SEC filing.
    /// </summary>
    public string? SecFilingUrl { get; init; }
}
