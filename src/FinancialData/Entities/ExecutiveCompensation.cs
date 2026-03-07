namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents executive compensation data including salary, bonus, stock awards, and total compensation.
/// <para>See: https://financialdata.net/documentation#executive_compensation</para>
/// </summary>
public record ExecutiveCompensation
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
    /// Gets the name of the executive.
    /// </summary>
    public string? ExecutiveName { get; init; }

    /// <summary>
    /// Gets the position or title of the executive.
    /// </summary>
    public string? ExecutivePosition { get; init; }

    /// <summary>
    /// Gets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets the base salary.
    /// </summary>
    public decimal Salary { get; init; }

    /// <summary>
    /// Gets the bonus amount.
    /// </summary>
    public decimal Bonus { get; init; }

    /// <summary>
    /// Gets the value of stock awards.
    /// </summary>
    public decimal StockAwards { get; init; }

    /// <summary>
    /// Gets the incentive plan compensation.
    /// </summary>
    public decimal IncentivePlanCompensation { get; init; }

    /// <summary>
    /// Gets other compensation.
    /// </summary>
    public decimal OtherCompensation { get; init; }

    /// <summary>
    /// Gets the total compensation.
    /// </summary>
    public decimal TotalCompensation { get; init; }
}
/* ref: https://financialdata.net/documentation#executive_compensation
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "executive_name": "Christopher D. Young",
    "executive_position": "Executive Vice President",
    "fiscal_year": "2024",
    "salary": 850000.0,
    "bonus": 0.0,
    "stock_awards": 9040931.0,
    "incentive_plan_compensation": 2023680.0,
    "other_compensation": 120092.0,
    "total_compensation": 12034703.0
  }*/

