using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class FuturesPriceTests
    {
        [TestMethod]
        public void FuturesPrice_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""ES"",
    ""date"": ""2024-01-15"",
    ""open"": 4800.50,
    ""high"": 4825.75,
    ""low"": 4795.25,
    ""close"": 4820.00,
    ""volume"": 2500000
}";
            using var doc = JsonDocument.Parse(json);
            var futuresPrice = FinancialDataSerializer.Instance.Deserialize<FuturesPrice>(doc);
            Assert.AreEqual("ES", futuresPrice.TradingSymbol);
            Assert.AreEqual(new DateOnly(2024, 1, 15), futuresPrice.Date);
            Assert.AreEqual(4800.50m, futuresPrice.Open);
            Assert.AreEqual(4825.75m, futuresPrice.High);
            Assert.AreEqual(4795.25m, futuresPrice.Low);
            Assert.AreEqual(4820.00m, futuresPrice.Close);
            Assert.AreEqual(2500000m, futuresPrice.Volume);
        }
    }
}
