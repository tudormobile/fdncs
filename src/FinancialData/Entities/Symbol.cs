namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a trading symbol and its associated registrant name.
/// </summary>
public class Symbol
{
    /// <summary>
    /// The trading symbol.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// The registrant name associated with the trading symbol.
    /// </summary>
    public string? RegistrantName { get; init; }
}
