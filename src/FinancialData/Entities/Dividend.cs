namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents dividend information including type, amount, and key dates.
/// <para>See: https://financialdata.net/documentation#dividends</para>
/// </summary>
public record Dividend
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
    /// Gets or sets the type of dividend (e.g., "Cash").
    /// </summary>
    public string? Type { get; init; }

    /// <summary>
    /// Gets or sets the dividend amount per share.
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Gets or sets the declaration date.
    /// </summary>
    public DateOnly DeclarationDate { get; init; }

    /// <summary>
    /// Gets or sets the ex-dividend date.
    /// </summary>
    public DateOnly ExDate { get; init; }

    /// <summary>
    /// Gets or sets the record date.
    /// </summary>
    public DateOnly RecordDate { get; init; }

    /// <summary>
    /// Gets or sets the payment date.
    /// </summary>
    public DateOnly PaymentDate { get; init; }
}
