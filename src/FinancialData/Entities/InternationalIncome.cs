namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an international income statement for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#international_income_statements
/// </remarks>
public record InternationalIncome
{
    /// <summary>
    /// The trading symbol of the security (e.g., "SHEL.L").
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// The name of the registrant.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// The fiscal period (e.g., "FY" for full year).
    /// </summary>
    public string? FiscalPeriod { get; init; }

    /// <summary>
    /// The end date of the reporting period.
    /// </summary>
    public DateOnly PeriodEndDate { get; init; }

    /// <summary>
    /// The currency code for the reported values (e.g., "USD").
    /// </summary>
    public string? CurrencyCode { get; init; }

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
/* ref: https://financialdata.net/documentation#international_income_statements
{
    "trading_symbol": "SHEL.L",
    "registrant_name": "Shell plc",
    "fiscal_period": "FY",
    "period_end_date": "2024-12-31",
    "currency_code": "USD",
    "revenue": 284312000000.0,
    "cost_of_revenue": 238371000000.0,
    "gross_profit": 45941000000.0,
    "research_and_development_expenses": 1099000000.0,
    "general_and_administrative_expenses": 12439000000.0,
    "operating_expenses": 15949000000.0,
    "operating_income": 29992000000.0,
    "interest_expense": 4858000000.0,
    "interest_income": 2461000000.0,
    "net_income": 16094000000.0,
    "earnings_per_share_basic": 2.55,
    "earnings_per_share_diluted": 2.53,
    "weighted_average_shares_outstanding_basic": 6299600000,
    "weighted_average_shares_outstanding_diluted": 6363700000
}
*/
