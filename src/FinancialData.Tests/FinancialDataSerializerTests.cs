using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests;

[TestClass]
public class FinancialDataSerializerTests
{
    private FinancialDataSerializer _serializer = null!;

    [TestInitialize]
    public void Setup()
    {
        _serializer = new FinancialDataSerializer();
    }

    #region Deserialize Tests

    [TestMethod]
    public void Deserialize_ValidJson_ReturnsObject()
    {
        // Arrange
        var json = """{"trading_symbol":"MSFT","open":100.5}""";
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<StockPrice>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual("MSFT", result.TradingSymbol);
        Assert.AreEqual(100.5m, result.Open);
    }

    [TestMethod]
    public void Deserialize_NullJsonDocument_ThrowsJsonException()
    {
        // Arrange
        var json = "null";
        var doc = JsonDocument.Parse(json);

        // Act & Assert
        var exception = Assert.ThrowsExactly<JsonException>(() =>
            _serializer.Deserialize<StockPrice>(doc));
        Assert.AreEqual("Failed to deserialize JSON document.", exception.Message);
    }

    [TestMethod]
    public void Deserialize_EmptyObject_ReturnsDefaultValues()
    {
        // Arrange
        var json = "{}";
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<StockPrice>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNull(result.TradingSymbol);
        Assert.AreEqual(0m, result.Open);
    }

    #endregion

    #region Serialize Tests

    [TestMethod]
    public void Serialize_StockPrice_ReturnsJsonString()
    {
        // Arrange
        var stockPrice = new StockPrice
        {
            TradingSymbol = "AAPL",
            Date = new DateOnly(2024, 1, 15),
            Open = 150.25m,
            High = 155.50m,
            Low = 149.00m,
            Close = 154.00m,
            Volume = 1000000m
        };

        // Act
        var json = _serializer.Serialize(stockPrice);

        // Assert
        Assert.IsNotNull(json);
        Assert.Contains("AAPL", json);
        Assert.Contains("trading_symbol", json);
    }

    [TestMethod]
    public void Serialize_BalanceSheet_ReturnsJsonString()
    {
        // Arrange
        var balanceSheet = new BalanceSheet
        {
            TradingSymbol = "GOOGL",
            FiscalYear = "2024",
            FiscalPeriod = "Q1",
            CashAndCashEquivalents = 50000000m
        };

        // Act
        var json = _serializer.Serialize(balanceSheet);

        // Assert
        Assert.IsNotNull(json);
        Assert.Contains("GOOGL", json);
        Assert.Contains("trading_symbol", json);
    }

    #endregion

    #region DecimalNullToZeroConverter Tests

    [TestMethod]
    public void DecimalNullToZeroConverter_NullValue_ReturnsZero()
    {
        // Arrange
        var json = """{"open":null,"high":100.5}""";
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<StockPrice>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(0m, result.Open);
        Assert.AreEqual(100.5m, result.High);
    }

    [TestMethod]
    public void DecimalNullToZeroConverter_EmptyString_ReturnsZero()
    {
        // Arrange
        var json = """{"open":"","high":100.5}""";
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<StockPrice>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(0m, result.Open);
        Assert.AreEqual(100.5m, result.High);
    }

    [TestMethod]
    public void DecimalNullToZeroConverter_ValidNumber_ReturnsValue()
    {
        // Arrange
        var json = """{"open":123.45,"high":200.00}""";
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<StockPrice>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(123.45m, result.Open);
        Assert.AreEqual(200.00m, result.High);
    }

    [TestMethod]
    public void DecimalNullToZeroConverter_InvalidType_ThrowsJsonException()
    {
        // Arrange
        var json = """{"open":true}""";
        var doc = JsonDocument.Parse(json);

        // Act & Assert
        Assert.ThrowsExactly<JsonException>(() =>
            _serializer.Deserialize<StockPrice>(doc));
    }

    [TestMethod]
    public void DecimalNullToZeroConverter_Write_WritesNumberValue()
    {
        // Arrange
        var stockPrice = new StockPrice
        {
            Open = 100.50m,
            High = 105.25m
        };

        // Act
        var json = _serializer.Serialize(stockPrice);
        var doc = JsonDocument.Parse(json);

        // Assert
        Assert.IsTrue(doc.RootElement.TryGetProperty("open", out var openElement));
        Assert.AreEqual(JsonValueKind.Number, openElement.ValueKind);
        Assert.AreEqual(100.50m, openElement.GetDecimal());
    }

    #endregion

    #region CustomDateTimeConverter Tests

    [TestMethod]
    public void CustomDateTimeConverter_ValidDateTime_ParsesCorrectly()
    {
        // Arrange
        var json = """{"trading_symbol":"MSFT","time":"2024-01-15 14:30:00"}""";
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<TestEntity>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(new DateTime(2024, 1, 15, 14, 30, 0), result.Time);
    }

    [TestMethod]
    public void CustomDateTimeConverter_InvalidDateTimeFormat_ThrowsJsonException()
    {
        // Arrange
        var json = """{"time":"2024/01/15"}""";
        var doc = JsonDocument.Parse(json);

        // Act & Assert
        var exception = Assert.ThrowsExactly<JsonException>(() =>
            _serializer.Deserialize<TestEntity>(doc));
        Assert.Contains("Cannot parse DateTime from string", exception.Message);
    }

    [TestMethod]
    public void CustomDateTimeConverter_InvalidDateTimeValue_ThrowsJsonException()
    {
        // Arrange
        var json = """{"time":"invalid-date"}""";
        var doc = JsonDocument.Parse(json);

        // Act & Assert
        var exception = Assert.ThrowsExactly<JsonException>(() =>
            _serializer.Deserialize<TestEntity>(doc));
        Assert.Contains("Cannot parse DateTime from string: invalid-date", exception.Message);
    }

    [TestMethod]
    public void CustomDateTimeConverter_Write_WritesCorrectFormat()
    {
        // Arrange
        var testEntity = new TestEntity
        {
            TradingSymbol = "TSLA",
            Time = new DateTime(2024, 3, 20, 9, 30, 45)
        };

        // Act
        var json = JsonSerializer.Serialize(testEntity, new JsonSerializerOptions
        {
            Converters = { new FinancialDataSerializer.CustomDateTimeConverter() }
        });

        // Assert
        Assert.Contains("2024-03-20 09:30:45", json);
    }

    #endregion

    #region Snake Case Naming Tests

    [TestMethod]
    public void Serializer_UsesSnakeCaseNaming()
    {
        // Arrange
        var stockPrice = new StockPrice
        {
            TradingSymbol = "MSFT",
            Open = 100m
        };

        // Act
        var json = _serializer.Serialize(stockPrice);

        // Assert
        Assert.Contains("trading_symbol", json);
        Assert.DoesNotContain("TradingSymbol", json);
    }

    [TestMethod]
    public void Deserialize_SnakeCaseJson_MapsToProperties()
    {
        // Arrange
        var json = """{"trading_symbol":"NVDA","open":500.25}""";
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<StockPrice>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual("NVDA", result.TradingSymbol);
        Assert.AreEqual(500.25m, result.Open);
    }

    #endregion

    #region Complex Scenarios

    [TestMethod]
    public void Serialize_Deserialize_RoundTrip_PreservesData()
    {
        // Arrange
        var originalBalanceSheet = new BalanceSheet
        {
            TradingSymbol = "AMZN",
            FiscalYear = "2024",
            FiscalPeriod = "Q2",
            CashAndCashEquivalents = 75000000m,
            MarketableSecuritiesCurrent = 25000000m
        };

        // Act
        var json = _serializer.Serialize(originalBalanceSheet);
        var doc = JsonDocument.Parse(json);
        var deserialized = _serializer.Deserialize<BalanceSheet>(doc);

        // Assert
        Assert.IsNotNull(deserialized);
        Assert.AreEqual(originalBalanceSheet.TradingSymbol, deserialized.TradingSymbol);
        Assert.AreEqual(originalBalanceSheet.FiscalYear, deserialized.FiscalYear);
        Assert.AreEqual(originalBalanceSheet.CashAndCashEquivalents, deserialized.CashAndCashEquivalents);
    }

    [TestMethod]
    public void Deserialize_MixedNullAndValidDecimals_HandlesCorrectly()
    {
        // Arrange
        var json = """
        {
            "trading_symbol":"TEST",
            "open":null,
            "high":150.00,
            "low":"",
            "close":145.50,
            "volume":1000000
        }
        """;
        var doc = JsonDocument.Parse(json);

        // Act
        var result = _serializer.Deserialize<StockPrice>(doc);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual("TEST", result.TradingSymbol);
        Assert.AreEqual(0m, result.Open);
        Assert.AreEqual(150.00m, result.High);
        Assert.AreEqual(0m, result.Low);
        Assert.AreEqual(145.50m, result.Close);
        Assert.AreEqual(1000000m, result.Volume);
    }

    #endregion

    #region Helper Classes

    private record TestEntity
    {
        public string? TradingSymbol { get; init; }
        public DateTime Time { get; init; }
    }

    #endregion
}
