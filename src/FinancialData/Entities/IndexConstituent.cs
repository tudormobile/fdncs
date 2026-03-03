namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a constituent of a market index, including its symbol, name, sector, and industry.
/// <para>See: https://financialdata.net/documentation#index_constituents</para>
/// </summary>
public record IndexConstituent
{
    /// <summary>
    /// Gets or sets the trading symbol of the market index.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the name of the market index.
    /// </summary>
    public string? IndexName { get; init; }

    /// <summary>
    /// Gets or sets the symbol of the constituent security.
    /// </summary>
    public string? ConstituentSymbol { get; init; }

    /// <summary>
    /// Gets or sets the name of the constituent security.
    /// </summary>
    public string? ConstituentName { get; init; }

    /// <summary>
    /// Gets or sets the sector of the constituent security.
    /// </summary>
    public string? Sector { get; init; }

    /// <summary>
    /// Gets or sets the industry of the constituent security.
    /// </summary>
    public string? Industry { get; init; }

    /// <summary>
    /// Gets or sets the date the constituent was added to the index.
    /// </summary>
    public DateOnly? DateAdded { get; init; }
}
/*Ref: https://financialdata.net/documentation#index_constituents
{
    "trading_symbol": "^GSPC",
    "index_name": "S&P 500",
    "constituent_symbol": "COIN",
    "constituent_name": "Coinbase",
    "sector": "Financials",
    "industry": "Financial Exchanges & Data",
    "date_added": "2025-05-19"
  }
*/