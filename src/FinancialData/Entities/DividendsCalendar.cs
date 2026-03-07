namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an upcoming dividend payment on the dividends calendar.
/// <para>See: https://financialdata.net/documentation#dividends_calendar</para>
/// </summary>
public record DividendsCalendar
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
    /// Gets the dividend amount per share.
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Gets the declaration date.
    /// </summary>
    public DateOnly DeclarationDate { get; init; }

    /// <summary>
    /// Gets the ex-dividend date.
    /// </summary>
    public DateOnly ExDate { get; init; }

    /// <summary>
    /// Gets the record date.
    /// </summary>
    public DateOnly RecordDate { get; init; }

    /// <summary>
    /// Gets the payment date.
    /// </summary>
    public DateOnly PaymentDate { get; init; }
}
/* ref: https://financialdata.net/documentation#dividends_calendar
{
    "trading_symbol": "APOG",
    "registrant_name": "APOGEE ENTERPRISES, INC.",
    "amount": 0.26,
    "declaration_date": "2025-10-09",
    "ex_date": "2025-10-29",
    "record_date": "2025-10-29",
    "payment_date": "2025-11-13"
  }
*/