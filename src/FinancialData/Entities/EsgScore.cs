namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents ESG (Environmental, Social, Governance) scores for a company.
/// <para>See: https://financialdata.net/documentation#esg_scores</para>
/// </summary>
public record EsgScore
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
    /// Gets the date of the ESG score.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the overall ESG score.
    /// </summary>
    public decimal TotalScore { get; init; }

    /// <summary>
    /// Gets the environmental score.
    /// </summary>
    public decimal EnvironmentalScore { get; init; }

    /// <summary>
    /// Gets the social score.
    /// </summary>
    public decimal SocialScore { get; init; }

    /// <summary>
    /// Gets the governance score.
    /// </summary>
    public decimal GovernanceScore { get; init; }

    /// <summary>
    /// Gets the controversy score.
    /// </summary>
    public decimal ControversyScore { get; init; }
}
