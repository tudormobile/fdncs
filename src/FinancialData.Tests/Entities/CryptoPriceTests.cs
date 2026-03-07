using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class CryptoPriceTests
    {
        [TestMethod]
        public void CryptoPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""ETH-USD"",
    ""date"": ""2024-01-15"",
    ""open"": 2450.50,
    ""high"": 2485.75,
    ""low"": 2440.25,
    ""close"": 2475.00,
    ""volume"": 8500000000.0,
    ""market_cap"": 295000000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var cryptoPrice = FinancialDataSerializer.Instance.Deserialize<CryptoPrice>(doc);
            Assert.AreEqual("ETH-USD", cryptoPrice.TradingSymbol);
            Assert.AreEqual(new DateOnly(2024, 1, 15), cryptoPrice.Date);
            Assert.AreEqual(2450.50m, cryptoPrice.Open);
            Assert.AreEqual(2485.75m, cryptoPrice.High);
            Assert.AreEqual(2440.25m, cryptoPrice.Low);
            Assert.AreEqual(2475.00m, cryptoPrice.Close);
            Assert.AreEqual(8500000000.0m, cryptoPrice.Volume);
            Assert.AreEqual(295000000000.0m, cryptoPrice.MarketCap);
        }
    }
}
