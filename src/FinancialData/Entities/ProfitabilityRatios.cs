namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents profitability ratios and related financial metrics for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#profitability_ratios
/// </remarks>
public record ProfitabilityRatios
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
    /// Earnings before interest and taxes (EBIT).
    /// </summary>
    public decimal EBIT { get; init; }

    /// <summary>
    /// Earnings before interest, taxes, depreciation, and amortization (EBITDA).
    /// </summary>
    public decimal EBITDA { get; init; }

    /// <summary>
    /// Profit margin for the period.
    /// </summary>
    public decimal ProfitMargin { get; init; }

    /// <summary>
    /// Gross margin for the period.
    /// </summary>
    public decimal GrossMargin { get; init; }

    /// <summary>
    /// Operating margin for the period.
    /// </summary>
    public decimal OperatingMargin { get; init; }

    /// <summary>
    /// Operating cash flow margin for the period.
    /// </summary>
    public decimal OperatingCashFlowMargin { get; init; }

    /// <summary>
    /// Return on equity for the period.
    /// </summary>
    public decimal ReturnOnEquity { get; init; }

    /// <summary>
    /// Return on assets for the period.
    /// </summary>
    public decimal ReturnOnAssets { get; init; }

    /// <summary>
    /// Return on debt for the period.
    /// </summary>
    public decimal ReturnOnDebt { get; init; }

    /// <summary>
    /// Cash return on assets for the period.
    /// </summary>
    public decimal CashReturnOnAssets { get; init; }

    /// <summary>
    /// Cash turnover ratio for the period.
    /// </summary>
    public decimal CashTurnoverRatio { get; init; }
}
/* https://financialdata.net/documentation#profitability_ratios
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "ebit": 114471000000.0,
    "ebitda": 136758000000.0,
    "profit_margin": 0.35955972944085,
    "gross_margin": 0.697644438279714,
    "operating_margin": 0.446442995732737,
    "operating_cash_flow_margin": 0.483628560471928,
    "return_on_equity": 0.328281379782998,
    "return_on_assets": 0.172085839859576,
    "return_on_debt": 1.86784215657186,
    "cash_return_on_assets": 0.231465373328413,
    "cash_turnover_ratio": 2.71925718025803
  }
*/

