using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

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
    ""registrant_name"": ""Shell plc"",
    ""isin_number"": ""GB00BP6MXD84"",
    ""lei_number"": ""21380068P1DRHMJ8KU70"",
    ""exchange"": ""LSE"",
    ""phone_number"": ""+44 20 7934 1234"",
    ""website"": ""https://www.shell.com"",
    ""number_of_employees"": 93000
}";
            using var doc = JsonDocument.Parse(json);
            var info = FinancialDataSerializer.Instance.Deserialize<InternationalCompanyInformation>(doc);
            Assert.AreEqual("SHEL.L", info.TradingSymbol);
            Assert.AreEqual("Shell plc", info.RegistrantName);
            Assert.AreEqual("GB00BP6MXD84", info.IsinNumber);
            Assert.AreEqual(93000, info.NumberOfEmployees);
        }
    }
}
