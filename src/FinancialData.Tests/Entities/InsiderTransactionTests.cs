using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InsiderTransactionTests
    {
        [TestMethod]
        public void InsiderTransaction_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""central_index_key"": ""0000320193"",
    ""registrant_name"": ""Apple Inc."",
    ""insider_name"": ""Tim Cook"",
    ""insider_title"": ""CEO"",
    ""transaction_date"": ""2024-01-10"",
    ""filing_date"": ""2024-01-12"",
    ""transaction_type"": ""Sale"",
    ""transaction_code"": ""S"",
    ""shares"": 50000,
    ""price"": 185.50,
    ""value"": 9275000.0,
    ""shares_owned_after_transaction"": 3200000,
    ""sec_filing_url"": ""https://sec.gov/filing/12345""
}";
            using var doc = JsonDocument.Parse(json);
            var insider = FinancialDataSerializer.Instance.Deserialize<InsiderTransaction>(doc);
            Assert.AreEqual("AAPL", insider.TradingSymbol);
            Assert.AreEqual("Tim Cook", insider.InsiderName);
            Assert.AreEqual("Sale", insider.TransactionType);
            Assert.AreEqual(50000m, insider.Shares);
            Assert.AreEqual(185.50m, insider.Price);
            Assert.AreEqual(9275000m, insider.Value);
        }
    }
}
