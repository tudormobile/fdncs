using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EtfQuotesTests
    {
        [TestMethod]
        public void EtfQuotes_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""SPY"",
    ""description"": ""SPDR S&P 500 ETF Trust"",
    ""time"": ""2025-09-02 15:59:30"",
    ""price"": 642.41,
    ""change"": 2.14,
    ""percentage_change"": 0.33
}";
            using var doc = JsonDocument.Parse(json);
            var etfQuotes = FinancialDataSerializer.Instance.Deserialize<EtfQuotes>(doc);
            Assert.AreEqual("SPY", etfQuotes.TradingSymbol);
            Assert.AreEqual("SPDR S&P 500 ETF Trust", etfQuotes.Description);
            Assert.AreEqual(new DateTime(2025, 9, 2, 15, 59, 30), etfQuotes.Time);
            Assert.AreEqual(642.41m, etfQuotes.Price);
            Assert.AreEqual(2.14m, etfQuotes.Change);
            Assert.AreEqual(0.33m, etfQuotes.PercentageChange);
        }
    }
}
