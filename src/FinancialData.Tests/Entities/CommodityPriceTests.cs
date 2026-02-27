using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class CommodityPriceTests
{
    [TestMethod]
    public void CommodityPrice_Initialization_Works()
    {
        var price = new CommodityPrice
        {
            TradingSymbol = "ZC",
            Date = new DateOnly(2024, 12, 3),
            Open = 425.0m,
            High = 428.0m,
            Low = 422.75m,
            Close = 423.25m,
            Volume = 4078.0m
        };
        Assert.AreEqual("ZC", price.TradingSymbol);
        Assert.AreEqual(new DateOnly(2024, 12, 3), price.Date);
        Assert.AreEqual(425.0m, price.Open);
        Assert.AreEqual(428.0m, price.High);
        Assert.AreEqual(422.75m, price.Low);
        Assert.AreEqual(423.25m, price.Close);
        Assert.AreEqual(4078.0m, price.Volume);
    }

    [TestMethod]
    public void CommodityPrice_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"ZC\",\n    \"date\": \"2024-12-03\",\n    \"open\": 425.0,\n    \"high\": 428.0,\n    \"low\": 422.75,\n    \"close\": 423.25,\n    \"volume\": 4078.0\n}";
        using var doc = JsonDocument.Parse(json);
        var price = FinancialDataSerializer.Instance.Deserialize<CommodityPrice>(doc);
        Assert.AreEqual("ZC", price.TradingSymbol);
        Assert.AreEqual(new DateOnly(2024, 12, 3), price.Date);
        Assert.AreEqual(425.0m, price.Open);
        Assert.AreEqual(428.0m, price.High);
        Assert.AreEqual(422.75m, price.Low);
        Assert.AreEqual(423.25m, price.Close);
        Assert.AreEqual(4078.0m, price.Volume);
    }
}
