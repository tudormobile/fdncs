namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents average ESG scores for an industry sector.
/// <para>See: https://financialdata.net/documentation#industry_esg_scores</para>
/// </summary>
public record IndustryEsgScore
{
    /// <summary>
    /// Gets or sets the industry name.
    /// </summary>
    public string? Industry { get; init; }

    /// <summary>
    /// Gets or sets the date of the industry ESG score.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets or sets the average overall ESG score for the industry.
    /// </summary>
    public decimal AverageTotalScore { get; init; }

    /// <summary>
    /// Gets or sets the average environmental score for the industry.
    /// </summary>
    public decimal AverageEnvironmentalScore { get; init; }

    /// <summary>
    /// Gets or sets the average social score for the industry.
    /// </summary>
    public decimal AverageSocialScore { get; init; }

    /// <summary>
    /// Gets or sets the average governance score for the industry.
    /// </summary>
    public decimal AverageGovernanceScore { get; init; }

    /// <summary>
    /// Gets or sets the average controversy score for the industry.
    /// </summary>
    public decimal AverageControversyScore { get; init; }

    /// <summary>
    /// Gets or sets the number of companies in the industry sample.
    /// </summary>
    public int NumberOfCompanies { get; init; }
}
