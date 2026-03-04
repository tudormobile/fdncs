namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents executive compensation data including salary, bonus, stock awards, and total compensation.
/// <para>See: https://financialdata.net/documentation#executive_compensation</para>
/// </summary>
public record ExecutiveCompensation
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
    /// Gets or sets the name of the executive.
    /// </summary>
    public string? ExecutiveName { get; init; }

    /// <summary>
    /// Gets or sets the position or title of the executive.
    /// </summary>
    public string? ExecutiveTitle { get; init; }

    /// <summary>
    /// Gets or sets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets or sets the base salary.
    /// </summary>
    public decimal Salary { get; init; }

    /// <summary>
    /// Gets or sets the bonus amount.
    /// </summary>
    public decimal Bonus { get; init; }

    /// <summary>
    /// Gets or sets the value of stock awards.
    /// </summary>
    public decimal StockAwards { get; init; }

    /// <summary>
    /// Gets or sets the value of option awards.
    /// </summary>
    public decimal OptionAwards { get; init; }

    /// <summary>
    /// Gets or sets the non-equity incentive plan compensation.
    /// </summary>
    public decimal NonEquityIncentivePlanCompensation { get; init; }

    /// <summary>
    /// Gets or sets all other compensation.
    /// </summary>
    public decimal AllOtherCompensation { get; init; }

    /// <summary>
    /// Gets or sets the total compensation.
    /// </summary>
    public decimal TotalCompensation { get; init; }
}
/* ref: https://financialdata.net/documentation#executive_compensation
{
    "trading_symbol": "AAPL",
    "central_index_key": "0000320193",
    "registrant_name": "Apple Inc.",
    "fiscal_year": "2023",
    "executive_name": "Tim Cook",
    "executive_title": "CEO",
    "salary": 3000000.0,
    "bonus": 12000000.0,
    "stock_awards": 82000000.0,
    "option_awards": 0.0,
    "non_equity_incentive_plan_compensation": 10000000.0,
    "all_other_compensation": 1500000.0,
    "total_compensation": 108500000.0
}
*/

