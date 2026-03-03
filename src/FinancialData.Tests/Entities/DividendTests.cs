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
    ""central_index_key"": ""0000021344"",
    ""registrant_name"": ""COCA COLA CO"",
    ""declaration_date"": ""2024-02-13"",
    ""ex_dividend_date"": ""2024-03-14"",
    ""record_date"": ""2024-03-15"",
    ""payment_date"": ""2024-04-01"",
    ""dividend_amount"": 0.485,
    ""dividend_type"": ""Quarterly""
}";
            using var doc = JsonDocument.Parse(json);
            var dividend = FinancialDataSerializer.Instance.Deserialize<Dividend>(doc);
            Assert.AreEqual("KO", dividend.TradingSymbol);
            Assert.AreEqual(0.485m, dividend.Amount);
            Assert.AreEqual("Quarterly", dividend.Type);
        }
    }
}
