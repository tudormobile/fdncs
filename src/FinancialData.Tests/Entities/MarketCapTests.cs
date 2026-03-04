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
    ""fiscal_year"": ""2024"",
    ""market_cap_value"": 3100000000000.0,
    ""change_in_market_cap"": 50000000000.0,
    ""percentage_change_in_market_cap"": 1.64,
    ""shares_outstanding"": 7430000000.0,
    ""change_in_shares_outstanding"": 0.0,
    ""percentage_change_in_shares_outstanding"": 0.0
}";
            using var doc = JsonDocument.Parse(json);
            var marketCap = FinancialDataSerializer.Instance.Deserialize<MarketCap>(doc);
            Assert.AreEqual("MSFT", marketCap.TradingSymbol);
            Assert.AreEqual("0000789019", marketCap.CentralIndexKey);
            Assert.AreEqual(3100000000000m, marketCap.MarketCapValue);
        }
    }
}
