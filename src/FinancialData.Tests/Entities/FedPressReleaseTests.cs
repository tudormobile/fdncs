using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class FedPressReleaseTests
    {
        [TestMethod]
        public void FedPressRelease_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""date_time"": ""2024-01-31 14:00:00"",
    ""headline"": ""Federal Reserve maintains target range for federal funds rate"",
    ""text"": ""The Federal Open Market Committee decided today..."",
    ""url"": ""https://www.federalreserve.gov/newsevents/pressreleases/""
}";
            using var doc = JsonDocument.Parse(json);
            var fedPressRelease = FinancialDataSerializer.Instance.Deserialize<FedPressRelease>(doc);
            Assert.AreEqual("Federal Reserve maintains target range for federal funds rate", fedPressRelease.Headline);
            Assert.AreEqual("https://www.federalreserve.gov/newsevents/pressreleases/", fedPressRelease.Url);
        }
    }
}
