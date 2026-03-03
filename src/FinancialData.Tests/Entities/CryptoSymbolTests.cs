using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class CryptoSymbolTests
    {
        [TestMethod]
        public void CryptoSymbol_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""BTC-USD"",
    ""name"": ""Bitcoin""
}";
            using var doc = JsonDocument.Parse(json);
            var cryptoSymbol = FinancialDataSerializer.Instance.Deserialize<CryptoSymbol>(doc);
            Assert.AreEqual("BTC-USD", cryptoSymbol.TradingSymbol);
            Assert.AreEqual("Bitcoin", cryptoSymbol.Name);
        }
    }
}
