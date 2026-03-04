namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents an option contract in an option chain, including expiration date, strike price, and contract type.
/// <para>See: https://financialdata.net/documentation#option_chain</para>
/// </summary>
public record OptionChain
{
    /// <summary>
    /// Gets the trading symbol of the underlying security.
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
    /// Gets the option contract name.
    /// </summary>
    public string? ContractName { get; init; }

    /// <summary>
    /// Gets the expiration date of the option.
    /// </summary>
    public DateOnly ExpirationDate { get; init; }

    /// <summary>
    /// Gets whether the option is a Put or Call.
    /// </summary>
    public string? PutOrCall { get; init; }

    /// <summary>
    /// Gets the strike price.
    /// </summary>
    public decimal StrikePrice { get; init; }
}
