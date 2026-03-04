using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class IndexPriceTests
    {
        [TestMethod]
        public void IndexPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""^GSPC"",
    ""date"": ""2025-06-13"",
    ""open"": 6000.56,
    ""high"": 6026.16,
    ""low"": 5963.21,
    ""close"": 5976.97,
    ""volume"": 5258910000.0
}";
            using var doc = JsonDocument.Parse(json);
            var indexPrice = FinancialDataSerializer.Instance.Deserialize<IndexPrice>(doc);
            Assert.AreEqual("^GSPC", indexPrice.TradingSymbol);
            Assert.AreEqual(new DateOnly(2025, 6, 13), indexPrice.Date);
            Assert.AreEqual(6000.56m, indexPrice.Open);
            Assert.AreEqual(6026.16m, indexPrice.High);
            Assert.AreEqual(5976.97m, indexPrice.Close);
        }
    }
}
