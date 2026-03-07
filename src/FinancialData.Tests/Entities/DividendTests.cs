using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class DividendTests
    {
        [TestMethod]
        public void Dividend_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""KO"",
    ""registrant_name"": ""COCA COLA CO"",
    ""type"": ""Quarterly"",
    ""amount"": 0.485,
    ""declaration_date"": ""2024-02-13"",
    ""ex_date"": ""2024-03-14"",
    ""record_date"": ""2024-03-15"",
    ""payment_date"": ""2024-04-01""
}";
            using var doc = JsonDocument.Parse(json);
            var dividend = FinancialDataSerializer.Instance.Deserialize<Dividend>(doc);
            Assert.AreEqual("KO", dividend.TradingSymbol);
            Assert.AreEqual("COCA COLA CO", dividend.RegistrantName);
            Assert.AreEqual("Quarterly", dividend.Type);
            Assert.AreEqual(0.485m, dividend.Amount);
            Assert.AreEqual(new DateOnly(2024, 2, 13), dividend.DeclarationDate);
            Assert.AreEqual(new DateOnly(2024, 3, 14), dividend.ExDate);
            Assert.AreEqual(new DateOnly(2024, 3, 15), dividend.RecordDate);
            Assert.AreEqual(new DateOnly(2024, 4, 1), dividend.PaymentDate);
        }
    }
}
