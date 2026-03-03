namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents basic company information including LEI number, industry, contact information, and other key facts.
/// <para>See: https://financialdata.net/documentation#company_information</para>
/// </summary>
public record CompanyInformation
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the central index key (CIK) assigned by the SEC.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the ISIN (International Securities Identification Number).
    /// </summary>
    public string? IsinNumber { get; init; }

    /// <summary>
    /// Gets or sets the LEI (Legal Entity Identifier) number.
    /// </summary>
    public string? LeiNumber { get; init; }

    /// <summary>
    /// Gets or sets the EIN (Employer Identification Number).
    /// </summary>
    public string? EinNumber { get; init; }

    /// <summary>
    /// Gets or sets the stock exchange where the company is listed.
    /// </summary>
    public string? Exchange { get; init; }

    /// <summary>
    /// Gets or sets the SIC (Standard Industrial Classification) code.
    /// </summary>
    public string? SicCode { get; init; }

    /// <summary>
    /// Gets or sets the SIC description.
    /// </summary>
    public string? SicDescription { get; init; }

    /// <summary>
    /// Gets or sets the fiscal year end (MMDD format).
    /// </summary>
    public string? FiscalYearEnd { get; init; }

    /// <summary>
    /// Gets or sets the state of incorporation.
    /// </summary>
    public string? StateOfIncorporation { get; init; }

    /// <summary>
    /// Gets or sets the street address.
    /// </summary>
    public string? AddressStreet { get; init; }

    /// <summary>
    /// Gets or sets the city of the address.
    /// </summary>
    public string? AddressCity { get; init; }

    /// <summary>
    /// Gets or sets the state of the address.
    /// </summary>
    public string? AddressState { get; init; }

    /// <summary>
    /// Gets or sets the ZIP code of the address.
    /// </summary>
    public string? AddressZipCode { get; init; }

    /// <summary>
    /// Gets or sets the country of the address.
    /// </summary>
    public string? AddressCountry { get; init; }

    /// <summary>
    /// Gets or sets the country code of the address.
    /// </summary>
    public string? AddressCountryCode { get; init; }

    /// <summary>
    /// Gets or sets the phone number.
    /// </summary>
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Gets or sets the mailing address.
    /// </summary>
    public string? MailingAddress { get; init; }

    /// <summary>
    /// Gets or sets the business address.
    /// </summary>
    public string? BusinessAddress { get; init; }

    /// <summary>
    /// Gets or sets the former name of the company.
    /// </summary>
    public string? FormerName { get; init; }

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
    /// Gets or sets the market capitalization.
    /// </summary>
    public decimal MarketCap { get; init; }

    /// <summary>
    /// Gets or sets the number of shares issued.
    /// </summary>
    public decimal SharesIssued { get; init; }

    /// <summary>
    /// Gets or sets the number of shares outstanding.
    /// </summary>
    public decimal SharesOutstanding { get; init; }

    /// <summary>
    /// Gets or sets the company description.
    /// </summary>
    public string? Description { get; init; }
}
