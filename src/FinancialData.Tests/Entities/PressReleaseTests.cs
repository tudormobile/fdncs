using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class PressReleaseTests
    {
        [TestMethod]
        public void PressRelease_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""TSLA"",
    ""central_index_key"": ""0001318605"",
    ""registrant_name"": ""Tesla, Inc."",
    ""date_time"": ""2024-01-24 16:30:00"",
    ""headline"": ""Tesla Reports Q4 2023 Results"",
    ""text"": ""Tesla announced fourth quarter results..."",
    ""url"": ""https://ir.tesla.com/press-release/""
}";
            using var doc = JsonDocument.Parse(json);
            var pressRelease = FinancialDataSerializer.Instance.Deserialize<PressRelease>(doc);
            Assert.AreEqual("TSLA", pressRelease.TradingSymbol);
            Assert.AreEqual("0001318605", pressRelease.CentralIndexKey);
            Assert.AreEqual("Tesla, Inc.", pressRelease.RegistrantName);
            Assert.AreEqual(new DateTime(2024, 1, 24, 16, 30, 0), pressRelease.DateTime);
            Assert.AreEqual("Tesla Reports Q4 2023 Results", pressRelease.Headline);
            Assert.AreEqual("Tesla announced fourth quarter results...", pressRelease.Text);
            Assert.AreEqual("https://ir.tesla.com/press-release/", pressRelease.Url);
        }
    }
}
