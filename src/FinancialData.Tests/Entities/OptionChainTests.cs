using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class OptionChainTests
    {
        [TestMethod]
        public void OptionChain_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""central_index_key"": ""0000320193"",
    ""registrant_name"": ""Apple Inc."",
    ""contract_name"": ""AAPL240119C00180000"",
    ""expiration_date"": ""2024-01-19"",
    ""put_or_call"": ""Call"",
    ""strike_price"": 180.00
}";
            using var doc = JsonDocument.Parse(json);
            var optionChain = FinancialDataSerializer.Instance.Deserialize<OptionChain>(doc);
            Assert.AreEqual("AAPL", optionChain.TradingSymbol);
            Assert.AreEqual("0000320193", optionChain.CentralIndexKey);
            Assert.AreEqual("Apple Inc.", optionChain.RegistrantName);
            Assert.AreEqual("AAPL240119C00180000", optionChain.ContractName);
            Assert.AreEqual(new DateOnly(2024, 1, 19), optionChain.ExpirationDate);
            Assert.AreEqual("Call", optionChain.PutOrCall);
            Assert.AreEqual(180.00m, optionChain.StrikePrice);
        }
    }
}
