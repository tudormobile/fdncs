namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents detailed information about a cryptocurrency including website, description, and founding information.
/// <para>See: https://financialdata.net/documentation#crypto_information</para>
/// </summary>
public record CryptoInformation
{
    /// <summary>
    /// Gets or sets the trading symbol of the cryptocurrency.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the full name of the cryptocurrency.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Gets or sets the website URL.
    /// </summary>
    public string? Website { get; init; }

    /// <summary>
    /// Gets or sets the description of the cryptocurrency.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Gets or sets the founding date.
    /// </summary>
    public string? FoundingDate { get; init; }

    /// <summary>
    /// Gets or sets the name of the founder(s).
    /// </summary>
    public string? Founder { get; init; }
}
