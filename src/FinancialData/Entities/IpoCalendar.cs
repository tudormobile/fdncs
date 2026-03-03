namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an upcoming initial public offering on the IPO calendar.
/// <para>See: https://financialdata.net/documentation#ipo_calendar</para>
/// </summary>
public record IpoCalendar
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the stock exchange.
    /// </summary>
    public string? Exchange { get; init; }

    /// <summary>
    /// Gets or sets the pricing date of the IPO.
    /// </summary>
    public DateOnly PricingDate { get; init; }

    /// <summary>
    /// Gets or sets the share price.
    /// </summary>
    public decimal SharePrice { get; init; }

    /// <summary>
    /// Gets or sets the number of shares offered.
    /// </summary>
    public decimal SharesOffered { get; init; }

    /// <summary>
    /// Gets or sets the total offering value.
    /// </summary>
    public decimal OfferingValue { get; init; }
}
