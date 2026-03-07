using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class MinutePriceTests
    {
        [TestMethod]
        public void MinutePrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""time"": ""2024-01-15 14:30:00"",
    ""open"": 185.50,
    ""high"": 185.75,
    ""low"": 185.40,
    ""close"": 185.65,
    ""volume"": 125000
}";
            using var doc = JsonDocument.Parse(json);
            var minutePrice = FinancialDataSerializer.Instance.Deserialize<MinutePrice>(doc);
            Assert.AreEqual("AAPL", minutePrice.TradingSymbol);
            Assert.AreEqual(new DateTime(2024, 1, 15, 14, 30, 0), minutePrice.Time);
            Assert.AreEqual(185.50m, minutePrice.Open);
            Assert.AreEqual(185.75m, minutePrice.High);
            Assert.AreEqual(185.40m, minutePrice.Low);
            Assert.AreEqual(185.65m, minutePrice.Close);
            Assert.AreEqual(125000m, minutePrice.Volume);
        }

        [TestMethod]
        public void MinutePrice_Deserialize_HandlesNullDecimals()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""time"": ""2024-01-15 14:30:00"",
    ""open"": null,
    ""high"": 185.75,
    ""low"": null,
    ""close"": 185.65,
    ""volume"": null
}";
            using var doc = JsonDocument.Parse(json);
            var minutePrice = FinancialDataSerializer.Instance.Deserialize<MinutePrice>(doc);
            Assert.AreEqual("AAPL", minutePrice.TradingSymbol);
            Assert.AreEqual(0m, minutePrice.Open);
            Assert.AreEqual(0m, minutePrice.Low);
            Assert.AreEqual(0m, minutePrice.Volume);
        }
    }
}
