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
    ""registrant_name"": ""Airbnb, Inc."",
    ""exchange"": ""NASDAQ"",
    ""pricing_date"": ""2020-12-10"",
    ""share_price"": 68.00,
    ""shares_offered"": 51900000,
    ""offering_value"": 3500000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var ipo = FinancialDataSerializer.Instance.Deserialize<InitialPublicOffering>(doc);
            Assert.AreEqual("ABNB", ipo.TradingSymbol);
            Assert.AreEqual("Airbnb, Inc.", ipo.RegistrantName);
            Assert.AreEqual("NASDAQ", ipo.Exchange);
            Assert.AreEqual(new DateOnly(2020, 12, 10), ipo.PricingDate);
            Assert.AreEqual(68.00m, ipo.SharePrice);
            Assert.AreEqual(51900000m, ipo.SharesOffered);
            Assert.AreEqual(3500000000m, ipo.OfferingValue);
        }
    }
}
