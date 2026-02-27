using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class SymbolTests
{
    [TestMethod]
    public void Symbol_Initialization_Works()
    {
        var symbol = new Symbol
        {
            TradingSymbol = "AAPL",
            RegistrantName = "Apple Inc."
        };
        Assert.AreEqual("AAPL", symbol.TradingSymbol);
        Assert.AreEqual("Apple Inc.", symbol.RegistrantName);
    }

    [TestMethod]
    public void Symbol_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"AAPL\",\n    \"registrant_name\": \"Apple Inc.\"\n}";
        using var doc = JsonDocument.Parse(json);
        var symbol = FinancialDataSerializer.Instance.Deserialize<Symbol>(doc);
        Assert.AreEqual("AAPL", symbol.TradingSymbol);
        Assert.AreEqual("Apple Inc.", symbol.RegistrantName);
    }
}
