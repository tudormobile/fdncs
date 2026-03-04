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
    ""title_of_security"": ""GAMESTOP CORP"",
    ""market_code"": ""NYSE"",
    ""settlement_date"": ""2024-01-15"",
    ""shorted_securities"": 45000000,
    ""previous_shorted_securities"": 50000000,
    ""change_in_shorted_securities"": -5000000,
    ""percentage_change_in_shorted_securities"": -10.0,
    ""average_daily_volume"": 8500000,
    ""days_to_cover"": 5.29,
    ""is_stock_split"": false
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
