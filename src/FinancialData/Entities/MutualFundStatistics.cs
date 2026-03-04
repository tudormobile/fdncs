namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a collection of key financial and performance statistics for a mutual fund over a specified reporting
/// period.
/// </summary>
public record MutualFundStatistics
{
    /// <summary>
    /// Gets the unique central index key for the mutual fund.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets the name of the registrant (fund family or provider).
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets the period of report (end date of the reporting period).
    /// </summary>
    public DateOnly? PeriodOfReport { get; init; }

    /// <summary>
    /// Gets the name of the mutual fund.
    /// </summary>
    public string? FundName { get; init; }

    /// <summary>
    /// Gets the symbol of the mutual fund.
    /// </summary>
    public string? FundSymbol { get; init; }

    /// <summary>
    /// Gets the series ID of the mutual fund.
    /// </summary>
    public string? SeriesId { get; init; }

    /// <summary>
    /// Gets the class ID of the mutual fund.
    /// </summary>
    public string? ClassId { get; init; }

    /// <summary>
    /// Gets the total assets of the mutual fund.
    /// </summary>
    public decimal TotalAssets { get; init; }

    /// <summary>
    /// Gets the total liabilities of the mutual fund.
    /// </summary>
    public decimal TotalLiabilities { get; init; }

    /// <summary>
    /// Gets the net assets of the mutual fund.
    /// </summary>
    public decimal NetAssets { get; init; }

    /// <summary>
    /// Gets the return for the preceding month 1 (as a percentage).
    /// </summary>
    public decimal ReturnPrecedingMonth1 { get; init; }

    /// <summary>
    /// Gets the return for the preceding month 2 (as a percentage).
    /// </summary>
    public decimal ReturnPrecedingMonth2 { get; init; }

    /// <summary>
    /// Gets the return for the preceding month 3 (as a percentage).
    /// </summary>
    public decimal ReturnPrecedingMonth3 { get; init; }

    /// <summary>
    /// Gets the realized gain for the preceding month 1.
    /// </summary>
    public decimal RealizedGainPrecedingMonth1 { get; init; }

    /// <summary>
    /// Gets the change in unrealized appreciation for the preceding month 1.
    /// </summary>
    public decimal ChangeInUnrealizedAppreciationPrecedingMonth1 { get; init; }

    /// <summary>
    /// Gets the realized gain for the preceding month 2.
    /// </summary>
    public decimal RealizedGainPrecedingMonth2 { get; init; }

    /// <summary>
    /// Gets the change in unrealized appreciation for the preceding month 2.
    /// </summary>
    public decimal ChangeInUnrealizedAppreciationPrecedingMonth2 { get; init; }

    /// <summary>
    /// Gets the realized gain for the preceding month 3.
    /// </summary>
    public decimal RealizedGainPrecedingMonth3 { get; init; }

    /// <summary>
    /// Gets the change in unrealized appreciation for the preceding month 3.
    /// </summary>
    public decimal ChangeInUnrealizedAppreciationPrecedingMonth3 { get; init; }

    /// <summary>
    /// Gets the share sale amount for the preceding month 1.
    /// </summary>
    public decimal ShareSalePrecedingMonth1 { get; init; }

    /// <summary>
    /// Gets the share redemption amount for the preceding month 1.
    /// </summary>
    public decimal ShareRedemptionPrecedingMonth1 { get; init; }

    /// <summary>
    /// Gets the share sale amount for the preceding month 2.
    /// </summary>
    public decimal ShareSalePrecedingMonth2 { get; init; }

    /// <summary>
    /// Gets the share redemption amount for the preceding month 2.
    /// </summary>
    public decimal ShareRedemptionPrecedingMonth2 { get; init; }

    /// <summary>
    /// Gets the share sale amount for the preceding month 3.
    /// </summary>
    public decimal ShareSalePrecedingMonth3 { get; init; }

    /// <summary>
    /// Gets the share redemption amount for the preceding month 3.
    /// </summary>
    public decimal ShareRedemptionPrecedingMonth3 { get; init; }
}

/* ref: https://financialdata.net/documentation#mutual_fund_statistics
{
    "central_index_key": "0000036405",
    "registrant_name": "VANGUARD INDEX FUNDS",
    "period_of_report": "2025-06-30",
    "fund_name": "Admiral Shares",
    "fund_symbol": "VTSAX",
    "series_id": "S000002848",
    "class_id": "C000007806",
    "total_assets": 1915212703487.01,
    "total_liabilities": 5763123365.99,
    "net_assets": 1909449580121.02,
    "return_preceding_month1": -0.6729,
    "return_preceding_month2": 6.3455,
    "return_preceding_month3": 5.07574,
    "realized_gain_preceding_month1": 983065935.64,
    "change_in_unrealized_appreciation_preceding_month1": -11394591977.19,
    "realized_gain_preceding_month2": 287029511.93,
    "change_in_unrealized_appreciation_preceding_month2": 105734824564.66,
    "realized_gain_preceding_month3": 2243886605.76,
    "change_in_unrealized_appreciation_preceding_month3": 87596494350.2,
    "share_sale_preceding_month1": 30533447572.6504,
    "share_redemption_preceding_month1": 9354960674.63,
    "share_sale_preceding_month2": 9024030148.45996,
    "share_redemption_preceding_month2": 9833704993.95,
    "share_sale_preceding_month3": 12681244786.0796,
    "share_redemption_preceding_month3": 12999259996.1
}
*/
