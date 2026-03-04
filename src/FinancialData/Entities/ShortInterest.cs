namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents short interest data including number of shares sold short, days to cover, and percentage changes.
/// <para>See: https://financialdata.net/documentation#short_interest</para>
/// </summary>
public record ShortInterest
{
    /// <summary>
    /// Gets the trading symbol of the security.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the title of the security.
    /// </summary>
    public string? TitleOfSecurity { get; init; }

    /// <summary>
    /// Gets the market code.
    /// </summary>
    public string? MarketCode { get; init; }

    /// <summary>
    /// Gets the settlement date.
    /// </summary>
    public DateOnly SettlementDate { get; init; }

    /// <summary>
    /// Gets the number of shorted securities.
    /// </summary>
    public decimal ShortedSecurities { get; init; }

    /// <summary>
    /// Gets the previous number of shorted securities.
    /// </summary>
    public decimal PreviousShortedSecurities { get; init; }

    /// <summary>
    /// Gets the change in shorted securities.
    /// </summary>
    public decimal ChangeInShortedSecurities { get; init; }

    /// <summary>
    /// Gets the percentage change in shorted securities.
    /// </summary>
    public decimal PercentageChangeInShortedSecurities { get; init; }

    /// <summary>
    /// Gets the average daily volume.
    /// </summary>
    public decimal AverageDailyVolume { get; init; }

    /// <summary>
    /// Gets the days to cover (short interest ratio).
    /// </summary>
    public decimal DaysToCover { get; init; }

    /// <summary>
    /// Gets whether a stock split occurred.
    /// </summary>
    public bool IsStockSplit { get; init; }
}
