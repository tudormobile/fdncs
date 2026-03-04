namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily historical price data for a cryptocurrency.
/// <para>See: https://financialdata.net/documentation#crypto_prices</para>
/// </summary>
public record CryptoPrice
{
    /// <summary>
    /// Gets the trading symbol of the cryptocurrency.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the date of the price record.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// Gets the opening price.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest price.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest price.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing price.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets the trading volume.
    /// </summary>
    public decimal Volume { get; init; }

    /// <summary>
    /// Gets the market capitalization.
    /// </summary>
    public decimal MarketCap { get; init; }
}
