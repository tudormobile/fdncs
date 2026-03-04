namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents daily stock price information for a specific trading symbol, including open, high, low, close prices, and
/// trading volume.
/// </summary>
/// <remarks>This record is intended for use in financial data processing scenarios, such as historical price
/// analysis, charting, or serialization. All properties are required to accurately describe a single day's trading
/// activity for the specified symbol.</remarks>
public record StockPrice
{
    private DateOnly? _date;
    private DateTimeOffset? _time;

    /// <summary>
    /// Gets the trading symbol associated with the financial instrument.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the date associated with the record.
    /// </summary>
    public DateOnly Date
    {
        get => _date ?? (_time != null ? DateOnly.FromDateTime(_time.Value.Date) : default);
        set { _date = value; }
    }

    /// <summary>
    /// Gets the timestamp representing the date and time associated with the current instance.
    /// </summary>
    /// <remarks>This property is initialized at the time of object creation and cannot be modified
    /// thereafter. It is represented as a DateTimeOffset, which includes both the date and time along with the offset
    /// from UTC.</remarks>
    public DateTimeOffset Time
    {
        get => _time ?? (_date != null ? _date.Value.ToDateTime(TimeOnly.MinValue) : default);
        set { _time = value; }
    }

    /// <summary>
    /// Gets the opening price of the asset for the trading period.
    /// </summary>
    public decimal Open { get; init; }

    /// <summary>
    /// Gets the highest price recorded during the relevant time period.
    /// </summary>
    public decimal High { get; init; }

    /// <summary>
    /// Gets the lowest price recorded during the relevant time period.
    /// </summary>
    public decimal Low { get; init; }

    /// <summary>
    /// Gets the closing price of the asset for the trading period.
    /// </summary>
    public decimal Close { get; init; }

    /// <summary>
    /// Gets the total traded volume for the security.
    /// </summary>
    public decimal Volume { get; init; }

    /// <summary>
    /// Returns a string representation of the current instance serialized using the FinancialDataSerializer.
    /// </summary>
    /// <remarks>Use this method to obtain a text-based representation suitable for storage or transmission.
    /// The format of the returned string is determined by FinancialDataSerializer and may be subject to change in
    /// future versions.</remarks>
    /// <returns>A string that contains the serialized form of the current object.</returns>
    public override string ToString() => FinancialDataSerializer.Instance.Serialize(this);
}

/* Json: StockPrice. See: https://financialdata.net/documentation#stock_prices
{
    "trading_symbol": "MSFT",
    "date": "2024-12-04",
    "open": 433.03,
    "high": 439.67,
    "low": 432.63,
    "close": 437.42,
    "volume": 26009430.0
}
*/

