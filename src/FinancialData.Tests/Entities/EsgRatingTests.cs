using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EsgRatingTests
    {
        [TestMethod]
        public void EsgRating_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""central_index_key"": ""0000789019"",
    ""registrant_name"": ""MICROSOFT CORP"",
    ""date"": ""2024-01-15"",
    ""rating"": ""AAA"",
    ""environmental_rating"": ""AA"",
    ""social_rating"": ""AAA"",
    ""governance_rating"": ""AA""
}";
            using var doc = JsonDocument.Parse(json);
            var esgRating = FinancialDataSerializer.Instance.Deserialize<EsgRating>(doc);
            Assert.AreEqual("MSFT", esgRating.TradingSymbol);
            Assert.AreEqual("0000789019", esgRating.CentralIndexKey);
            Assert.AreEqual("MICROSOFT CORP", esgRating.RegistrantName);
            Assert.AreEqual(new DateOnly(2024, 1, 15), esgRating.Date);
            Assert.AreEqual("AAA", esgRating.Rating);
            Assert.AreEqual("AA", esgRating.EnvironmentalRating);
            Assert.AreEqual("AAA", esgRating.SocialRating);
            Assert.AreEqual("AA", esgRating.GovernanceRating);
        }
    }
}
