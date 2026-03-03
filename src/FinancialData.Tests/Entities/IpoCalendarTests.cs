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
    ""central_index_key"": ""0001713445"",
    ""registrant_name"": ""Reddit, Inc."",
    ""ipo_date"": ""2024-03-21""
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<IpoCalendar>(doc);
            Assert.AreEqual("RDDT", calendar.TradingSymbol);
        }
    }
}
