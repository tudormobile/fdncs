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
    ""trading_symbol"": ""NVDA"",
    ""central_index_key"": ""0001045810"",
    ""registrant_name"": ""NVIDIA CORP"",
    ""execution_date"": ""2024-06-10""
}";
            using var doc = JsonDocument.Parse(json);
            var calendar = FinancialDataSerializer.Instance.Deserialize<SplitsCalendar>(doc);
            Assert.AreEqual("NVDA", calendar.TradingSymbol);
        }
    }
}
