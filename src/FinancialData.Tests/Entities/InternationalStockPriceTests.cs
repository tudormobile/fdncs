using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InternationalStockPriceTests
    {
        [TestMethod]
        public void InternationalStockPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""SHEL.L"",
    ""date"": ""2024-01-15"",
    ""currency_code"": ""GBP"",
    ""open"": 2450.50,
    ""high"": 2475.00,
    ""low"": 2445.00,
    ""close"": 2470.00,
    ""volume"": 5000000
}";
            using var doc = JsonDocument.Parse(json);
            var price = FinancialDataSerializer.Instance.Deserialize<InternationalStockPrice>(doc);
            Assert.AreEqual("SHEL.L", price.TradingSymbol);
            Assert.AreEqual(2450.50m, price.Open);
            Assert.AreEqual(2475.00m, price.High);
            Assert.AreEqual(2445.00m, price.Low);
            Assert.AreEqual(2470.00m, price.Close);
        }
    }
}
