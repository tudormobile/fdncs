using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class SecPressReleaseTests
    {
        [TestMethod]
        public void SecPressRelease_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""date_time"": ""2024-01-15 12:00:00"",
    ""headline"": ""SEC Charges Company with Accounting Fraud"",
    ""text"": ""The Securities and Exchange Commission today announced..."",
    ""url"": ""https://www.sec.gov/news/press-release/""
}";
            using var doc = JsonDocument.Parse(json);
            var secPressRelease = FinancialDataSerializer.Instance.Deserialize<SecPressRelease>(doc);
            Assert.AreEqual(new DateTime(2024, 1, 15, 12, 0, 0), secPressRelease.DateTime);
            Assert.AreEqual("SEC Charges Company with Accounting Fraud", secPressRelease.Headline);
            Assert.AreEqual("The Securities and Exchange Commission today announced...", secPressRelease.Text);
            Assert.AreEqual("https://www.sec.gov/news/press-release/", secPressRelease.Url);
        }
    }
}
