using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class DividendsCalendarTests
    {
        [TestMethod]
        public void DividendsCalendar_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""JNJ"",
    ""central_index_key"": ""0000200406"",
    ""registrant_name"": ""JOHNSON & JOHNSON"",
    ""ex_dividend_date"": ""2024-02-26""
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<DividendsCalendar>(doc);
            Assert.AreEqual("JNJ", calendar.TradingSymbol);
        }
    }
}
