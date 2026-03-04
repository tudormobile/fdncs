using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class IndexSymbolTests
    {
        [TestMethod]
        public void IndexSymbol_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""000001.SS"",
    ""index_name"": ""SSE Composite Index""
}";
            using var doc = JsonDocument.Parse(json);
            var indexSymbol = FinancialDataSerializer.Instance.Deserialize<IndexSymbol>(doc);
            Assert.AreEqual("000001.SS", indexSymbol.TradingSymbol);
            Assert.AreEqual("SSE Composite Index", indexSymbol.IndexName);
        }
    }
}
