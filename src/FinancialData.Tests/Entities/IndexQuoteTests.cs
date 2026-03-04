using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class IndexQuoteTests
    {
        [TestMethod]
        public void IndexQuote_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""^GSPC"",
    ""index_name"": ""S&P 500"",
    ""time"": ""2025-09-23 15:19:59"",
    ""price"": 6656.92,
    ""change"": -36.83,
    ""percentage_change"": -0.55
}";
            using var doc = JsonDocument.Parse(json);
            var indexQuote = FinancialDataSerializer.Instance.Deserialize<IndexQuote>(doc);
            Assert.AreEqual("^GSPC", indexQuote.TradingSymbol);
            Assert.AreEqual("S&P 500", indexQuote.IndexName);
            Assert.AreEqual(6656.92m, indexQuote.Price);
            Assert.AreEqual(-36.83m, indexQuote.Change);
            Assert.AreEqual(-0.55m, indexQuote.PercentageChange);
        }
    }
}
