using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class CryptoInformationTests
    {
        [TestMethod]
        public void CryptoInformation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""BTC-USD"",
    ""name"": ""Bitcoin"",
    ""website"": ""https://bitcoin.org"",
    ""description"": ""Bitcoin is a decentralized digital currency."",
    ""founding_date"": ""2009-01-03"",
    ""founder"": ""Satoshi Nakamoto""
}";
            using var doc = JsonDocument.Parse(json);
            var cryptoInfo = FinancialDataSerializer.Instance.Deserialize<CryptoInformation>(doc);
            Assert.AreEqual("BTC-USD", cryptoInfo.TradingSymbol);
            Assert.AreEqual("Bitcoin", cryptoInfo.Name);
            Assert.AreEqual("https://bitcoin.org", cryptoInfo.Website);
            Assert.AreEqual("Bitcoin is a decentralized digital currency.", cryptoInfo.Description);
            Assert.AreEqual("2009-01-03", cryptoInfo.FoundingDate);
            Assert.AreEqual("Satoshi Nakamoto", cryptoInfo.Founder);
        }
    }
}
