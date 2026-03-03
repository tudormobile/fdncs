using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ShortInterestTests
    {
        [TestMethod]
        public void ShortInterest_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""GME"",
    ""central_index_key"": ""0001326380"",
    ""registrant_name"": ""GAMESTOP CORP"",
    ""settlement_date"": ""2024-01-15"",
    ""short_interest"": 45000000,
    ""average_daily_volume"": 8500000,
    ""days_to_cover"": 5.29,
    ""percent_of_float"": 15.5
}";
            using var doc = JsonDocument.Parse(json);
            var shortInterest = FinancialDataSerializer.Instance.Deserialize<ShortInterest>(doc);
            Assert.AreEqual("GME", shortInterest.TradingSymbol);
            Assert.AreEqual(45000000m, shortInterest.ShortedSecurities);
            Assert.AreEqual(8500000m, shortInterest.AverageDailyVolume);
            Assert.AreEqual(5.29m, shortInterest.DaysToCover);
        }
    }
}
