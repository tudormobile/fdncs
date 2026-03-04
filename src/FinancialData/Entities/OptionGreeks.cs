namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents option Greeks (Delta, Gamma, Theta, Vega, Rho) for an option contract.
/// <para>See: https://financialdata.net/documentation#option_greeks</para>
/// </summary>
public record OptionGreeks
{
    /// <summary>
    /// Gets the option contract name.
    /// </summary>
    public string? ContractName { get; init; }

    /// <summary>
    /// Gets the date of the Greeks values.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the Delta value.
    /// </summary>
    public decimal Delta { get; init; }

    /// <summary>
    /// Gets the Gamma value.
    /// </summary>
    public decimal Gamma { get; init; }

    /// <summary>
    /// Gets the Theta value.
    /// </summary>
    public decimal Theta { get; init; }

    /// <summary>
    /// Gets the Vega value.
    /// </summary>
    public decimal Vega { get; init; }

    /// <summary>
    /// Gets the Rho value.
    /// </summary>
    public decimal Rho { get; init; }
}
