namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents executive compensation data including salary, bonus, stock awards, and total compensation.
/// <para>See: https://financialdata.net/documentation#executive_compensation</para>
/// </summary>
public record ExecutiveCompensation
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
    /// Gets or sets the name of the executive.
    /// </summary>
    public string? ExecutiveName { get; init; }

    /// <summary>
    /// Gets or sets the position of the executive.
    /// </summary>
    public string? ExecutivePosition { get; init; }

    /// <summary>
    /// Gets or sets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets or sets the base salary.
    /// </summary>
    public decimal Salary { get; init; }

    /// <summary>
    /// Gets or sets the bonus amount.
    /// </summary>
    public decimal Bonus { get; init; }

    /// <summary>
    /// Gets or sets the value of stock awards.
    /// </summary>
    public decimal StockAwards { get; init; }

    /// <summary>
    /// Gets or sets the incentive plan compensation.
    /// </summary>
    public decimal IncentivePlanCompensation { get; init; }

    /// <summary>
    /// Gets or sets other compensation.
    /// </summary>
    public decimal OtherCompensation { get; init; }

    /// <summary>
    /// Gets or sets the total compensation.
    /// </summary>
    public decimal TotalCompensation { get; init; }
}
