using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class CompanyInformationTests
    {
        [TestMethod]
        public void CompanyInformation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""central_index_key"": ""0000789019"",
    ""registrant_name"": ""MICROSOFT CORP"",
    ""isin_number"": ""US5949181045"",
    ""lei_number"": null,
    ""ein_number"": ""911144442"",
    ""exchange"": ""Nasdaq"",
    ""sic_code"": ""7372"",
    ""sic_description"": ""Services-Prepackaged Software"",
    ""fiscal_year_end"": ""0630"",
    ""state_of_incorporation"": ""WA"",
    ""address_street"": ""ONE MICROSOFT WAY"",
    ""address_city"": ""REDMOND"",
    ""address_state"": ""WA"",
    ""address_zip_code"": ""98052-6399"",
    ""address_country"": ""UNITED STATES"",
    ""address_country_code"": ""US"",
    ""phone_number"": ""425-882-8080"",
    ""mailing_address"": ""ONE MICROSOFT WAY, REDMOND, WA, 98052-6399"",
    ""business_address"": ""ONE MICROSOFT WAY, REDMOND, WA, 98052-6399"",
    ""former_name"": null,
    ""industry"": ""Information technology"",
    ""founding_date"": ""1975-04-04"",
    ""chief_executive_officer"": ""Satya Nadella"",
    ""number_of_employees"": 228000,
    ""website"": ""https://www.microsoft.com/"",
    ""market_cap"": 2800000000000.0,
    ""shares_issued"": null,
    ""shares_outstanding"": 7434880776,
    ""description"": ""Microsoft Corporation is an American multinational technology conglomerate headquartered in Redmond, Washington. Founded in 1975, the company became highly influential in the rise of personal computers through software like Windows, and the company has since expanded to Internet services, cloud computing, video gaming and other fields. Microsoft is the largest software maker, one of the most valuable public U.S. companies, and one of the most valuable brands globally.""
  }";
            using var doc = JsonDocument.Parse(json);
            var companyInfo = FinancialDataSerializer.Instance.Deserialize<CompanyInformation>(doc);
            Assert.AreEqual("MSFT", companyInfo.TradingSymbol);
            Assert.AreEqual("0000789019", companyInfo.CentralIndexKey);
            Assert.AreEqual("MICROSOFT CORP", companyInfo.RegistrantName);
            Assert.AreEqual("US5949181045", companyInfo.IsinNumber);
            Assert.IsNull(companyInfo.LeiNumber);
            Assert.AreEqual("911144442", companyInfo.EinNumber);
            Assert.AreEqual("Nasdaq", companyInfo.Exchange);
            Assert.AreEqual("7372", companyInfo.SicCode);
            Assert.AreEqual("Services-Prepackaged Software", companyInfo.SicDescription);
            Assert.AreEqual("0630", companyInfo.FiscalYearEnd);
            Assert.AreEqual("WA", companyInfo.StateOfIncorporation);
            Assert.AreEqual("ONE MICROSOFT WAY", companyInfo.AddressStreet);
            Assert.AreEqual("REDMOND", companyInfo.AddressCity);
            Assert.AreEqual("WA", companyInfo.AddressState);
            Assert.AreEqual("98052-6399", companyInfo.AddressZipCode);
            Assert.AreEqual("UNITED STATES", companyInfo.AddressCountry);
            Assert.AreEqual("US", companyInfo.AddressCountryCode);
            Assert.AreEqual("425-882-8080", companyInfo.PhoneNumber);
            Assert.AreEqual("ONE MICROSOFT WAY, REDMOND, WA, 98052-6399", companyInfo.MailingAddress);
            Assert.AreEqual("ONE MICROSOFT WAY, REDMOND, WA, 98052-6399", companyInfo.BusinessAddress);
            Assert.IsNull(companyInfo.FormerName);
            Assert.AreEqual("Information technology", companyInfo.Industry);
            Assert.AreEqual("1975-04-04", companyInfo.FoundingDate);
            Assert.AreEqual("Satya Nadella", companyInfo.ChiefExecutiveOfficer);
            Assert.AreEqual(228000, companyInfo.NumberOfEmployees);
            Assert.AreEqual("https://www.microsoft.com/", companyInfo.Website);
            Assert.AreEqual(2800000000000m, companyInfo.MarketCap);
            Assert.AreEqual(0m, companyInfo.SharesIssued);
            Assert.AreEqual(7434880776m, companyInfo.SharesOutstanding);
            Assert.AreEqual("Microsoft Corporation is an American multinational technology conglomerate headquartered in Redmond, Washington. Founded in 1975, the company became highly influential in the rise of personal computers through software like Windows, and the company has since expanded to Internet services, cloud computing, video gaming and other fields. Microsoft is the largest software maker, one of the most valuable public U.S. companies, and one of the most valuable brands globally.", companyInfo.Description);
        }
    }
}
