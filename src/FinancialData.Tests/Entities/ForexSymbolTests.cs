using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ForexSymbolTests
    {
        [TestMethod]
        public void ForexSymbol_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""EUR/USD"",
    ""name"": ""Euro / US Dollar""
}";
            using var doc = JsonDocument.Parse(json);
            var forexSymbol = FinancialDataSerializer.Instance.Deserialize<ForexSymbol>(doc);
            Assert.AreEqual("EUR/USD", forexSymbol.TradingSymbol);
            Assert.AreEqual("Euro / US Dollar", forexSymbol.Name);
        }
    }
}
