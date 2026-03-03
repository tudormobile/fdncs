namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents detailed information about an investment adviser including assets under management, employees, and clients.
/// <para>See: https://financialdata.net/documentation#investment_adviser_information</para>
/// </summary>
public record InvestmentAdviserInformation
{
    /// <summary>
    /// Gets or sets the CRD (Central Registration Depository) number.
    /// </summary>
    public string? CrdNumber { get; init; }

    /// <summary>
    /// Gets or sets the SEC file number.
    /// </summary>
    public string? SecFileNumber { get; init; }

    /// <summary>
    /// Gets or sets the firm name of the investment adviser.
    /// </summary>
    public string? FirmName { get; init; }

    /// <summary>
    /// Gets or sets the filing date with the SEC.
    /// </summary>
    public DateOnly FilingDate { get; init; }

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
    /// Gets or sets the phone number.
    /// </summary>
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Gets or sets the website URL.
    /// </summary>
    public string? Website { get; init; }

    /// <summary>
    /// Gets or sets the total assets under management.
    /// </summary>
    public decimal AssetsUnderManagement { get; init; }

    /// <summary>
    /// Gets or sets the number of employees.
    /// </summary>
    public int NumberOfEmployees { get; init; }

    /// <summary>
    /// Gets or sets the number of clients.
    /// </summary>
    public int NumberOfClients { get; init; }

    /// <summary>
    /// Gets or sets the number of high net worth individual clients.
    /// </summary>
    public int HighNetWorthClients { get; init; }

    /// <summary>
    /// Gets or sets whether the adviser is a registered investment company.
    /// </summary>
    public bool IsRegisteredInvestmentCompany { get; init; }

    /// <summary>
    /// Gets or sets whether the adviser is a private fund.
    /// </summary>
    public bool IsPrivateFund { get; init; }
}
