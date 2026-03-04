using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class LatestPriceTests
    {
        [TestMethod]
        public void LatestPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""TSLA"",
    ""time"": ""2024-01-15 15:45:00"",
    ""open"": 245.30,
    ""high"": 246.80,
    ""low"": 244.90,
    ""close"": 246.50,
    ""volume"": 85000
}";
            using var doc = JsonDocument.Parse(json);
            var latestPrice = FinancialDataSerializer.Instance.Deserialize<LatestPrice>(doc);
            Assert.AreEqual("TSLA", latestPrice.TradingSymbol);
            Assert.AreEqual(245.30m, latestPrice.Open);
            Assert.AreEqual(246.80m, latestPrice.High);
            Assert.AreEqual(244.90m, latestPrice.Low);
            Assert.AreEqual(246.50m, latestPrice.Close);
        }
    }
}
