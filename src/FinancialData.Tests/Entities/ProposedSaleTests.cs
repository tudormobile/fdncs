using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ProposedSaleTests
    {
        [TestMethod]
        public void ProposedSale_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AMZN"",
    ""central_index_key"": ""0001018724"",
    ""registrant_name"": ""AMAZON COM INC"",
    ""insider_name"": ""Jeffrey P. Bezos"",
    ""filing_date"": ""2024-02-02"",
    ""shares"": 50000000,
    ""sec_filing_url"": ""https://www.sec.gov/cgi-bin/browse-edgar""
}";
            using var doc = JsonDocument.Parse(json);
            var proposedSale = FinancialDataSerializer.Instance.Deserialize<ProposedSale>(doc);
            Assert.AreEqual("AMZN", proposedSale.TradingSymbol);
            Assert.AreEqual("Jeffrey P. Bezos", proposedSale.InsiderName);
            Assert.AreEqual(50000000m, proposedSale.Shares);
        }
    }
}
