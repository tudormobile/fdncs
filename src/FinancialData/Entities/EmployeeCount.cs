namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents the total number of employees for a company in a particular year.
/// <para>See: https://financialdata.net/documentation#employee_count</para>
/// </summary>
public record EmployeeCount
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
    /// Gets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets the number of employees.
    /// </summary>
    public int Count { get; init; }
}
