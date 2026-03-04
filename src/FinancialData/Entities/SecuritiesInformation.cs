namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents basic information about a security including its trading symbol, issuer, CUSIP, ISIN, FIGI, and security type.
/// <para>See: https://financialdata.net/documentation#securities_information</para>
/// </summary>
public record SecuritiesInformation
{
    /// <summary>
    /// Gets the trading symbol of the security.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the name of the issuer.
    /// </summary>
    public string? IssuerName { get; init; }

    /// <summary>
    /// Gets the CUSIP number.
    /// </summary>
    public string? CusipNumber { get; init; }

    /// <summary>
    /// Gets the ISIN number.
    /// </summary>
    public string? IsinNumber { get; init; }

    /// <summary>
    /// Gets the FIGI (Financial Instrument Global Identifier).
    /// </summary>
    public string? FigiIdentifier { get; init; }

    /// <summary>
    /// Gets the type of security.
    /// </summary>
    public string? SecurityType { get; init; }
}
