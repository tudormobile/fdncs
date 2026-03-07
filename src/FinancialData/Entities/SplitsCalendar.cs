namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an upcoming stock split on the splits calendar.
/// <para>See: https://financialdata.net/documentation#splits_calendar</para>
/// </summary>
public record SplitsCalendar
{
    /// <summary>
    /// Gets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets the execution date of the stock split.
    /// </summary>
    public DateOnly ExecutionDate { get; init; }

    /// <summary>
    /// Gets the split multiplier (e.g., 1.5 for 3-for-2 split).
    /// </summary>
    public decimal Multiplier { get; init; }
}
/* ref:
{
    "trading_symbol": "LINK",
    "registrant_name": "INTERLINK ELECTRONICS INC",
    "execution_date": "2025-10-29",
    "multiplier": 1.5
  }
*/
