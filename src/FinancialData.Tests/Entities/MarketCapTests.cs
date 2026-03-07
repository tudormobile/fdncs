using System.Text.Json;
using Tudormobile.FinancialData.Entities;

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
            Assert.AreEqual("MICROSOFT CORP", marketCap.RegistrantName);
            Assert.AreEqual("2024", marketCap.FiscalYear);
            Assert.AreEqual(3100000000000m, marketCap.MarketCapValue);
            Assert.AreEqual(50000000000m, marketCap.ChangeInMarketCap);
            Assert.AreEqual(1.64m, marketCap.PercentageChangeInMarketCap);
            Assert.AreEqual(7430000000m, marketCap.SharesOutstanding);
            Assert.AreEqual(0m, marketCap.ChangeInSharesOutstanding);
            Assert.AreEqual(0m, marketCap.PercentageChangeInSharesOutstanding);
        }
    }
}
