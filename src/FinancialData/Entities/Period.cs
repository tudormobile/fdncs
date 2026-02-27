namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Financial reporting periods.
/// </summary>
public enum Period
{
    /// <summary>
    /// Represents all available data for the specified identifier, without any time-based filtering.
    /// </summary>
    All,
    /// <summary>
    /// Represents data from the most recent fiscal year, typically covering the last 12 months of financial activity.
    /// </summary>
    Year,
    /// <summary>
    /// Represents data from the most recent fiscal quarter, typically covering a three-month period of financial activity.
    /// </summary>
    Quarter,
}
