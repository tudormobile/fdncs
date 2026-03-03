namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a financial balance sheet that contains key financial data for a specific entity and reporting period.
/// </summary>
/// <remarks>The BalanceSheet record includes properties for common financial statement line items, such as
/// assets, liabilities, and shareholders' equity. Each property corresponds to a specific financial metric, enabling
/// detailed analysis of an entity's financial position at the end of a fiscal period. This type is typically used to
/// model and transfer balance sheet data within financial applications.</remarks>
public record BalanceSheet
{
    /// <summary>
    /// Gets or sets the trading symbol of the security.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the unique identifier for the central index associated with this balance sheet.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the registrant name.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets or sets the fiscal period associated with the financial data.
    /// </summary>
    public string? FiscalPeriod { get; init; }

    /// <summary>
    /// Gets or sets the period end date.
    /// </summary>
    public DateOnly PeriodEndDate { get; init; }

    /// <summary>
    /// Gets or sets cash and cash equivalents.
    /// </summary>
    public decimal CashAndCashEquivalents { get; init; }

    /// <summary>
    /// Gets or sets the value of marketable securities classified as current assets on the balance sheet.
    /// </summary>
    public decimal MarketableSecuritiesCurrent { get; init; }

    /// <summary>
    /// Gets or sets accounts receivable.
    /// </summary>
    public decimal AccountsReceivable { get; init; }

    /// <summary>
    /// Gets or sets inventories.
    /// </summary>
    public decimal Inventories { get; init; }

    /// <summary>
    /// Gets or sets non-trade receivables.
    /// </summary>
    public decimal NonTradeReceivables { get; init; }

    /// <summary>
    /// Gets or sets other current assets.
    /// </summary>
    public decimal OtherAssetsCurrent { get; init; }

    /// <summary>
    /// Gets or sets total current assets.
    /// </summary>
    public decimal TotalAssetsCurrent { get; init; }

    /// <summary>
    /// Gets or sets non-current marketable securities.
    /// </summary>
    public decimal MarketableSecuritiesNonCurrent { get; init; }

    /// <summary>
    /// Gets or sets property, plant, and equipment.
    /// </summary>
    public decimal PropertyPlantAndEquipment { get; init; }

    /// <summary>
    /// Gets or sets other non-current assets.
    /// </summary>
    public decimal OtherAssetsNonCurrent { get; init; }

    /// <summary>
    /// Gets or sets total non-current assets.
    /// </summary>
    public decimal TotalAssetsNonCurrent { get; init; }

    /// <summary>
    /// Gets or sets total assets.
    /// </summary>
    public decimal TotalAssets { get; init; }

    /// <summary>
    /// Gets or sets accounts payable.
    /// </summary>
    public decimal AccountsPayable { get; init; }

    /// <summary>
    /// Gets or sets deferred revenue.
    /// </summary>
    public decimal DeferredRevenue { get; init; }

    /// <summary>
    /// Gets or sets short-term debt.
    /// </summary>
    public decimal ShortTermDebt { get; init; }

    /// <summary>
    /// Gets or sets other current liabilities.
    /// </summary>
    public decimal OtherLiabilitiesCurrent { get; init; }

    /// <summary>
    /// Gets or sets total current liabilities.
    /// </summary>
    public decimal TotalLiabilitiesCurrent { get; init; }

    /// <summary>
    /// Gets or sets long-term debt.
    /// </summary>
    public decimal LongTermDebt { get; init; }

    /// <summary>
    /// Gets or sets other non-current liabilities.
    /// </summary>
    public decimal OtherLiabilitiesNonCurrent { get; init; }

    /// <summary>
    /// Gets or sets total non-current liabilities.
    /// </summary>
    public decimal TotalLiabilitiesNonCurrent { get; init; }

    /// <summary>
    /// Gets or sets total liabilities.
    /// </summary>
    public decimal TotalLiabilities { get; init; }

    /// <summary>
    /// Gets or sets common stock.
    /// </summary>
    public decimal CommonStock { get; init; }

    /// <summary>
    /// Gets or sets retained earnings.
    /// </summary>
    public decimal RetainedEarnings { get; init; }

    /// <summary>
    /// Gets or sets accumulated other comprehensive income.
    /// </summary>
    public decimal AccumulatedOtherComprehensiveIncome { get; init; }

    /// <summary>
    /// Gets or sets total shareholders' equity.
    /// </summary>
    public decimal TotalShareholdersEquity { get; init; }

}

/* Json: BalanceSheet. See https://financialdata.net/documentation#balance_sheet_statements
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "cash_and_cash_equivalents": 90143000000.0,
    "marketable_securities_current": 57228000000.0,
    "accounts_receivable": 56924000000.0,
    "inventories": 1246000000.0,
    "non_trade_receivables": null,
    "other_assets_current": 26021000000.0,
    "total_assets_current": 159734000000.0,
    "marketable_securities_non_current": 14600000000.0,
    "property_plant_and_equipment": 135591000000.0,
    "other_assets_non_current": 36460000000.0,
    "total_assets_non_current": 301369000000.0,
    "total_assets": 512163000000.0,
    "accounts_payable": 21996000000.0,
    "deferred_revenue": 57582000000.0,
    "short_term_debt": 2249000000.0,
    "other_liabilities_current": 19185000000.0,
    "total_liabilities_current": 125286000000.0,
    "long_term_debt": 44937000000.0,
    "other_liabilities_non_current": 27064000000.0,
    "total_liabilities_non_current": 118400000000.0,
    "total_liabilities": 243686000000.0,
    "common_stock": 100923000000.0,
    "retained_earnings": 173144000000.0,
    "accumulated_other_comprehensive_income": -5590000000.0,
    "total_shareholders_equity": 268477000000.0
}
*/
