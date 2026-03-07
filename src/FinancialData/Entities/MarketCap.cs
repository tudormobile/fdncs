namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents historical market capitalization data for a company.
/// <para>See: https://financialdata.net/documentation#market_cap</para>
/// </summary>
public record MarketCap
{
    /// <summary>
    /// Gets the trading symbol of the company.
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
    /// Gets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets the market capitalization.
    /// </summary>
    public decimal MarketCapValue { get; init; }

    /// <summary>
    /// Gets the change in market capitalization.
    /// </summary>
    public decimal ChangeInMarketCap { get; init; }

    /// <summary>
    /// Gets the percentage change in market capitalization.
    /// </summary>
    public decimal PercentageChangeInMarketCap { get; init; }

    /// <summary>
    /// Gets the number of shares outstanding.
    /// </summary>
    public decimal SharesOutstanding { get; init; }

    /// <summary>
    /// Gets the change in shares outstanding.
    /// </summary>
    public decimal ChangeInSharesOutstanding { get; init; }

    /// <summary>
    /// Gets the percentage change in shares outstanding.
    /// </summary>
    public decimal PercentageChangeInSharesOutstanding { get; init; }
}
/* Ref:
{
    "trading_symbol": "MSFT",
    "central_index_key": "0000789019",
    "registrant_name": "MICROSOFT CORP",
    "fiscal_year": "2024",
    "market_cap": 2800000000000.0,
    "change_in_market_cap": 1000000000000.0,
    "percentage_change_in_market_cap": 55.5555555555556,
    "shares_outstanding": 7433038381,
    "change_in_shares_outstanding": 3274659,
    "percentage_change_in_shares_outstanding": 0.0440748740138738
  }
*/