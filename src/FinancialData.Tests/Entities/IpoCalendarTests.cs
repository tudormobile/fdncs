using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class IpoCalendarTests
    {
        [TestMethod]
        public void IpoCalendar_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""RDDT"",
    ""registrant_name"": ""Reddit, Inc."",
    ""exchange"": ""NYSE"",
    ""ipo_date"": ""2024-03-21"",
    ""share_price"": 34.00,
    ""shares_offered"": 22000000,
    ""offering_value"": 748000000
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<IpoCalendar>(doc);
            Assert.AreEqual("RDDT", calendar.TradingSymbol);
            Assert.AreEqual("Reddit, Inc.", calendar.RegistrantName);
            Assert.AreEqual("NYSE", calendar.Exchange);
            Assert.AreEqual(new DateOnly(2024, 3, 21), calendar.IpoDate);
            Assert.AreEqual(34.00m, calendar.SharePrice);
            Assert.AreEqual(22000000m, calendar.SharesOffered);
            Assert.AreEqual(748000000m, calendar.OfferingValue);
        }
    }
}
