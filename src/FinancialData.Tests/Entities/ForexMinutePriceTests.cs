using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ForexMinutePriceTests
    {
        [TestMethod]
        public void ForexMinutePrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""EUR/USD"",
    ""time"": ""2024-01-15 14:30:00"",
    ""open"": 1.0890,
    ""high"": 1.0893,
    ""low"": 1.0888,
    ""close"": 1.0891
}";
            using var doc = JsonDocument.Parse(json);
            var forexMinutePrice = FinancialDataSerializer.Instance.Deserialize<ForexMinutePrice>(doc);
            Assert.AreEqual("EUR/USD", forexMinutePrice.TradingSymbol);
            Assert.AreEqual(new DateTime(2024, 1, 15, 14, 30, 0), forexMinutePrice.Time);
            Assert.AreEqual(1.0890m, forexMinutePrice.Open);
            Assert.AreEqual(1.0893m, forexMinutePrice.High);
            Assert.AreEqual(1.0888m, forexMinutePrice.Low);
            Assert.AreEqual(1.0891m, forexMinutePrice.Close);
        }
    }
}
