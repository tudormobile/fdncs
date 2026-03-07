using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class SplitsCalendarTests
    {
        [TestMethod]
        public void SplitsCalendar_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""LINK"",
    ""registrant_name"": ""INTERLINK ELECTRONICS INC"",
    ""execution_date"": ""2025-10-29"",
    ""multiplier"": 1.5
  }";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<SplitsCalendar>(doc);
            Assert.AreEqual("LINK", calendar.TradingSymbol);
            Assert.AreEqual("INTERLINK ELECTRONICS INC", calendar.RegistrantName);
            Assert.AreEqual(new DateOnly(2025, 10, 29), calendar.ExecutionDate);
            Assert.AreEqual(1.5m, calendar.Multiplier);
        }
    }
}
