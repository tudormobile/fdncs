using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EarningsCalendarTests
    {
        [TestMethod]
        public void EarningsCalendar_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""XOM"",
    ""registrant_name"": ""EXXON MOBIL CORP"",
    ""fiscal_quarter_end_date"": ""2025-09"",
    ""report_date"": ""2025-10-31"",
    ""conference_call_time"": ""2025-10-31 08:30:00"",
    ""earnings_per_share_forecast"": 1.78
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<EarningsCalendar>(doc);
            Assert.AreEqual("XOM", calendar.TradingSymbol);
            Assert.AreEqual("EXXON MOBIL CORP", calendar.RegistrantName);
            Assert.AreEqual("2025-09", calendar.FiscalQuarterEndDate);
            Assert.AreEqual(new DateOnly(2025, 10, 31), calendar.ReportDate);
            Assert.AreEqual(new DateTime(2025, 10, 31, 8, 30, 0), calendar.ConferenceCallTime);
            Assert.AreEqual(1.78m, calendar.EarningsPerShareForecast);
        }
    }
}
