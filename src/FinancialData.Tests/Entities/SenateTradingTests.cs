using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class SenateTradingTests
    {
        [TestMethod]
        public void SenateTrading_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""NVDA"",
    ""senator_name"": ""John Doe"",
    ""transaction_date"": ""2024-01-10"",
    ""disclosure_date"": ""2024-01-25"",
    ""transaction_type"": ""Purchase"",
    ""asset_type"": ""Stock"",
    ""amount_range"": ""$15,001 - $50,000"",
    ""comment"": """"
}";
            using var doc = JsonDocument.Parse(json);
            var senateTrading = FinancialDataSerializer.Instance.Deserialize<SenateTrading>(doc);
            Assert.AreEqual("NVDA", senateTrading.TradingSymbol);
            Assert.AreEqual("John Doe", senateTrading.SenatorName);
            Assert.AreEqual(new DateOnly(2024, 1, 10), senateTrading.TransactionDate);
            Assert.AreEqual(new DateOnly(2024, 1, 25), senateTrading.DisclosureDate);
            Assert.AreEqual("Purchase", senateTrading.TransactionType);
            Assert.AreEqual("Stock", senateTrading.AssetType);
            Assert.AreEqual("$15,001 - $50,000", senateTrading.AmountRange);
            Assert.AreEqual("", senateTrading.Comment);
        }
    }
}
