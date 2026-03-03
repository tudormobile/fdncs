namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an institutional holding position in a company's stock.
/// <para>See: https://financialdata.net/documentation#institutional_holdings</para>
/// </summary>
public record InstitutionalHolding
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the central index key (CIK) of the company.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the central index key (CIK) of the institutional investor.
    /// </summary>
    public string? InvestorCik { get; init; }

    /// <summary>
    /// Gets or sets the name of the institutional investor.
    /// </summary>
    public string? InvestorName { get; init; }

    /// <summary>
    /// Gets or sets the reporting period end date.
    /// </summary>
    public DateOnly PeriodEndDate { get; init; }

    /// <summary>
    /// Gets or sets the filing date with the SEC.
    /// </summary>
    public DateOnly FilingDate { get; init; }

    /// <summary>
    /// Gets or sets the number of shares held.
    /// </summary>
    public decimal Shares { get; init; }

    /// <summary>
    /// Gets or sets the market value of the holding.
    /// </summary>
    public decimal Value { get; init; }

    /// <summary>
    /// Gets or sets the percentage of the portfolio represented by this holding.
    /// </summary>
    public decimal PortfolioPercent { get; init; }

    /// <summary>
    /// Gets or sets the change in shares from the previous period.
    /// </summary>
    public decimal SharesChange { get; init; }

    /// <summary>
    /// Gets or sets the percentage change in shares.
    /// </summary>
    public decimal SharesChangePercent { get; init; }
}
