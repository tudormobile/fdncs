namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an investment adviser with CRD number and firm name.
/// <para>See: https://financialdata.net/documentation#investment_adviser_names</para>
/// </summary>
public record InvestmentAdviserName
{
    /// <summary>
    /// Gets or sets the CRD (Central Registration Depository) number.
    /// </summary>
    public string? CrdNumber { get; init; }

    /// <summary>
    /// Gets or sets the SEC file number.
    /// </summary>
    public string? SecFileNumber { get; init; }

    /// <summary>
    /// Gets or sets the firm name of the investment adviser.
    /// </summary>
    public string? FirmName { get; init; }
}
