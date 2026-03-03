using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class MarketCapTests
    {
        [TestMethod]
        public void MarketCap_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""central_index_key"": ""0000789019"",
    ""registrant_name"": ""MICROSOFT CORP"",
    ""date"": ""2024-01-15"",
    ""market_cap"": 3100000000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var marketCap = FinancialDataSerializer.Instance.Deserialize<MarketCap>(doc);
            Assert.AreEqual("MSFT", marketCap.TradingSymbol);
            Assert.AreEqual("0000789019", marketCap.CentralIndexKey);
            Assert.AreEqual(3100000000000m, marketCap.MarketCapValue);
        }
    }
}
