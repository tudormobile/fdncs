using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InternationalCompanyInformationTests
    {
        [TestMethod]
        public void InternationalCompanyInformation_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""SHEL.L"",
    ""registrant_name"": ""Shell PLC"",
    ""exchange"": ""London Stock Exchange"",
    ""isin_number"": ""GB00BP6MXD84"",
    ""industry"": ""Energy"",
    ""founding_date"": ""1907"",
    ""chief_executive_officer"": ""Wael Sawan"",
    ""number_of_employees"": 90000,
    ""website"": ""https://www.shell.com/"",
    ""description"": ""Shell PLC is a British multinational oil and gas company, headquartered in London, England. Shell is a public limited company with a primary listing on the London Stock Exchange (LSE) and secondary listings on Euronext Amsterdam and the New York Stock Exchange. A core component of Big Oil, Shell is the second largest investor-owned oil and gas company in the world by revenue (after ExxonMobil), and among the world's largest companies out of any industry. Measured by both its own emissions, and the emissions of all the fossil fuels it sells, Shell was the ninth-largest corporate producer of greenhouse gas emissions in the period 1988–2015.""
  }";
            using var doc = JsonDocument.Parse(json);
            var info = FinancialDataSerializer.Instance.Deserialize<InternationalCompanyInformation>(doc);
            Assert.AreEqual("SHEL.L", info.TradingSymbol);
            Assert.AreEqual("Shell PLC", info.RegistrantName);
            Assert.AreEqual("London Stock Exchange", info.Exchange);
            Assert.AreEqual("GB00BP6MXD84", info.IsinNumber);
            Assert.AreEqual("Energy", info.Industry);
            Assert.AreEqual("1907", info.FoundingDate);
            Assert.AreEqual("Wael Sawan", info.ChiefExecutiveOfficer);
            Assert.AreEqual(90000, info.NumberOfEmployees);
            Assert.AreEqual("https://www.shell.com/", info.Website);
            Assert.AreEqual("Shell PLC is a British multinational oil and gas company, headquartered in London, England. Shell is a public limited company with a primary listing on the London Stock Exchange (LSE) and secondary listings on Euronext Amsterdam and the New York Stock Exchange. A core component of Big Oil, Shell is the second largest investor-owned oil and gas company in the world by revenue (after ExxonMobil), and among the world's largest companies out of any industry. Measured by both its own emissions, and the emissions of all the fossil fuels it sells, Shell was the ninth-largest corporate producer of greenhouse gas emissions in the period 1988–2015.", info.Description);
        }
    }
}
