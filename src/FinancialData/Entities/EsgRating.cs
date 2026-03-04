namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents ESG rating classification for a company.
/// <para>See: https://financialdata.net/documentation#esg_ratings</para>
/// </summary>
public record EsgRating
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
    /// Gets the date of the ESG rating.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the overall ESG rating (e.g., AAA, AA, A, BBB, BB, B, CCC).
    /// </summary>
    public string? Rating { get; init; }

    /// <summary>
    /// Gets the environmental rating.
    /// </summary>
    public string? EnvironmentalRating { get; init; }

    /// <summary>
    /// Gets the social rating.
    /// </summary>
    public string? SocialRating { get; init; }

    /// <summary>
    /// Gets the governance rating.
    /// </summary>
    public string? GovernanceRating { get; init; }
}
