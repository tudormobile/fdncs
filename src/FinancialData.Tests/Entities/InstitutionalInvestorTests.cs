using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InstitutionalInvestorTests
    {
        [TestMethod]
        public void InstitutionalInvestor_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""investor_cik"": ""0001067983"",
    ""investor_name"": ""BERKSHIRE HATHAWAY INC""
}";
            using var doc = JsonDocument.Parse(json);
            var investor = FinancialDataSerializer.Instance.Deserialize<InstitutionalInvestor>(doc);
            Assert.AreEqual("0001067983", investor.InvestorCik);
            Assert.AreEqual("BERKSHIRE HATHAWAY INC", investor.InvestorName);
        }
    }
}
