namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a mutual fund symbol, including its trading symbol and name.
/// </summary>
public record MutualFundSymbol
{
    /// <summary>
    /// Gets the trading symbol of the mutual fund.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the name of the mutual fund.
    /// </summary>
    public string? FundName { get; init; }
}
/* ref: https://financialdata.net/documentation#mutual_fund_symbols
{
    "trading_symbol": "AAAAX",
    "fund_name": "DWS RREEF Real Assets Fund, Class A"
}
*/
