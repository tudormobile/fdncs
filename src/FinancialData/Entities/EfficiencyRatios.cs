namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents efficiency ratios and related financial metrics for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#efficiency_ratios
/// </remarks>
public record EfficiencyRatios
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
    /// Asset turnover ratio for the period.
    /// </summary>
    public decimal AssetTurnoverRatio { get; init; }

    /// <summary>
    /// Inventory turnover ratio for the period.
    /// </summary>
    public decimal InventoryTurnoverRatio { get; init; }

    /// <summary>
    /// Accounts receivable turnover ratio for the period.
    /// </summary>
    public decimal AccountsReceivableTurnoverRatio { get; init; }

    /// <summary>
    /// Accounts payable turnover ratio for the period.
    /// </summary>
    public decimal AccountsPayableTurnoverRatio { get; init; }

    /// <summary>
    /// Equity multiplier for the period.
    /// </summary>
    public decimal EquityMultiplier { get; init; }

    /// <summary>
    /// Days sales in inventory for the period.
    /// </summary>
    public decimal DaysSalesInInventory { get; init; }

    /// <summary>
    /// Fixed asset turnover ratio for the period.
    /// </summary>
    public decimal FixedAssetTurnoverRatio { get; init; }

    /// <summary>
    /// Days working capital for the period.
    /// </summary>
    public decimal DaysWorkingCapital { get; init; }

    /// <summary>
    /// Working capital turnover ratio for the period.
    /// </summary>
    public decimal WorkingCapitalTurnoverRatio { get; init; }

    /// <summary>
    /// Days cash on hand for the period.
    /// </summary>
    public decimal DaysCashOnHand { get; init; }

    /// <summary>
    /// Capital intensity ratio for the period.
    /// </summary>
    public decimal CapitalIntensityRatio { get; init; }

    /// <summary>
    /// Sales to equity ratio for the period.
    /// </summary>
    public decimal SalesToEquityRatio { get; init; }

    /// <summary>
    /// Inventory to sales ratio for the period.
    /// </summary>
    public decimal InventoryToSalesRatio { get; init; }

    /// <summary>
    /// Investment turnover ratio for the period.
    /// </summary>
    public decimal InvestmentTurnoverRatio { get; init; }

    /// <summary>
    /// Sales to operating income ratio for the period.
    /// </summary>
    public decimal SalesToOperatingIncomeRatio { get; init; }
}
/* ref: https://financialdata.net/documentation#efficiency_ratios
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "asset_turnover_ratio": 0.478601538963182,
    "inventory_turnover_ratio": 122.705298013245,
    "accounts_receivable_turnover_ratio": 4.05029783788696,
    "accounts_payable_turnover_ratio": 3.17218166901571,
    "equity_multiplier": 1.90766061897295,
    "days_sales_in_inventory": 2.97460668699571,
    "fixed_asset_turnover_ratio": 1.55308101463922,
    "days_working_capital": 51.2949470059807,
    "working_capital_turnover_ratio": 7.11571063632141,
    "days_cash_on_hand": null,
    "capital_intensity_ratio": 2.08942077822472,
    "sales_to_equity_ratio": 0.913009308059908,
    "inventory_to_sales_ratio": 0.00246407911162605,
    "investment_turnover_ratio": 0.77653066719888,
    "sales_to_operating_income_ratio": 2.23992762694982
}
 */
