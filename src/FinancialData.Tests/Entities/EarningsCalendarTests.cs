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
    ""trading_symbol"": ""AAPL"",
    ""registrant_name"": ""Apple Inc."",
    ""report_date"": ""2024-02-01""
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<EarningsCalendar>(doc);
            Assert.AreEqual("AAPL", calendar.TradingSymbol);
            Assert.AreEqual("Apple Inc.", calendar.RegistrantName);
            Assert.AreEqual(new DateOnly(2024, 2, 1), calendar.ReportDate);
        }
    }
}
