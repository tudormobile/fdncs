using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ForexQuoteTests
    {
        [TestMethod]
        public void ForexQuote_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""EUR/USD"",
    ""time"": ""2024-01-15 14:30:00"",
    ""bid"": 1.0890,
    ""ask"": 1.0892,
    ""rate"": 1.0891
}";
            using var doc = JsonDocument.Parse(json);
            var forexQuote = FinancialDataSerializer.Instance.Deserialize<ForexQuote>(doc);
            Assert.AreEqual("EUR/USD", forexQuote.TradingSymbol);
            Assert.AreEqual(new DateTime(2024, 1, 15, 14, 30, 0), forexQuote.Time);
            Assert.AreEqual(1.0890m, forexQuote.Bid);
            Assert.AreEqual(1.0892m, forexQuote.Ask);
            Assert.AreEqual(1.0891m, forexQuote.Rate);
        }
    }
}
