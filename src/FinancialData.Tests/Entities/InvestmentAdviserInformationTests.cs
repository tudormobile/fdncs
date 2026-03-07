using System.Text.Json;
using Tudormobile.FinancialData.Entities;

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
    ""address_street"": ""50 Hudson Yards"",
    ""address_city"": ""New York"",
    ""address_state"": ""NY"",
    ""address_zip_code"": ""10001"",
    ""address_country"": ""United States"",
    ""phone_number"": ""212-810-5300"",
    ""website"": ""https://www.blackrock.com"",
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
            Assert.AreEqual("801-10746", adviser.SecFileNumber);
            Assert.AreEqual("BlackRock, Inc.", adviser.FirmName);
            Assert.AreEqual(new DateOnly(2024, 1, 15), adviser.FilingDate);
            Assert.AreEqual("50 Hudson Yards", adviser.AddressStreet);
            Assert.AreEqual("New York", adviser.AddressCity);
            Assert.AreEqual("NY", adviser.AddressState);
            Assert.AreEqual("10001", adviser.AddressZipCode);
            Assert.AreEqual("United States", adviser.AddressCountry);
            Assert.AreEqual("212-810-5300", adviser.PhoneNumber);
            Assert.AreEqual("https://www.blackrock.com", adviser.Website);
            Assert.AreEqual(10000000000000m, adviser.AssetsUnderManagement);
            Assert.AreEqual(19800, adviser.NumberOfEmployees);
            Assert.AreEqual(2500, adviser.NumberOfClients);
            Assert.AreEqual(150, adviser.HighNetWorthClients);
            Assert.IsTrue(adviser.IsRegisteredInvestmentCompany);
            Assert.IsFalse(adviser.IsPrivateFund);
        }
    }
}
