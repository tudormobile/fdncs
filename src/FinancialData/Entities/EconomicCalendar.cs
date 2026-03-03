namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an upcoming economic event or indicator announcement on the economic calendar.
/// <para>See: https://financialdata.net/documentation#economic_calendar</para>
/// </summary>
public record EconomicCalendar
{
    /// <summary>
    /// Gets or sets the name of the economic event or indicator.
    /// </summary>
    public string? EventName { get; init; }

    /// <summary>
    /// Gets or sets the country of the event.
    /// </summary>
    public string? Country { get; init; }

    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    public string? CountryCode { get; init; }

    /// <summary>
    /// Gets or sets the time of the event (EST).
    /// </summary>
    public DateTime Time { get; init; }

    /// <summary>
    /// Gets or sets the previous indicator value.
    /// </summary>
    public decimal PreviousValue { get; init; }

    /// <summary>
    /// Gets or sets the actual indicator value.
    /// </summary>
    public decimal ActualValue { get; init; }
}
