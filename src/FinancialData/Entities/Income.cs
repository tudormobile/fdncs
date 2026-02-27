namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an income statement for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#income_statements
/// </remarks>
public record Income
{
    /// <summary>
    /// The trading symbol of the security (e.g., "MSFT").
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// The central index key (CIK) for the registrant.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// The name of the registrant.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// The fiscal year for the reported statement.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// The fiscal period (e.g., "FY" for full year).
    /// </summary>
    public string? FiscalPeriod { get; init; }

    /// <summary>
    /// The end date of the reporting period.
    /// </summary>
    public DateOnly PeriodEndDate { get; init; }

    /// <summary>
    /// Total revenue for the period.
    /// </summary>
    public decimal Revenue { get; init; }

    /// <summary>
    /// Cost of revenue for the period.
    /// </summary>
    public decimal CostOfRevenue { get; init; }

    /// <summary>
    /// Gross profit for the period.
    /// </summary>
    public decimal GrossProfit { get; init; }

    /// <summary>
    /// Research and development expenses for the period.
    /// </summary>
    public decimal ResearchAndDevelopmentExpenses { get; init; }

    /// <summary>
    /// General and administrative expenses for the period.
    /// </summary>
    public decimal GeneralAndAdministrativeExpenses { get; init; }

    /// <summary>
    /// Operating expenses for the period.
    /// </summary>
    public decimal OperatingExpenses { get; init; }

    /// <summary>
    /// Operating income for the period.
    /// </summary>
    public decimal OperatingIncome { get; init; }

    /// <summary>
    /// Interest expense for the period.
    /// </summary>
    public decimal InterestExpense { get; init; }

    /// <summary>
    /// Interest income for the period.
    /// </summary>
    public decimal InterestIncome { get; init; }

    /// <summary>
    /// Net income for the period.
    /// </summary>
    public decimal NetIncome { get; init; }

    /// <summary>
    /// Basic earnings per share for the period.
    /// </summary>
    public decimal EarningsPerShareBasic { get; init; }

    /// <summary>
    /// Diluted earnings per share for the period.
    /// </summary>
    public decimal EarningsPerShareDiluted { get; init; }

    /// <summary>
    /// Weighted average shares outstanding (basic).
    /// </summary>
    public decimal WeightedAverageSharesOutstandingBasic { get; init; }

    /// <summary>
    /// Weighted average shares outstanding (diluted).
    /// </summary>
    public decimal WeightedAverageSharesOutstandingDiluted { get; init; }
}
/* ref: https://financialdata.net/documentation#income_statements
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "revenue": 245122000000.0,
    "cost_of_revenue": 74114000000.0,
    "gross_profit": 171008000000.0,
    "research_and_development_expenses": 29510000000.0,
    "general_and_administrative_expenses": 7609000000.0,
    "operating_expenses": null,
    "operating_income": 109433000000.0,
    "interest_expense": 2935000000.0,
    "interest_income": 3157000000.0,
    "net_income": 88136000000.0,
    "earnings_per_share_basic": 11.86,
    "earnings_per_share_diluted": 11.8,
    "weighted_average_shares_outstanding_basic": 7431000000,
    "weighted_average_shares_outstanding_diluted": 7469000000
}
 */
