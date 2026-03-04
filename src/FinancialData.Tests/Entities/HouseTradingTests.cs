using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class HouseTradingTests
    {
        [TestMethod]
        public void HouseTrading_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""representative_name"": ""Jane Smith"",
    ""transaction_date"": ""2024-01-12"",
    ""disclosure_date"": ""2024-01-30"",
    ""transaction_type"": ""Sale"",
    ""asset_type"": ""Stock"",
    ""amount_range"": ""$50,001 - $100,000"",
    ""comment"": """"
}";
            using var doc = JsonDocument.Parse(json);
            var houseTrading = FinancialDataSerializer.Instance.Deserialize<HouseTrading>(doc);
            Assert.AreEqual("MSFT", houseTrading.TradingSymbol);
            Assert.AreEqual("Jane Smith", houseTrading.RepresentativeName);
            Assert.AreEqual(new DateOnly(2024, 1, 12), houseTrading.TransactionDate);
            Assert.AreEqual(new DateOnly(2024, 1, 30), houseTrading.DisclosureDate);
            Assert.AreEqual("Sale", houseTrading.TransactionType);
            Assert.AreEqual("Stock", houseTrading.AssetType);
            Assert.AreEqual("$50,001 - $100,000", houseTrading.AmountRange);
            Assert.AreEqual("", houseTrading.Comment);
        }
    }
}
