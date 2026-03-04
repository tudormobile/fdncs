using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class IndexConstituentTests
    {
        [TestMethod]
        public void IndexConstituent_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""^GSPC"",
    ""index_name"": ""S&P 500"",
    ""constituent_symbol"": ""COIN"",
    ""constituent_name"": ""Coinbase"",
    ""sector"": ""Financials"",
    ""industry"": ""Financial Exchanges & Data"",
    ""date_added"": ""2025-05-19""
}";
            using var doc = JsonDocument.Parse(json);
            var indexConstituent = FinancialDataSerializer.Instance.Deserialize<IndexConstituent>(doc);
            Assert.AreEqual("^GSPC", indexConstituent.TradingSymbol);
            Assert.AreEqual("S&P 500", indexConstituent.IndexName);
            Assert.AreEqual("COIN", indexConstituent.ConstituentSymbol);
            Assert.AreEqual("Coinbase", indexConstituent.ConstituentName);
            Assert.AreEqual("Financials", indexConstituent.Sector);
            Assert.AreEqual(new DateOnly(2025, 5, 19), indexConstituent.DateAdded);
        }
    }
}
