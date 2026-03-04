namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a futures contract symbol and its description and type.
/// <para>See: https://financialdata.net/documentation#futures_symbols</para>
/// </summary>
public record FuturesSymbol
{
    /// <summary>
    /// Gets the trading symbol of the futures contract.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the description of the futures contract.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Gets the type of futures contract (e.g., Interest Rates, Metals, Equities).
    /// </summary>
    public string? Type { get; init; }
}
