using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class CryptoMinutePriceTests
    {
        [TestMethod]
        public void CryptoMinutePrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""BTC-USD"",
    ""time"": ""2024-01-15 14:30:00"",
    ""open"": 42500.50,
    ""high"": 42550.75,
    ""low"": 42480.25,
    ""close"": 42540.00,
    ""volume"": 125000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var cryptoMinutePrice = FinancialDataSerializer.Instance.Deserialize<CryptoMinutePrice>(doc);
            Assert.AreEqual("BTC-USD", cryptoMinutePrice.TradingSymbol);
            Assert.AreEqual(new DateTime(2024, 1, 15, 14, 30, 0), cryptoMinutePrice.Time);
            Assert.AreEqual(42500.50m, cryptoMinutePrice.Open);
            Assert.AreEqual(42550.75m, cryptoMinutePrice.High);
            Assert.AreEqual(42480.25m, cryptoMinutePrice.Low);
            Assert.AreEqual(42540.00m, cryptoMinutePrice.Close);
            Assert.AreEqual(125000000.0m, cryptoMinutePrice.Volume);
        }
    }
}
