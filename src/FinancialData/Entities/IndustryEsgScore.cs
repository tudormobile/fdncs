namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents average ESG scores for an industry sector.
/// <para>See: https://financialdata.net/documentation#industry_esg_scores</para>
/// </summary>
public record IndustryEsgScore
{
    /// <summary>
    /// Gets the industry name.
    /// </summary>
    public string? Industry { get; init; }

    /// <summary>
    /// Gets the date of the industry ESG score.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the average overall ESG score for the industry.
    /// </summary>
    public decimal AverageTotalScore { get; init; }

    /// <summary>
    /// Gets the average environmental score for the industry.
    /// </summary>
    public decimal AverageEnvironmentalScore { get; init; }

    /// <summary>
    /// Gets the average social score for the industry.
    /// </summary>
    public decimal AverageSocialScore { get; init; }

    /// <summary>
    /// Gets the average governance score for the industry.
    /// </summary>
    public decimal AverageGovernanceScore { get; init; }

    /// <summary>
    /// Gets the average controversy score for the industry.
    /// </summary>
    public decimal AverageControversyScore { get; init; }

    /// <summary>
    /// Gets the number of companies in the industry sample.
    /// </summary>
    public int NumberOfCompanies { get; init; }
}
