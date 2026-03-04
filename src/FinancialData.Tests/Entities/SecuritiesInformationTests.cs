using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class SecuritiesInformationTests
    {
        [TestMethod]
        public void SecuritiesInformation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""IBM"",
    ""issuer_name"": ""INTERNATIONAL BUSINESS MACHINES CORP"",
    ""cusip_number"": ""459200101"",
    ""isin_number"": ""US4592001014"",
    ""figi_identifier"": ""BBG000BLNNH6"",
    ""security_type"": ""Common Stock""
}";
            using var doc = JsonDocument.Parse(json);
            var securities = FinancialDataSerializer.Instance.Deserialize<SecuritiesInformation>(doc);
            Assert.AreEqual("IBM", securities.TradingSymbol);
            Assert.AreEqual("INTERNATIONAL BUSINESS MACHINES CORP", securities.IssuerName);
            Assert.AreEqual("459200101", securities.CusipNumber);
            Assert.AreEqual("US4592001014", securities.IsinNumber);
            Assert.AreEqual("BBG000BLNNH6", securities.FigiIdentifier);
            Assert.AreEqual("Common Stock", securities.SecurityType);
        }
    }
}
