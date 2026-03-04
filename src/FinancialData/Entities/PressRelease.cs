namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a company press release with headline, date, and content.
/// <para>See: https://financialdata.net/documentation#press_releases</para>
/// </summary>
public record PressRelease
{
    /// <summary>
    /// Gets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the central index key (CIK) assigned by the SEC.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets the date and time of the press release.
    /// </summary>
    public DateTime DateTime { get; init; }

    /// <summary>
    /// Gets the headline of the press release.
    /// </summary>
    public string? Headline { get; init; }

    /// <summary>
    /// Gets the full text content of the press release.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    /// Gets the URL to the press release.
    /// </summary>
    public string? Url { get; init; }
}
