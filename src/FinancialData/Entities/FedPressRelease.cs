namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a Federal Reserve press release with headline, date, and content.
/// <para>See: https://financialdata.net/documentation#fed_press_releases</para>
/// </summary>
public record FedPressRelease
{
    /// <summary>
    /// Gets or sets the date and time of the Federal Reserve press release.
    /// </summary>
    public DateTime DateTime { get; init; }

    /// <summary>
    /// Gets or sets the headline of the press release.
    /// </summary>
    public string? Headline { get; init; }

    /// <summary>
    /// Gets or sets the full text content of the press release.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    /// Gets or sets the URL to the press release.
    /// </summary>
    public string? Url { get; init; }
}
