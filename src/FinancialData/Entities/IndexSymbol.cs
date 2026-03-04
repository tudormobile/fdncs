namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a market index symbol, including its trading symbol and name.
/// <para>See: https://financialdata.net/documentation#index_symbols</para>
/// </summary>
public record IndexSymbol
{
    /// <summary>
    /// Gets the trading symbol of the market index.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the name of the market index.
    /// </summary>
    public string? IndexName { get; init; }
}
/* ref: https://financialdata.net/documentation#index_symbols
{
    "trading_symbol": "000001.SS",
    "index_name": "SSE Composite Index"
  }
*/