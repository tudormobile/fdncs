namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a cryptocurrency symbol and its full name.
/// <para>See: https://financialdata.net/documentation#crypto_symbols</para>
/// </summary>
public record CryptoSymbol
{
    /// <summary>
    /// Gets the trading symbol of the cryptocurrency.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the full name of the cryptocurrency.
    /// </summary>
    public string? Name { get; init; }
}
