using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EmployeeCountTests
    {
        [TestMethod]
        public void EmployeeCount_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""GOOGL"",
    ""central_index_key"": ""0001652044"",
    ""registrant_name"": ""Alphabet Inc."",
    ""fiscal_year"": ""2023"",
    ""count"": 182502
}";
            using var doc = JsonDocument.Parse(json);
            var employeeCount = FinancialDataSerializer.Instance.Deserialize<EmployeeCount>(doc);
            Assert.AreEqual("GOOGL", employeeCount.TradingSymbol);
            Assert.AreEqual("0001652044", employeeCount.CentralIndexKey);
            Assert.AreEqual("Alphabet Inc.", employeeCount.RegistrantName);
            Assert.AreEqual("2023", employeeCount.FiscalYear);
            Assert.AreEqual(182502, employeeCount.Count);
        }
    }
}
