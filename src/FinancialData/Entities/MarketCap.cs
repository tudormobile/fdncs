namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents historical market capitalization data for a company.
/// <para>See: https://financialdata.net/documentation#market_cap</para>
/// </summary>
public record MarketCap
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the central index key (CIK) assigned by the SEC.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets or sets the market capitalization.
    /// </summary>
    public decimal MarketCapValue { get; init; }

    /// <summary>
    /// Gets or sets the change in market capitalization.
    /// </summary>
    public decimal ChangeInMarketCap { get; init; }

    /// <summary>
    /// Gets or sets the percentage change in market capitalization.
    /// </summary>
    public decimal PercentageChangeInMarketCap { get; init; }

    /// <summary>
    /// Gets or sets the number of shares outstanding.
    /// </summary>
    public decimal SharesOutstanding { get; init; }

    /// <summary>
    /// Gets or sets the change in shares outstanding.
    /// </summary>
    public decimal ChangeInSharesOutstanding { get; init; }

    /// <summary>
    /// Gets or sets the percentage change in shares outstanding.
    /// </summary>
    public decimal PercentageChangeInSharesOutstanding { get; init; }
}
