namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents OTC (Over-the-Counter) trading volume data for a security.
/// </summary>
/// <remarks>
/// See: https://financialdata.net/documentation#OTC_volume
/// </remarks>
public record OtcVolume
{
    /// <summary>
    /// The trading symbol of the security (e.g., "AABB").
    /// </summary>
    public string? TradingSymbol { get; set; }

    /// <summary>
    /// The full title of the security (e.g., "Asia Broadband Inc Common Stock").
    /// </summary>
    public string? TitleOfSecurity { get; set; }

    /// <summary>
    /// The start date of the month for the reported volume (format: yyyy-MM-dd).
    /// </summary>
    public DateOnly MonthStartDate { get; set; }

    /// <summary>
    /// The total trading volume for the current month.
    /// </summary>
    public long MonthlyVolume { get; set; }

    /// <summary>
    /// The total trading volume for the previous month.
    /// </summary>
    public long PreviousMonthlyVolume { get; set; }

    /// <summary>
    /// The total trading volume year-to-date.
    /// </summary>
    public long VolumeYearToDate { get; set; }
}

/* Ref: https://financialdata.net/documentation#OTC_volume
{
    "trading_symbol": "AABB",
    "title_of_security": "Asia Broadband Inc Common Stock",
    "month_start_date": "2024-10-01",
    "monthly_volume": 140366022,
    "previous_monthly_volume": 263720143,
    "volume_year_to_date": 2237440816
}
*/
