namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents portfolio statistics for an institutional investor.
/// <para>See: https://financialdata.net/documentation#institutional_portfolio_statistics</para>
/// </summary>
public record InstitutionalPortfolioStatistics
{
    /// <summary>
    /// Gets the central index key (CIK) of the institutional investor.
    /// </summary>
    public string? InvestorCik { get; init; }

    /// <summary>
    /// Gets the name of the institutional investor.
    /// </summary>
    public string? InvestorName { get; init; }

    /// <summary>
    /// Gets the reporting period end date.
    /// </summary>
    public DateOnly PeriodEndDate { get; init; }

    /// <summary>
    /// Gets the filing date with the SEC.
    /// </summary>
    public DateOnly FilingDate { get; init; }

    /// <summary>
    /// Gets the total portfolio value.
    /// </summary>
    public decimal TotalValue { get; init; }

    /// <summary>
    /// Gets the number of holdings in the portfolio.
    /// </summary>
    public int NumberOfHoldings { get; init; }

    /// <summary>
    /// Gets the number of new positions.
    /// </summary>
    public int NewPositions { get; init; }

    /// <summary>
    /// Gets the number of sold out positions.
    /// </summary>
    public int SoldOutPositions { get; init; }

    /// <summary>
    /// Gets the number of increased positions.
    /// </summary>
    public int IncreasedPositions { get; init; }

    /// <summary>
    /// Gets the number of decreased positions.
    /// </summary>
    public int DecreasedPositions { get; init; }

    /// <summary>
    /// Gets the total value change from the previous period.
    /// </summary>
    public decimal TotalValueChange { get; init; }

    /// <summary>
    /// Gets the percentage change in total value.
    /// </summary>
    public decimal TotalValueChangePercent { get; init; }
}
