using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class OptionPriceTests
    {
        [TestMethod]
        public void OptionPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""contract_name"": ""AAPL240119C00180000"",
    ""date"": ""2024-01-15"",
    ""open"": 8.50,
    ""high"": 9.20,
    ""low"": 8.30,
    ""close"": 9.00,
    ""volume"": 5000
}";
            using var doc = JsonDocument.Parse(json);
            var optionPrice = FinancialDataSerializer.Instance.Deserialize<OptionPrice>(doc);
            Assert.AreEqual("AAPL240119C00180000", optionPrice.ContractName);
            Assert.AreEqual(8.50m, optionPrice.Open);
            Assert.AreEqual(9.20m, optionPrice.High);
            Assert.AreEqual(9.00m, optionPrice.Close);
        }
    }
}
