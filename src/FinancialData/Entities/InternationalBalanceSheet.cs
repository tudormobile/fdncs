namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an international balance sheet statement for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#international_balance_sheet_statements
/// </remarks>
public record InternationalBalanceSheet
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
    /// Cash and cash equivalents.
    /// </summary>
    public decimal CashAndCashEquivalents { get; init; }

    /// <summary>
    /// Accounts receivable.
    /// </summary>
    public decimal AccountsReceivable { get; init; }

    /// <summary>
    /// Inventories.
    /// </summary>
    public decimal Inventories { get; init; }

    /// <summary>
    /// Other current assets.
    /// </summary>
    public decimal OtherAssetsCurrent { get; init; }

    /// <summary>
    /// Total current assets.
    /// </summary>
    public decimal TotalAssetsCurrent { get; init; }

    /// <summary>
    /// Property, plant, and equipment.
    /// </summary>
    public decimal PropertyPlantAndEquipment { get; init; }

    /// <summary>
    /// Other non-current assets.
    /// </summary>
    public decimal OtherAssetsNonCurrent { get; init; }

    /// <summary>
    /// Total non-current assets.
    /// </summary>
    public decimal TotalAssetsNonCurrent { get; init; }

    /// <summary>
    /// Total assets.
    /// </summary>
    public decimal TotalAssets { get; init; }

    /// <summary>
    /// Accounts payable.
    /// </summary>
    public decimal AccountsPayable { get; init; }

    /// <summary>
    /// Short-term debt.
    /// </summary>
    public decimal ShortTermDebt { get; init; }

    /// <summary>
    /// Other current liabilities.
    /// </summary>
    public decimal OtherLiabilitiesCurrent { get; init; }

    /// <summary>
    /// Total current liabilities.
    /// </summary>
    public decimal TotalLiabilitiesCurrent { get; init; }

    /// <summary>
    /// Long-term debt.
    /// </summary>
    public decimal LongTermDebt { get; init; }

    /// <summary>
    /// Other non-current liabilities.
    /// </summary>
    public decimal OtherLiabilitiesNonCurrent { get; init; }

    /// <summary>
    /// Total non-current liabilities.
    /// </summary>
    public decimal TotalLiabilitiesNonCurrent { get; init; }

    /// <summary>
    /// Total liabilities.
    /// </summary>
    public decimal TotalLiabilities { get; init; }

    /// <summary>
    /// Common stock.
    /// </summary>
    public decimal CommonStock { get; init; }

    /// <summary>
    /// Retained earnings.
    /// </summary>
    public decimal RetainedEarnings { get; init; }

    /// <summary>
    /// Total shareholders' equity.
    /// </summary>
    public decimal TotalShareholdersEquity { get; init; }
}
/* ref: https://financialdata.net/documentation#international_balance_sheet_statements
{
    "trading_symbol": "SHEL.L",
    "registrant_name": "Shell plc",
    "fiscal_period": "FY",
    "period_end_date": "2024-12-31",
    "currency_code": "USD",
    "cash_and_cash_equivalents": 37836000000.0,
    "accounts_receivable": 31041000000.0,
    "inventories": 23426000000.0,
    "other_assets_current": null,
    "total_assets_current": 127926000000.0,
    "property_plant_and_equipment": 185219000000.0,
    "other_assets_non_current": null,
    "total_assets_non_current": 259683000000.0,
    "total_assets": 387609000000.0,
    "accounts_payable": 29767000000.0,
    "short_term_debt": 6920000000.0,
    "other_liabilities_current": null,
    "total_liabilities_current": 95034000000.0,
    "long_term_debt": 41456000000.0,
    "other_liabilities_non_current": null,
    "total_liabilities_non_current": 112407000000.0,
    "total_liabilities": 207441000000.0,
    "common_stock": 178307000000.0,
    "retained_earnings": 158834000000.0,
    "total_shareholders_equity": 178307000000.0
}
*/
