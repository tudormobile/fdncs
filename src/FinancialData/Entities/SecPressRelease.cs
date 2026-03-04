namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an SEC press release with headline, date, and content.
/// <para>See: https://financialdata.net/documentation#sec_press_releases</para>
/// </summary>
public record SecPressRelease
{
    /// <summary>
    /// Gets the date and time of the SEC press release.
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
