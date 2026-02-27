namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an international cash flow statement for a security.
/// </summary>
/// <remarks>
/// See: international_cash_flow_statements
/// </remarks>
public record InternationalCashFlow
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
    /// Depreciation and amortization expense.
    /// </summary>
    public decimal DepreciationAndAmortization { get; init; }

    /// <summary>
    /// Share-based compensation expense.
    /// </summary>
    public decimal ShareBasedCompensationExpense { get; init; }

    /// <summary>
    /// Change in accounts receivable.
    /// </summary>
    public decimal ChangeInAccountsReceivable { get; init; }

    /// <summary>
    /// Change in inventories.
    /// </summary>
    public decimal ChangeInInventories { get; init; }

    /// <summary>
    /// Change in other assets.
    /// </summary>
    public decimal ChangeInOtherAssets { get; init; }

    /// <summary>
    /// Change in accounts payable.
    /// </summary>
    public decimal ChangeInAccountsPayable { get; init; }

    /// <summary>
    /// Change in other liabilities.
    /// </summary>
    public decimal ChangeInOtherLiabilities { get; init; }

    /// <summary>
    /// Cash from operating activities.
    /// </summary>
    public decimal CashFromOperatingActivities { get; init; }

    /// <summary>
    /// Acquisition of property, plant, and equipment.
    /// </summary>
    public decimal AcquisitionOfPropertyPlantAndEquipment { get; init; }

    /// <summary>
    /// Acquisition of business.
    /// </summary>
    public decimal AcquisitionOfBusiness { get; init; }

    /// <summary>
    /// Cash from investing activities.
    /// </summary>
    public decimal CashFromInvestingActivities { get; init; }

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
}
/* ref: international_cash_flow_statements
{
    "trading_symbol": "SHEL.L",
    "registrant_name": "Shell plc",
    "fiscal_period": "FY",
    "period_end_date": "2024-12-31",
    "currency_code": "USD",
    "depreciation_and_amortization": 22703000000.0,
    "share_based_compensation_expense": null,
    "change_in_accounts_receivable": null,
    "change_in_inventories": 1273000000.0,
    "change_in_other_assets": null,
    "change_in_accounts_payable": null,
    "change_in_other_liabilities": null,
    "cash_from_operating_activities": 54687000000.0,
    "acquisition_of_property_plant_and_equipment": null,
    "acquisition_of_business": -1404000000.0,
    "cash_from_investing_activities": -15155000000.0,
    "payments_of_dividends": -8668000000.0,
    "issuance_of_common_stock": null,
    "repurchase_of_common_stock": -14687000000.0,
    "issuance_of_long_term_debt": 363000000.0,
    "repayment_of_long_term_debt": -9672000000.0,
    "cash_from_financing_activities": -38435000000.0,
    "change_in_cash": 1097000000.0,
    "cash_at_end_of_period": 39110000000.0
  }
*/