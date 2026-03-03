namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents ESG rating classification for a company.
/// <para>See: https://financialdata.net/documentation#esg_ratings</para>
/// </summary>
public record EsgRating
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
    /// Gets or sets the date of the ESG rating.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets or sets the overall ESG rating (e.g., AAA, AA, A, BBB, BB, B, CCC).
    /// </summary>
    public string? Rating { get; init; }

    /// <summary>
    /// Gets or sets the environmental rating.
    /// </summary>
    public string? EnvironmentalRating { get; init; }

    /// <summary>
    /// Gets or sets the social rating.
    /// </summary>
    public string? SocialRating { get; init; }

    /// <summary>
    /// Gets or sets the governance rating.
    /// </summary>
    public string? GovernanceRating { get; init; }
}
