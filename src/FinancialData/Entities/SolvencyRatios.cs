namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents solvency ratios and related financial metrics for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#solvency_ratios
/// </remarks>
public record SolvencyRatios
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
    /// The end date of the reporting period (format: yyyy-MM-dd).
    /// </summary>
    public DateOnly PeriodEndDate { get; init; }

    /// <summary>
    /// The equity ratio for the period.
    /// </summary>
    public decimal EquityRatio { get; init; }

    /// <summary>
    /// The debt coverage ratio for the period.
    /// </summary>
    public decimal DebtCoverageRatio { get; init; }

    /// <summary>
    /// The asset coverage ratio for the period.
    /// </summary>
    public decimal AssetCoverageRatio { get; init; }

    /// <summary>
    /// The interest coverage ratio for the period.
    /// </summary>
    public decimal InterestCoverageRatio { get; init; }

    /// <summary>
    /// The debt to equity ratio for the period.
    /// </summary>
    public decimal DebtToEquityRatio { get; init; }

    /// <summary>
    /// The debt to assets ratio for the period.
    /// </summary>
    public decimal DebtToAssetsRatio { get; init; }

    /// <summary>
    /// The debt to capital ratio for the period.
    /// </summary>
    public decimal DebtToCapitalRatio { get; init; }

    /// <summary>
    /// The debt to income ratio for the period.
    /// </summary>
    public decimal DebtToIncomeRatio { get; init; }

    /// <summary>
    /// The cash flow to debt ratio for the period.
    /// </summary>
    public decimal CashFlowToDebtRatio { get; init; }
}
/* ref: https://financialdata.net/documentation#solvency_ratios
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "equity_ratio": 0.524202255922431,
    "debt_coverage_ratio": null,
    "asset_coverage_ratio": 8.24664095282499,
    "interest_coverage_ratio": null,
    "debt_to_equity_ratio": 0.17575434767224,
    "debt_to_assets_ratio": 0.0921308255379635,
    "debt_to_capital_ratio": 0.149482200954816,
    "debt_to_income_ratio": null,
    "cash_flow_to_debt_ratio": 2.51235535964057
  }
*/