namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents valuation ratios and related financial metrics for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#valuation_ratios
/// </remarks>
public record ValuationRatios
{
    /// <summary>
    /// The trading symbol of the security (e.g., "MSFT").
    /// </summary>
    public string? TradingSymbol { get; set; }

    /// <summary>
    /// The central index key (CIK) for the registrant.
    /// </summary>
    public string? CentralIndexKey { get; set; }

    /// <summary>
    /// The name of the registrant.
    /// </summary>
    public string? RegistrantName { get; set; }

    /// <summary>
    /// The fiscal year for the reported ratios.
    /// </summary>
    public string? FiscalYear { get; set; }

    /// <summary>
    /// The fiscal period (e.g., "FY" for full year).
    /// </summary>
    public string? FiscalPeriod { get; set; }

    /// <summary>
    /// The end date of the reporting period (format: yyyy-MM-dd).
    /// </summary>
    public DateOnly PeriodEndDate { get; set; }

    /// <summary>
    /// Dividends paid per share during the period.
    /// </summary>
    public decimal DividendsPerShare { get; set; }

    /// <summary>
    /// The dividend payout ratio for the period.
    /// </summary>
    public decimal DividendPayoutRatio { get; set; }

    /// <summary>
    /// Book value per share at period end.
    /// </summary>
    public decimal BookValuePerShare { get; set; }

    /// <summary>
    /// The retention ratio for the period.
    /// </summary>
    public decimal RetentionRatio { get; set; }

    /// <summary>
    /// Net fixed assets at period end.
    /// </summary>
    public decimal NetFixedAssets { get; set; }
}

/* ref: https://financialdata.net/documentation#valuation_ratios
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "fiscal_period": "FY",
    "period_end_date": "2024-06-30",
    "dividends_per_share": 3.00040371417037,
    "dividend_payout_ratio": 0.252985136102055,
    "book_value_per_share": 36.1293231059077,
    "retention_ratio": 0.747027321412363,
    "net_fixed_assets": 113304000000.0
  }*/