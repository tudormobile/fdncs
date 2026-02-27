namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a cash flow statement for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#cash_flow_statements
/// </remarks>
public record CashFlow
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
    /// Depreciation and amortization expense.
    /// </summary>
    public decimal DepreciationAndAmortization { get; init; }

    /// <summary>
    /// Share-based compensation expense.
    /// </summary>
    public decimal ShareBasedCompensationExpense { get; init; }

    /// <summary>
    /// Deferred income tax expense.
    /// </summary>
    public decimal DeferredIncomeTaxExpense { get; init; }

    /// <summary>
    /// Other non-cash income/expense.
    /// </summary>
    public decimal OtherNonCashIncomeExpense { get; init; }

    /// <summary>
    /// Change in accounts receivable.
    /// </summary>
    public decimal ChangeInAccountsReceivable { get; init; }

    /// <summary>
    /// Change in inventories.
    /// </summary>
    public decimal ChangeInInventories { get; init; }

    /// <summary>
    /// Change in non-trade receivables.
    /// </summary>
    public decimal ChangeInNonTradeReceivables { get; init; }

    /// <summary>
    /// Change in other assets.
    /// </summary>
    public decimal ChangeInOtherAssets { get; init; }

    /// <summary>
    /// Change in accounts payable.
    /// </summary>
    public decimal ChangeInAccountsPayable { get; init; }

    /// <summary>
    /// Change in deferred revenue.
    /// </summary>
    public decimal ChangeInDeferredRevenue { get; init; }

    /// <summary>
    /// Change in other liabilities.
    /// </summary>
    public decimal ChangeInOtherLiabilities { get; init; }

    /// <summary>
    /// Cash from operating activities.
    /// </summary>
    public decimal CashFromOperatingActivities { get; init; }

    /// <summary>
    /// Purchases of marketable securities.
    /// </summary>
    public decimal PurchasesOfMarketableSecurities { get; init; }

    /// <summary>
    /// Sales of marketable securities.
    /// </summary>
    public decimal SalesOfMarketableSecurities { get; init; }

    /// <summary>
    /// Acquisition of property, plant, and equipment.
    /// </summary>
    public decimal AcquisitionOfPropertyPlantAndEquipment { get; init; }

    /// <summary>
    /// Acquisition of business.
    /// </summary>
    public decimal AcquisitionOfBusiness { get; init; }

    /// <summary>
    /// Other investing activities.
    /// </summary>
    public decimal OtherInvestingActivities { get; init; }

    /// <summary>
    /// Cash from investing activities.
    /// </summary>
    public decimal CashFromInvestingActivities { get; init; }

    /// <summary>
    /// Tax withholding for share-based compensation.
    /// </summary>
    public decimal TaxWithholdingForShareBasedCompensation { get; init; }

    /// <summary>
    /// Payments of dividends.
    /// </summary>
    public decimal PaymentsOfDividends { get; init; }

    /// <summary>
    /// Issuance of common stock.
    /// </summary>
    public decimal IssuanceOfCommonStock { get; init; }

    /// <summary>
    /// Repurchase of common stock.
    /// </summary>
    public decimal RepurchaseOfCommonStock { get; init; }

    /// <summary>
    /// Issuance of long-term debt.
    /// </summary>
    public decimal IssuanceOfLongTermDebt { get; init; }

    /// <summary>
    /// Repayment of long-term debt.
    /// </summary>
    public decimal RepaymentOfLongTermDebt { get; init; }

    /// <summary>
    /// Other financing activities.
    /// </summary>
    public decimal OtherFinancingActivities { get; init; }

    /// <summary>
    /// Cash from financing activities.
    /// </summary>
    public decimal CashFromFinancingActivities { get; init; }

    /// <summary>
    /// Change in cash during the period.
    /// </summary>
    public decimal ChangeInCash { get; init; }

    /// <summary>
    /// Cash at end of period.
    /// </summary>
    public decimal CashAtEndOfPeriod { get; init; }

    /// <summary>
    /// Income taxes paid during the period.
    /// </summary>
    public decimal IncomeTaxesPaid { get; init; }

    /// <summary>
    /// Interest paid during the period.
    /// </summary>
    public decimal InterestPaid { get; init; }
}
/* ref: https://financialdata.net/documentation#cash_flow_statements
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "depreciation_and_amortization": 22287000000.0,
    "share_based_compensation_expense": 10734000000.0,
    "deferred_income_tax_expense": -4738000000.0,
    "other_non_cash_income_expense": null,
    "change_in_accounts_receivable": 7191000000.0,
    "change_in_inventories": -1284000000.0,
    "change_in_non_trade_receivables": null,
    "change_in_other_assets": null,
    "change_in_accounts_payable": 3545000000.0,
    "change_in_deferred_revenue": 5348000000.0,
    "change_in_other_liabilities": null,
    "cash_from_operating_activities": 118548000000.0,
    "purchases_of_marketable_securities": 17732000000.0,
    "sales_of_marketable_securities": 24775000000.0,
    "acquisition_of_property_plant_and_equipment": 44477000000.0,
    "acquisition_of_business": null,
    "other_investing_activities": 1298000000.0,
    "cash_from_investing_activities": -96970000000.0,
    "tax_withholding_for_share_based_compensation": 5300000000.0,
    "payments_of_dividends": 22296000000.0,
    "issuance_of_common_stock": 2002000000.0,
    "repurchase_of_common_stock": 17254000000.0,
    "issuance_of_long_term_debt": null,
    "repayment_of_long_term_debt": null,
    "other_financing_activities": -1309000000.0,
    "cash_from_financing_activities": -37757000000.0,
    "change_in_cash": -16389000000.0,
    "cash_at_end_of_period": 90143000000.0,
    "income_taxes_paid": 23400000000.0,
    "interest_paid": 1700000000.0
  }
*/
