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
    ""event_name"": ""CPI Release"",
    ""country"": ""United States"",
    ""country_code"": ""US"",
    ""time"": ""2024-02-15 08:30:00"",
    ""previous_value"": 3.4,
    ""actual_value"": 3.1
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<EconomicCalendar>(doc);
            Assert.AreEqual("CPI Release", calendar.EventName);
            Assert.AreEqual("United States", calendar.Country);
            Assert.AreEqual("US", calendar.CountryCode);
            Assert.AreEqual(new DateTime(2024, 2, 15, 8, 30, 0), calendar.Time);
            Assert.AreEqual(3.4m, calendar.PreviousValue);
            Assert.AreEqual(3.1m, calendar.ActualValue);
        }
    }
}
