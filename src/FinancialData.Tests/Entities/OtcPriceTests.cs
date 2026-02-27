using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class OtcPriceTests
{
    [TestMethod]
    public void OtcPrice_Initialization_Works()
    {
        var price = new OtcPrice
        {
            TradingSymbol = "AABB",
            Date = new DateOnly(2024, 12, 4),
            Open = 0.0271m,
            High = 0.0271m,
            Low = 0.024m,
            Close = 0.0248m,
            Volume = 6592169.0m
        };
        Assert.AreEqual("AABB", price.TradingSymbol);
        Assert.AreEqual(new DateOnly(2024, 12, 4), price.Date);
        Assert.AreEqual(0.0271m, price.Open);
        Assert.AreEqual(0.0271m, price.High);
        Assert.AreEqual(0.024m, price.Low);
        Assert.AreEqual(0.0248m, price.Close);
        Assert.AreEqual(6592169.0m, price.Volume);
    }

    [TestMethod]
    public void OtcPrice_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"AABB\",\n    \"date\": \"2024-12-04\",\n    \"open\": 0.0271,\n    \"high\": 0.0271,\n    \"low\": 0.024,\n    \"close\": 0.0248,\n    \"volume\": 6592169.0\n}";
        using var doc = JsonDocument.Parse(json);
        var price = FinancialDataSerializer.Instance.Deserialize<OtcPrice>(doc);
        Assert.AreEqual("AABB", price.TradingSymbol);
        Assert.AreEqual(new DateOnly(2024, 12, 4), price.Date);
        Assert.AreEqual(0.0271m, price.Open);
        Assert.AreEqual(0.0271m, price.High);
        Assert.AreEqual(0.024m, price.Low);
        Assert.AreEqual(0.0248m, price.Close);
        Assert.AreEqual(6592169.0m, price.Volume);
    }
}
