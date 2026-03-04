using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class OptionGreeksTests
    {
        [TestMethod]
        public void OptionGreeks_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""contract_name"": ""AAPL240119C00180000"",
    ""date"": ""2024-01-15"",
    ""delta"": 0.65,
    ""gamma"": 0.025,
    ""theta"": -0.08,
    ""vega"": 0.15,
    ""rho"": 0.05
}";
            using var doc = JsonDocument.Parse(json);
            var greeks = FinancialDataSerializer.Instance.Deserialize<OptionGreeks>(doc);
            Assert.AreEqual("AAPL240119C00180000", greeks.ContractName);
            Assert.AreEqual(new DateOnly(2024, 1, 15), greeks.Date);
            Assert.AreEqual(0.65m, greeks.Delta);
            Assert.AreEqual(0.025m, greeks.Gamma);
            Assert.AreEqual(-0.08m, greeks.Theta);
            Assert.AreEqual(0.15m, greeks.Vega);
            Assert.AreEqual(0.05m, greeks.Rho);
        }
    }
}
