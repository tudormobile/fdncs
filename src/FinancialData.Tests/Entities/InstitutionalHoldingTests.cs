using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InstitutionalHoldingTests
    {
        [TestMethod]
        public void InstitutionalHolding_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""central_index_key"": ""0000320193"",
    ""registrant_name"": ""Apple Inc."",
    ""investor_cik"": ""0001067983"",
    ""investor_name"": ""Berkshire Hathaway"",
    ""period_end_date"": ""2024-03-31"",
    ""filing_date"": ""2024-05-15"",
    ""shares"": 915000000,
    ""value"": 153000000000.0,
    ""portfolio_percent"": 42.5,
    ""shares_change"": null,
    ""shares_change_percent"": null
}";
            using var doc = JsonDocument.Parse(json);
            var holding = FinancialDataSerializer.Instance.Deserialize<InstitutionalHolding>(doc);
            Assert.AreEqual("AAPL", holding.TradingSymbol);
            Assert.AreEqual("Berkshire Hathaway", holding.InvestorName);
            Assert.AreEqual(915000000m, holding.Shares);
            Assert.AreEqual(153000000000m, holding.Value);
            Assert.AreEqual(42.5m, holding.PortfolioPercent);
            Assert.AreEqual(0m, holding.SharesChange);
            Assert.AreEqual(0m, holding.SharesChangePercent);
        }
    }
}
