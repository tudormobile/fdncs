using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EsgScoreTests
    {
        [TestMethod]
        public void EsgScore_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""central_index_key"": ""0000320193"",
    ""registrant_name"": ""Apple Inc."",
    ""date"": ""2024-01-15"",
    ""total_score"": 82.5,
    ""environmental_score"": 85.0,
    ""social_score"": 80.0,
    ""governance_score"": 83.0,
    ""controversy_score"": 2.0
}";
            using var doc = JsonDocument.Parse(json);
            var esgScore = FinancialDataSerializer.Instance.Deserialize<EsgScore>(doc);
            Assert.AreEqual("AAPL", esgScore.TradingSymbol);
            Assert.AreEqual(82.5m, esgScore.TotalScore);
            Assert.AreEqual(85.0m, esgScore.EnvironmentalScore);
            Assert.AreEqual(80.0m, esgScore.SocialScore);
            Assert.AreEqual(83.0m, esgScore.GovernanceScore);
            Assert.AreEqual(2.0m, esgScore.ControversyScore);
        }
    }
}
