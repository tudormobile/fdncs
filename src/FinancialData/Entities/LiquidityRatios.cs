namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents liquidity ratios and related financial metrics for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#liquidity_ratios
/// </remarks>
public record LiquidityRatios
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
    /// The fiscal year for the reported ratios.
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
    /// Working capital for the period.
    /// </summary>
    public decimal WorkingCapital { get; init; }

    /// <summary>
    /// Current ratio for the period.
    /// </summary>
    public decimal CurrentRatio { get; init; }

    /// <summary>
    /// Cash ratio for the period.
    /// </summary>
    public decimal CashRatio { get; init; }

    /// <summary>
    /// Quick ratio for the period.
    /// </summary>
    public decimal QuickRatio { get; init; }

    /// <summary>
    /// Days of inventory outstanding for the period.
    /// </summary>
    public decimal DaysOfInventoryOutstanding { get; init; }

    /// <summary>
    /// Days sales outstanding for the period.
    /// </summary>
    public decimal DaysSalesOutstanding { get; init; }

    /// <summary>
    /// Days payables outstanding for the period.
    /// </summary>
    public decimal DaysPayablesOutstanding { get; init; }

    /// <summary>
    /// Cash conversion cycle for the period.
    /// </summary>
    public decimal CashConversionCycle { get; init; }

    /// <summary>
    /// Sales to working capital ratio for the period.
    /// </summary>
    public decimal SalesToWorkingCapitalRatio { get; init; }

    /// <summary>
    /// Cash to current liabilities ratio for the period.
    /// </summary>
    public decimal CashToCurrentLiabilitiesRatio { get; init; }

    /// <summary>
    /// Working capital to debt ratio for the period.
    /// </summary>
    public decimal WorkingCapitalToDebtRatio { get; init; }

    /// <summary>
    /// Cash flow adequacy ratio for the period.
    /// </summary>
    public decimal CashFlowAdequacyRatio { get; init; }

    /// <summary>
    /// Sales to current assets ratio for the period.
    /// </summary>
    public decimal SalesToCurrentAssetsRatio { get; init; }

    /// <summary>
    /// Cash to current assets ratio for the period.
    /// </summary>
    public decimal CashToCurrentAssetsRatio { get; init; }

    /// <summary>
    /// Cash to working capital ratio for the period.
    /// </summary>
    public decimal CashToWorkingCapitalRatio { get; init; }

    /// <summary>
    /// Inventory to working capital ratio for the period.
    /// </summary>
    public decimal InventoryToWorkingCapitalRatio { get; init; }

    /// <summary>
    /// Net debt for the period.
    /// </summary>
    public decimal NetDebt { get; init; }
}
/* ref: https://financialdata.net/documentation#liquidity_ratios
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "working_capital": 34448000000.0,
    "current_ratio": 1.27495490318152,
    "cash_ratio": 0.719497789058634,
    "quick_ratio": 1.63062912057213,
    "days_of_inventory_outstanding": 2.97460668699571,
    "days_sales_outstanding": 90.1168295787404,
    "days_payables_outstanding": 117.05619046334,
    "cash_conversion_cycle": -23.9647541976042,
    "sales_to_working_capital_ratio": 6.77619284569028,
    "cash_to_current_liabilities_ratio": 1.17627667895854,
    "working_capital_to_debt_ratio": 0.730047047853177,
    "cash_flow_adequacy_ratio": 1.06121206695909,
    "sales_to_current_assets_ratio": 1.53456371217149,
    "cash_to_current_assets_ratio": 0.922602576783903,
    "cash_to_working_capital_ratio": 2.61678471899675,
    "inventory_to_working_capital_ratio": 0.0344446287388732,
    "net_debt": -42957000000.0
} 
*/
