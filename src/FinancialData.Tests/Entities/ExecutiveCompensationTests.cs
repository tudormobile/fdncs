using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ExecutiveCompensationTests
    {
        [TestMethod]
        public void ExecutiveCompensation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""central_index_key"": ""0000320193"",
    ""registrant_name"": ""Apple Inc."",
    ""fiscal_year"": ""2023"",
    ""executive_name"": ""Tim Cook"",
    ""executive_title"": ""CEO"",
    ""salary"": 3000000.0,
    ""bonus"": 12000000.0,
    ""stock_awards"": 82000000.0,
    ""option_awards"": 0.0,
    ""non_equity_incentive_plan_compensation"": 10000000.0,
    ""all_other_compensation"": 1500000.0,
    ""total_compensation"": 108500000.0
}";
            using var doc = JsonDocument.Parse(json);
            var compensation = FinancialDataSerializer.Instance.Deserialize<ExecutiveCompensation>(doc);
            Assert.AreEqual("AAPL", compensation.TradingSymbol);
            Assert.AreEqual("Tim Cook", compensation.ExecutiveName);
            Assert.AreEqual(3000000m, compensation.Salary);
            Assert.AreEqual(108500000m, compensation.TotalCompensation);
        }
    }
}
