using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class StockQuoteTests
{
    [TestMethod]
    public void StockQuote_Initialization_Works()
    {
        var quote = new StockQuote
        {
            TradingSymbol = "AAPL",
            RegistrantName = "Apple Inc.",
            Time = new DateTime(2024, 6, 1, 10, 0, 0),
            Price = 150.25m,
            Change = 1.5m,
            PercentageChange = 1.0m
        };
        Assert.AreEqual("AAPL", quote.TradingSymbol);
        Assert.AreEqual("Apple Inc.", quote.RegistrantName);
        Assert.AreEqual(new DateTime(2024, 6, 1, 10, 0, 0), quote.Time);
        Assert.AreEqual(150.25m, quote.Price);
        Assert.AreEqual(1.5m, quote.Change);
        Assert.AreEqual(1.0m, quote.PercentageChange);
    }

    [TestMethod]
    public void StockQuote_Deserialize_FromJson_Works()
    {
        var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""registrant_name"": ""Apple Inc."",
    ""time"": ""2025-09-02 15:56:00"",
    ""price"": 238.08,
    ""change"": 8.36,
    ""percentage_change"": 3.64
}
";
        using var doc = JsonDocument.Parse(json);
        var quote = FinancialDataSerializer.Instance.Deserialize<StockQuote>(doc);
        Assert.AreEqual("AAPL", quote.TradingSymbol);
        Assert.AreEqual("Apple Inc.", quote.RegistrantName);
        Assert.AreEqual(new DateTime(2025, 9, 2, 15, 56, 0), quote.Time);
        Assert.AreEqual(238.08m, quote.Price);
        Assert.AreEqual(8.36m, quote.Change);
        Assert.AreEqual(3.64m, quote.PercentageChange);
    }
}
