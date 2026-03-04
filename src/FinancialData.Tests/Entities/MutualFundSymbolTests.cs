using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class MutualFundSymbolTests
    {
        [TestMethod]
        public void MutualFundSymbol_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAAAX"",
    ""fund_name"": ""DWS RREEF Real Assets Fund, Class A""
}";
            using var doc = JsonDocument.Parse(json);
            var mutualFundSymbol = FinancialDataSerializer.Instance.Deserialize<MutualFundSymbol>(doc);
            Assert.AreEqual("AAAAX", mutualFundSymbol.TradingSymbol);
            Assert.AreEqual("DWS RREEF Real Assets Fund, Class A", mutualFundSymbol.FundName);
        }
    }
}
