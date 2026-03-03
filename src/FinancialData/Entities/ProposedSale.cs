namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a proposed insider sale reported to the SEC via Form 144.
/// <para>See: https://financialdata.net/documentation#proposed_sales</para>
/// </summary>
public record ProposedSale
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
    /// Gets or sets the filing date with the SEC.
    /// </summary>
    public DateOnly FilingDate { get; init; }

    /// <summary>
    /// Gets or sets the number of shares proposed for sale.
    /// </summary>
    public decimal Shares { get; init; }

    /// <summary>
    /// Gets or sets the URL to the SEC filing.
    /// </summary>
    public string? SecFilingUrl { get; init; }
}
