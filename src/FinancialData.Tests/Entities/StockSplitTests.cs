using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class StockSplitTests
    {
        [TestMethod]
        public void StockSplit_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""TSLA"",
    ""central_index_key"": ""0001318605"",
    ""registrant_name"": ""Tesla, Inc."",
    ""execution_date"": ""2022-08-25"",
    ""split_ratio"": ""3:1""
}";
            using var doc = JsonDocument.Parse(json);
            var split = FinancialDataSerializer.Instance.Deserialize<StockSplit>(doc);
            Assert.AreEqual("TSLA", split.TradingSymbol);
        }
    }
}
