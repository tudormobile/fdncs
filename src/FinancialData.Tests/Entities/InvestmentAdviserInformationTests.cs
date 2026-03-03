using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InvestmentAdviserInformationTests
    {
        [TestMethod]
        public void InvestmentAdviserInformation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""crd_number"": ""107665"",
    ""sec_file_number"": ""801-10746"",
    ""firm_name"": ""BlackRock, Inc."",
    ""filing_date"": ""2024-01-15"",
    ""assets_under_management"": 10000000000000.0,
    ""number_of_employees"": 19800,
    ""number_of_clients"": 2500,
    ""high_net_worth_clients"": 150,
    ""is_registered_investment_company"": true,
    ""is_private_fund"": false
}";
            using var doc = JsonDocument.Parse(json);
            var adviser = FinancialDataSerializer.Instance.Deserialize<InvestmentAdviserInformation>(doc);
            Assert.AreEqual("107665", adviser.CrdNumber);
            Assert.AreEqual("BlackRock, Inc.", adviser.FirmName);
            Assert.AreEqual(10000000000000m, adviser.AssetsUnderManagement);
            Assert.AreEqual(19800, adviser.NumberOfEmployees);
            Assert.AreEqual(2500, adviser.NumberOfClients);
            Assert.IsTrue(adviser.IsRegisteredInvestmentCompany);
            Assert.IsFalse(adviser.IsPrivateFund);
        }
    }
}
