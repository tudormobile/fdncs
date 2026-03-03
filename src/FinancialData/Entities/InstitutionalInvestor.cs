namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an institutional investor with name and CIK.
/// <para>See: https://financialdata.net/documentation#institutional_investors</para>
/// </summary>
public record InstitutionalInvestor
{
    /// <summary>
    /// Gets or sets the central index key (CIK) of the institutional investor.
    /// </summary>
    public string? InvestorCik { get; init; }

    /// <summary>
    /// Gets or sets the name of the institutional investor.
    /// </summary>
    public string? InvestorName { get; init; }
}
