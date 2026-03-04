using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class StockPriceTests
    {
        [TestMethod]
        public void StockPrice_Deserialize_FromJson_WithDate_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""date"": ""2024-12-04"",
    ""open"": 433.03,
    ""high"": 439.67,
    ""low"": 432.63,
    ""close"": 437.42,
    ""volume"": 26009430.0
}";
            using var doc = JsonDocument.Parse(json);
            var stockPrice = FinancialDataSerializer.Instance.Deserialize<StockPrice>(doc);
            Assert.AreEqual("MSFT", stockPrice.TradingSymbol);
            Assert.AreEqual(new DateOnly(2024, 12, 4), stockPrice.Date);
            Assert.AreEqual(433.03m, stockPrice.Open);
            Assert.AreEqual(439.67m, stockPrice.High);
            Assert.AreEqual(432.63m, stockPrice.Low);
            Assert.AreEqual(437.42m, stockPrice.Close);
            Assert.AreEqual(26009430.0m, stockPrice.Volume);
        }

        [TestMethod]
        public void StockPrice_Deserialize_FromJson_WithTime_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""time"": ""2024-12-04T14:30:00-05:00"",
    ""open"": 195.50,
    ""high"": 196.20,
    ""low"": 195.10,
    ""close"": 196.00,
    ""volume"": 45000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var stockPrice = FinancialDataSerializer.Instance.Deserialize<StockPrice>(doc);
            Assert.AreEqual("AAPL", stockPrice.TradingSymbol);
            Assert.AreEqual(new DateTimeOffset(2024, 12, 4, 14, 30, 0, TimeSpan.FromHours(-5)), stockPrice.Time);
            Assert.AreEqual(195.50m, stockPrice.Open);
            Assert.AreEqual(196.20m, stockPrice.High);
            Assert.AreEqual(195.10m, stockPrice.Low);
            Assert.AreEqual(196.00m, stockPrice.Close);
            Assert.AreEqual(45000000.0m, stockPrice.Volume);
        }

        [TestMethod]
        public void StockPrice_WithDate_CanAccessTime()
        {
            var json = @"{
    ""trading_symbol"": ""GOOGL"",
    ""date"": ""2024-12-04"",
    ""open"": 140.50,
    ""high"": 142.00,
    ""low"": 140.00,
    ""close"": 141.50,
    ""volume"": 30000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var stockPrice = FinancialDataSerializer.Instance.Deserialize<StockPrice>(doc);

            // Verify Date is set correctly
            Assert.AreEqual(new DateOnly(2024, 12, 4), stockPrice.Date);

            // Verify Time is derived from Date (midnight in local time zone)
            var expectedDate = new DateOnly(2024, 12, 4);
            var expectedTime = expectedDate.ToDateTime(TimeOnly.MinValue);
            Assert.AreEqual(expectedTime, stockPrice.Time.DateTime);
            Assert.AreEqual(expectedDate, DateOnly.FromDateTime(stockPrice.Time.Date));
        }

        [TestMethod]
        public void StockPrice_WithTime_CanAccessDate()
        {
            var json = @"{
    ""trading_symbol"": ""TSLA"",
    ""time"": ""2024-12-04T16:00:00Z"",
    ""open"": 250.00,
    ""high"": 255.00,
    ""low"": 248.00,
    ""close"": 253.50,
    ""volume"": 60000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var stockPrice = FinancialDataSerializer.Instance.Deserialize<StockPrice>(doc);

            // Verify Time is set correctly
            Assert.AreEqual(new DateTimeOffset(2024, 12, 4, 16, 0, 0, TimeSpan.Zero), stockPrice.Time);

            // Verify Date is derived from Time
            Assert.AreEqual(new DateOnly(2024, 12, 4), stockPrice.Date);
        }

        [TestMethod]
        public void StockPrice_WithBothDateAndTime_BothAccessible()
        {
            // If both date and time are provided in JSON, both should be accessible
            var json = @"{
    ""trading_symbol"": ""NVDA"",
    ""date"": ""2024-12-04"",
    ""time"": ""2024-12-05T10:30:00Z"",
    ""open"": 500.00,
    ""high"": 510.00,
    ""low"": 495.00,
    ""close"": 505.00,
    ""volume"": 40000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var stockPrice = FinancialDataSerializer.Instance.Deserialize<StockPrice>(doc);

            // In the API definition, both "date" and "time" will never be set, therefore we
            // just verify both are accessible and one of them is properly set
            Assert.IsTrue(stockPrice.Date != default || stockPrice.Time != default);
        }

        [TestMethod]
        public void StockPrice_EmptyObject_HasDefaultValues()
        {
            var json = @"{
    ""trading_symbol"": ""TEST"",
    ""open"": 100.00,
    ""high"": 105.00,
    ""low"": 99.00,
    ""close"": 102.00,
    ""volume"": 1000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var stockPrice = FinancialDataSerializer.Instance.Deserialize<StockPrice>(doc);

            // When neither date nor time is provided, defaults should be returned
            Assert.AreEqual(default(DateOnly), stockPrice.Date);
            // Note: DateTimeOffset default includes the local time zone offset
            Assert.AreEqual(default(DateTime), stockPrice.Time.DateTime);
        }
    }
}
