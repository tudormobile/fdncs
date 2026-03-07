using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EtfPricesTests
    {
        [TestMethod]
        public void EtfPrices_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""SPY"",
    ""date"": ""2024-12-03"",
    ""open"": 603.39,
    ""high"": 604.16,
    ""low"": 602.341,
    ""close"": 603.91,
    ""volume"": 26906630.0
}";
            using var doc = JsonDocument.Parse(json);
            var etfPrices = FinancialDataSerializer.Instance.Deserialize<EtfPrices>(doc);
            Assert.AreEqual("SPY", etfPrices.TradingSymbol);
            Assert.AreEqual(new DateOnly(2024, 12, 3), etfPrices.Date);
            Assert.AreEqual(603.39m, etfPrices.Open);
            Assert.AreEqual(604.16m, etfPrices.High);
            Assert.AreEqual(602.341m, etfPrices.Low);
            Assert.AreEqual(603.91m, etfPrices.Close);
            Assert.AreEqual(26906630.0m, etfPrices.Volume);
        }
    }
}
