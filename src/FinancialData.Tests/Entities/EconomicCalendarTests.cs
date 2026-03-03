using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EconomicCalendarTests
    {
        [TestMethod]
        public void EconomicCalendar_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""event_date"": ""2024-02-15"",
    ""event_time"": ""08:30:00"",
    ""country"": ""United States"",
    ""event_name"": ""CPI Release"",
    ""actual"": 3.1,
    ""forecast"": 2.9,
    ""previous"": 3.4
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<EconomicCalendar>(doc);
            Assert.AreEqual("United States", calendar.Country);
            Assert.AreEqual("CPI Release", calendar.EventName);
            Assert.AreEqual(3.1m, calendar.ActualValue);
        }
    }
}
