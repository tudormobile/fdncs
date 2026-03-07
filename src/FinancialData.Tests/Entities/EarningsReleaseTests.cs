using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EarningsReleaseTests
    {
        [TestMethod]
        public void EarningsRelease_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""NVDA"",
    ""central_index_key"": ""0001045810"",
    ""registrant_name"": ""NVIDIA CORP"",
    ""market_cap"": 1500000000000.0,
    ""fiscal_quarter_end_date"": ""2024-01-28"",
    ""earnings_per_share"": 5.16,
    ""earnings_per_share_forecast"": 4.64,
    ""percentage_surprise"": 11.2,
    ""number_of_forecasts"": 35,
    ""conference_call_time"": ""2024-02-21 17:00:00""
}";
            using var doc = JsonDocument.Parse(json);
            var earnings = FinancialDataSerializer.Instance.Deserialize<EarningsRelease>(doc);
            Assert.AreEqual("NVDA", earnings.TradingSymbol);
            Assert.AreEqual("0001045810", earnings.CentralIndexKey);
            Assert.AreEqual("NVIDIA CORP", earnings.RegistrantName);
            Assert.AreEqual(1500000000000m, earnings.MarketCap);
            Assert.AreEqual("2024-01-28", earnings.FiscalQuarterEndDate);
            Assert.AreEqual(5.16m, earnings.EarningsPerShare);
            Assert.AreEqual(4.64m, earnings.EarningsPerShareForecast);
            Assert.AreEqual(11.2m, earnings.PercentageSurprise);
            Assert.AreEqual(35, earnings.NumberOfForecasts);
            Assert.AreEqual(new DateTime(2024, 2, 21, 17, 0, 0), earnings.ConferenceCallTime);
        }
    }
}
