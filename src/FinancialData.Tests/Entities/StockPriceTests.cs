using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class StockPriceTests
    {
        [TestMethod]
        public void StockPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""date"": ""2024-12-04"",
    ""open"": 433.03,
    ""high"": 439.67,
    ""low"": 432.63,
    ""close"": 437.42,
    ""volume"": 26009430.0
}";
            using var doc = JsonDocument.Parse(json);
            var stockPrice = FinancialDataSerializer.Instance.Deserialize<StockPrice>(doc);
            Assert.AreEqual("MSFT", stockPrice.TradingSymbol);
            Assert.AreEqual(new DateOnly(2024, 12, 4), stockPrice.Date);
            Assert.AreEqual(433.03m, stockPrice.Open);
            Assert.AreEqual(439.67m, stockPrice.High);
            Assert.AreEqual(432.63m, stockPrice.Low);
            Assert.AreEqual(437.42m, stockPrice.Close);
            Assert.AreEqual(26009430.0m, stockPrice.Volume);
        }
    }
}
