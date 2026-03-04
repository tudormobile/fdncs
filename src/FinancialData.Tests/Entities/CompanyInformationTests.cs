using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class CompanyInformationTests
    {
        [TestMethod]
        public void CompanyInformation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""central_index_key"": ""0000320193"",
    ""registrant_name"": ""Apple Inc."",
    ""isin_number"": ""US0378331005"",
    ""lei_number"": ""HWUPKR0MPOU8FGXBT394"",
    ""ein_number"": ""942404110"",
    ""exchange"": ""NASDAQ"",
    ""sic_code"": ""3571"",
    ""sic_description"": ""Electronic Computers"",
    ""fiscal_year_end"": ""0930"",
    ""state_of_incorporation"": ""CA"",
    ""phone_number"": ""(408) 996-1010"",
    ""industry"": ""Technology"",
    ""website"": ""https://www.apple.com"",
    ""market_cap"": 2800000000000.0,
    ""shares_issued"": null,
    ""shares_outstanding"": 15550000000.0,
    ""number_of_employees"": 161000
}";
            using var doc = JsonDocument.Parse(json);
            var companyInfo = FinancialDataSerializer.Instance.Deserialize<CompanyInformation>(doc);
            Assert.AreEqual("AAPL", companyInfo.TradingSymbol);
            Assert.AreEqual("0000320193", companyInfo.CentralIndexKey);
            Assert.AreEqual("Apple Inc.", companyInfo.RegistrantName);
            Assert.AreEqual("US0378331005", companyInfo.IsinNumber);
            Assert.AreEqual("HWUPKR0MPOU8FGXBT394", companyInfo.LeiNumber);
            Assert.AreEqual("942404110", companyInfo.EinNumber);
            Assert.AreEqual("NASDAQ", companyInfo.Exchange);
            Assert.AreEqual("3571", companyInfo.SicCode);
            Assert.AreEqual("Electronic Computers", companyInfo.SicDescription);
            Assert.AreEqual("0930", companyInfo.FiscalYearEnd);
            Assert.AreEqual("CA", companyInfo.StateOfIncorporation);
            Assert.AreEqual("(408) 996-1010", companyInfo.PhoneNumber);
            Assert.AreEqual("Technology", companyInfo.Industry);
            Assert.AreEqual("https://www.apple.com", companyInfo.Website);
            Assert.AreEqual(2800000000000m, companyInfo.MarketCap);
            Assert.AreEqual(0m, companyInfo.SharesIssued);
            Assert.AreEqual(15550000000m, companyInfo.SharesOutstanding);
            Assert.AreEqual(161000, companyInfo.NumberOfEmployees);
        }
    }
}
