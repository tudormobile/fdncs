using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ForexPriceTests
    {
        [TestMethod]
        public void ForexPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""GBP/USD"",
    ""date"": ""2024-01-15"",
    ""open"": 1.2650,
    ""high"": 1.2680,
    ""low"": 1.2640,
    ""close"": 1.2675
}";
            using var doc = JsonDocument.Parse(json);
            var forexPrice = FinancialDataSerializer.Instance.Deserialize<ForexPrice>(doc);
            Assert.AreEqual("GBP/USD", forexPrice.TradingSymbol);
            Assert.AreEqual(1.2650m, forexPrice.Open);
            Assert.AreEqual(1.2680m, forexPrice.High);
            Assert.AreEqual(1.2675m, forexPrice.Close);
        }
    }
}
