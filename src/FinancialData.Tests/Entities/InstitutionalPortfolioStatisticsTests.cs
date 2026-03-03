using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InstitutionalPortfolioStatisticsTests
    {
        [TestMethod]
        public void InstitutionalPortfolioStatistics_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""investor_cik"": ""0001067983"",
    ""investor_name"": ""BERKSHIRE HATHAWAY INC"",
    ""period_end_date"": ""2024-03-31"",
    ""filing_date"": ""2024-05-15"",
    ""total_value"": 360000000000.0,
    ""number_of_holdings"": 45,
    ""new_positions"": 3,
    ""sold_out_positions"": 2,
    ""increased_positions"": 15,
    ""decreased_positions"": 8,
    ""total_value_change"": 5000000000.0,
    ""total_value_change_percent"": 1.41
}";
            using var doc = JsonDocument.Parse(json);
            var stats = FinancialDataSerializer.Instance.Deserialize<InstitutionalPortfolioStatistics>(doc);
            Assert.AreEqual("0001067983", stats.InvestorCik);
            Assert.AreEqual("BERKSHIRE HATHAWAY INC", stats.InvestorName);
            Assert.AreEqual(360000000000m, stats.TotalValue);
            Assert.AreEqual(45, stats.NumberOfHoldings);
            Assert.AreEqual(3, stats.NewPositions);
        }
    }
}
