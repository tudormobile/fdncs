namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents basic information about an international company.
/// <para>See: https://financialdata.net/documentation#international_company_information</para>
/// </summary>
public record InternationalCompanyInformation
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
    /// Gets or sets the stock exchange where the company is listed.
    /// </summary>
    public string? Exchange { get; init; }

    /// <summary>
    /// Gets or sets the ISIN (International Securities Identification Number).
    /// </summary>
    public string? IsinNumber { get; init; }

    /// <summary>
    /// Gets or sets the industry classification.
    /// </summary>
    public string? Industry { get; init; }

    /// <summary>
    /// Gets or sets the founding date.
    /// </summary>
    public string? FoundingDate { get; init; }

    /// <summary>
    /// Gets or sets the name of the chief executive officer.
    /// </summary>
    public string? ChiefExecutiveOfficer { get; init; }

    /// <summary>
    /// Gets or sets the number of employees.
    /// </summary>
    public int NumberOfEmployees { get; init; }

    /// <summary>
    /// Gets or sets the company website URL.
    /// </summary>
    public string? Website { get; init; }

    /// <summary>
    /// Gets or sets the company description.
    /// </summary>
    public string? Description { get; init; }
}
