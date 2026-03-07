using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class DividendsCalendarTests
    {
        [TestMethod]
        public void DividendsCalendar_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""APOG"",
    ""registrant_name"": ""APOGEE ENTERPRISES, INC."",
    ""amount"": 0.26,
    ""declaration_date"": ""2025-10-09"",
    ""ex_date"": ""2025-10-29"",
    ""record_date"": ""2025-10-29"",
    ""payment_date"": ""2025-11-13""
  }";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<DividendsCalendar>(doc);
            Assert.AreEqual("APOG", calendar.TradingSymbol);
            Assert.AreEqual("APOGEE ENTERPRISES, INC.", calendar.RegistrantName);
            Assert.AreEqual(0.26m, calendar.Amount);
            Assert.AreEqual(new DateOnly(2025, 10, 9), calendar.DeclarationDate);
            Assert.AreEqual(new DateOnly(2025, 10, 29), calendar.ExDate);
            Assert.AreEqual(new DateOnly(2025, 10, 29), calendar.RecordDate);
            Assert.AreEqual(new DateOnly(2025, 11, 13), calendar.PaymentDate);
        }
    }
}
