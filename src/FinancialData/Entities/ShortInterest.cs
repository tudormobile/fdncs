namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents short interest data including number of shares sold short, days to cover, and percentage changes.
/// <para>See: https://financialdata.net/documentation#short_interest</para>
/// </summary>
public record ShortInterest
{
    /// <summary>
    /// Gets or sets the trading symbol of the security.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the title of the security.
    /// </summary>
    public string? TitleOfSecurity { get; init; }

    /// <summary>
    /// Gets or sets the market code.
    /// </summary>
    public string? MarketCode { get; init; }

    /// <summary>
    /// Gets or sets the settlement date.
    /// </summary>
    public DateOnly SettlementDate { get; init; }

    /// <summary>
    /// Gets or sets the number of shorted securities.
    /// </summary>
    public decimal ShortedSecurities { get; init; }

    /// <summary>
    /// Gets or sets the previous number of shorted securities.
    /// </summary>
    public decimal PreviousShortedSecurities { get; init; }

    /// <summary>
    /// Gets or sets the change in shorted securities.
    /// </summary>
    public decimal ChangeInShortedSecurities { get; init; }

    /// <summary>
    /// Gets or sets the percentage change in shorted securities.
    /// </summary>
    public decimal PercentageChangeInShortedSecurities { get; init; }

    /// <summary>
    /// Gets or sets the average daily volume.
    /// </summary>
    public decimal AverageDailyVolume { get; init; }

    /// <summary>
    /// Gets or sets the days to cover (short interest ratio).
    /// </summary>
    public decimal DaysToCover { get; init; }

    /// <summary>
    /// Gets or sets whether a stock split occurred.
    /// </summary>
    public bool IsStockSplit { get; init; }
}
