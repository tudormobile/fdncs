using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class IndustryEsgScoreTests
    {
        [TestMethod]
        public void IndustryEsgScore_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""industry"": ""Technology"",
    ""date"": ""2024-01-15"",
    ""average_total_score"": 75.5,
    ""average_environmental_score"": 72.3,
    ""average_social_score"": 78.2,
    ""average_governance_score"": 76.1,
    ""average_controversy_score"": 3.2,
    ""number_of_companies"": 250
}";
            using var doc = JsonDocument.Parse(json);
            var industryScore = FinancialDataSerializer.Instance.Deserialize<IndustryEsgScore>(doc);
            Assert.AreEqual("Technology", industryScore.Industry);
            Assert.AreEqual(new DateOnly(2024, 1, 15), industryScore.Date);
            Assert.AreEqual(75.5m, industryScore.AverageTotalScore);
            Assert.AreEqual(72.3m, industryScore.AverageEnvironmentalScore);
            Assert.AreEqual(78.2m, industryScore.AverageSocialScore);
            Assert.AreEqual(76.1m, industryScore.AverageGovernanceScore);
            Assert.AreEqual(3.2m, industryScore.AverageControversyScore);
            Assert.AreEqual(250, industryScore.NumberOfCompanies);
        }
    }
}
