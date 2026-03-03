using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class CryptoQuoteTests
    {
        [TestMethod]
        public void CryptoQuote_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""BTC-USD"",
    ""time"": ""2024-01-15 14:30:00"",
    ""price"": 42500.75,
    ""volume"": 15000000000.0,
    ""market_cap"": 830000000000.0,
    ""percent_change"": 2.5
}";
            using var doc = JsonDocument.Parse(json);
            var cryptoQuote = FinancialDataSerializer.Instance.Deserialize<CryptoQuote>(doc);
            Assert.AreEqual("BTC-USD", cryptoQuote.TradingSymbol);
            Assert.AreEqual(42500.75m, cryptoQuote.Price);
            Assert.AreEqual(15000000000m, cryptoQuote.Volume);
            Assert.AreEqual(830000000000m, cryptoQuote.MarketCap);
            Assert.AreEqual(2.5m, cryptoQuote.PercentChange);
        }

        [TestMethod]
        public void CryptoQuote_Deserialize_HandlesNullDecimals()
        {
            var json = @"{
    ""trading_symbol"": ""BTC-USD"",
    ""time"": ""2024-01-15 14:30:00"",
    ""price"": 42500.75,
    ""volume"": null,
    ""market_cap"": null,
    ""percent_change"": null
}";
            using var doc = JsonDocument.Parse(json);
            var cryptoQuote = FinancialDataSerializer.Instance.Deserialize<CryptoQuote>(doc);
            Assert.AreEqual(42500.75m, cryptoQuote.Price);
            Assert.AreEqual(0m, cryptoQuote.Volume);
            Assert.AreEqual(0m, cryptoQuote.MarketCap);
            Assert.AreEqual(0m, cryptoQuote.PercentChange);
        }
    }
}
