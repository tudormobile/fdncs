namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents basic company information including LEI number, industry, contact information, and other key facts.
/// <para>See: https://financialdata.net/documentation#company_information</para>
/// </summary>
public record CompanyInformation
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
    /// Gets the ISIN (International Securities Identification Number).
    /// </summary>
    public string? IsinNumber { get; init; }

    /// <summary>
    /// Gets the LEI (Legal Entity Identifier) number.
    /// </summary>
    public string? LeiNumber { get; init; }

    /// <summary>
    /// Gets the EIN (Employer Identification Number).
    /// </summary>
    public string? EinNumber { get; init; }

    /// <summary>
    /// Gets the stock exchange where the company is listed.
    /// </summary>
    public string? Exchange { get; init; }

    /// <summary>
    /// Gets the SIC (Standard Industrial Classification) code.
    /// </summary>
    public string? SicCode { get; init; }

    /// <summary>
    /// Gets the SIC description.
    /// </summary>
    public string? SicDescription { get; init; }

    /// <summary>
    /// Gets the fiscal year end (MMDD format).
    /// </summary>
    public string? FiscalYearEnd { get; init; }

    /// <summary>
    /// Gets the state of incorporation.
    /// </summary>
    public string? StateOfIncorporation { get; init; }

    /// <summary>
    /// Gets the street address.
    /// </summary>
    public string? AddressStreet { get; init; }

    /// <summary>
    /// Gets the city of the address.
    /// </summary>
    public string? AddressCity { get; init; }

    /// <summary>
    /// Gets the state of the address.
    /// </summary>
    public string? AddressState { get; init; }

    /// <summary>
    /// Gets the ZIP code of the address.
    /// </summary>
    public string? AddressZipCode { get; init; }

    /// <summary>
    /// Gets the country of the address.
    /// </summary>
    public string? AddressCountry { get; init; }

    /// <summary>
    /// Gets the country code of the address.
    /// </summary>
    public string? AddressCountryCode { get; init; }

    /// <summary>
    /// Gets the phone number.
    /// </summary>
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Gets the mailing address.
    /// </summary>
    public string? MailingAddress { get; init; }

    /// <summary>
    /// Gets the business address.
    /// </summary>
    public string? BusinessAddress { get; init; }

    /// <summary>
    /// Gets the former name of the company.
    /// </summary>
    public string? FormerName { get; init; }

    /// <summary>
    /// Gets the industry classification.
    /// </summary>
    public string? Industry { get; init; }

    /// <summary>
    /// Gets the founding date.
    /// </summary>
    public string? FoundingDate { get; init; }

    /// <summary>
    /// Gets the name of the chief executive officer.
    /// </summary>
    public string? ChiefExecutiveOfficer { get; init; }

    /// <summary>
    /// Gets the number of employees.
    /// </summary>
    public int NumberOfEmployees { get; init; }

    /// <summary>
    /// Gets the company website URL.
    /// </summary>
    public string? Website { get; init; }

    /// <summary>
    /// Gets the market capitalization.
    /// </summary>
    public decimal MarketCap { get; init; }

    /// <summary>
    /// Gets the number of shares issued.
    /// </summary>
    public decimal SharesIssued { get; init; }

    /// <summary>
    /// Gets the number of shares outstanding.
    /// </summary>
    public decimal SharesOutstanding { get; init; }

    /// <summary>
    /// Gets the company description.
    /// </summary>
    public string? Description { get; init; }
}

/*
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "isin_number": "US5949181045",
    "lei_number": null,
    "ein_number": "911144442",
    "exchange": "Nasdaq",
    "sic_code": "7372",
    "sic_description": "Services-Prepackaged Software",
    "fiscal_year_end": "0630",
    "state_of_incorporation": "WA",
    "address_street": "ONE MICROSOFT WAY",
    "address_city": "REDMOND",
    "address_state": "WA",
    "address_zip_code": "98052-6399",
    "address_country": "UNITED STATES",
    "address_country_code": "US",
    "phone_number": "425-882-8080",
    "mailing_address": "ONE MICROSOFT WAY, REDMOND, WA, 98052-6399",
    "business_address": "ONE MICROSOFT WAY, REDMOND, WA, 98052-6399",
    "former_name": null,
    "industry": "Information technology",
    "founding_date": "1975-04-04",
    "chief_executive_officer": "Satya Nadella",
    "number_of_employees": 228000,
    "website": "https://www.microsoft.com/",
    "market_cap": 2800000000000.0,
    "shares_issued": null,
    "shares_outstanding": 7434880776,
    "description": "Microsoft Corporation is an American multinational technology conglomerate headquartered in Redmond, Washington. Founded in 1975, the company became highly influential in the rise of personal computers through software like Windows, and the company has since expanded to Internet services, cloud computing, video gaming and other fields. Microsoft is the largest software maker, one of the most valuable public U.S. companies, and one of the most valuable brands globally."
  }
*/
