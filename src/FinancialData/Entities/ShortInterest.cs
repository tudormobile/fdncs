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
/*
{
    "trading_symbol": "MSFT",
    "title_of_security": "Microsoft Corporation Common S",
    "market_code": "NNM",
    "settlement_date": "2024-11-15",
    "shorted_securities": 56018482,
    "previous_shorted_securities": 62516096,
    "change_in_shorted_securities": -6497614,
    "percentage_change_in_shorted_securities": -10.39,
    "average_daily_volume": 22446377,
    "days_to_cover": 2.5,
    "is_stock_split": false
  }
*/