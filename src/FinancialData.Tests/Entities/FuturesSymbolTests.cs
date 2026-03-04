using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class FuturesSymbolTests
    {
        [TestMethod]
        public void FuturesSymbol_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""ES"",
    ""description"": ""E-mini S&P 500 Futures"",
    ""type"": ""Index Futures""
}";
            using var doc = JsonDocument.Parse(json);
            var futuresSymbol = FinancialDataSerializer.Instance.Deserialize<FuturesSymbol>(doc);
            Assert.AreEqual("ES", futuresSymbol.TradingSymbol);
            Assert.AreEqual("E-mini S&P 500 Futures", futuresSymbol.Description);
            Assert.AreEqual("Index Futures", futuresSymbol.Type);
        }
    }
}
