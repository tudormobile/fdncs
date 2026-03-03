using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class InitialPublicOfferingTests
    {
        [TestMethod]
        public void InitialPublicOffering_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""ABNB"",
    ""central_index_key"": ""0001559720"",
    ""registrant_name"": ""Airbnb, Inc."",
    ""ipo_date"": ""2020-12-10"",
    ""offer_price"": 68.00,
    ""shares_offered"": 51900000,
    ""amount_raised"": 3500000000.0,
    ""first_day_opening_price"": 146.00,
    ""first_day_closing_price"": 144.71
}";
            using var doc = JsonDocument.Parse(json);
            var ipo = FinancialDataSerializer.Instance.Deserialize<InitialPublicOffering>(doc);
            Assert.AreEqual("ABNB", ipo.TradingSymbol);
            Assert.AreEqual(68.00m, ipo.SharePrice);
            Assert.AreEqual(51900000m, ipo.SharesOffered);
            Assert.AreEqual(3500000000m, ipo.OfferingValue);
        }
    }
}
