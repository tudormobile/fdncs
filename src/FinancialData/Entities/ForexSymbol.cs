namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a forex currency pair symbol.
/// <para>See: https://financialdata.net/documentation#forex_symbols</para>
/// </summary>
public record ForexSymbol
{
    /// <summary>
    /// Gets or sets the trading symbol of the forex pair.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the full name of the forex pair.
    /// </summary>
    public string? Name { get; init; }
}
