using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class ExecutiveCompensationTests
    {
        [TestMethod]
        public void ExecutiveCompensation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""central_index_key"": ""0000789019"",
    ""registrant_name"": ""MICROSOFT CORP"",
    ""executive_name"": ""Christopher D. Young"",
    ""executive_position"": ""Executive Vice President"",
    ""fiscal_year"": ""2024"",
    ""salary"": 850000.0,
    ""bonus"": 0.0,
    ""stock_awards"": 9040931.0,
    ""incentive_plan_compensation"": 2023680.0,
    ""other_compensation"": 120092.0,
    ""total_compensation"": 12034703.0
  }";
            using var doc = JsonDocument.Parse(json);
            var compensation = FinancialDataSerializer.Instance.Deserialize<ExecutiveCompensation>(doc);
            Assert.AreEqual("MSFT", compensation.TradingSymbol);
            Assert.AreEqual("0000789019", compensation.CentralIndexKey);
            Assert.AreEqual("MICROSOFT CORP", compensation.RegistrantName);
            Assert.AreEqual("2024", compensation.FiscalYear);
            Assert.AreEqual("Christopher D. Young", compensation.ExecutiveName);
            Assert.AreEqual("Executive Vice President", compensation.ExecutivePosition);
            Assert.AreEqual(850000m, compensation.Salary);
            Assert.AreEqual(0m, compensation.Bonus);
            Assert.AreEqual(9040931m, compensation.StockAwards);
            Assert.AreEqual(2023680m, compensation.IncentivePlanCompensation);
            Assert.AreEqual(120092m, compensation.OtherCompensation);
            Assert.AreEqual(12034703m, compensation.TotalCompensation);
        }
    }
}
