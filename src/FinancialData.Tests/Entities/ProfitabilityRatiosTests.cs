using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class ProfitabilityRatiosTests
{
    [TestMethod]
    public void ProfitabilityRatios_Initialization_Works()
    {
        var ratios = new ProfitabilityRatios
        {
            TradingSymbol = "MSFT",
            CentralIndexKey = "0000789019",
            RegistrantName = "MICROSOFT CORP",
            FiscalYear = "2024",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 6, 30),
            EBIT = 114471000000.0m,
            EBITDA = 136758000000.0m,
            ProfitMargin = 0.35955972944085m,
            GrossMargin = 0.697644438279714m,
            OperatingMargin = 0.446442995732737m,
            OperatingCashFlowMargin = 0.483628560471928m,
            ReturnOnEquity = 0.328281379782998m,
            ReturnOnAssets = 0.172085839859576m,
            ReturnOnDebt = 1.86784215657186m,
            CashReturnOnAssets = 0.231465373328413m,
            CashTurnoverRatio = 2.71925718025803m
        };
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(114471000000.0m, ratios.EBIT);
        Assert.AreEqual(136758000000.0m, ratios.EBITDA);
        Assert.AreEqual(0.35955972944085m, ratios.ProfitMargin);
        Assert.AreEqual(0.697644438279714m, ratios.GrossMargin);
        Assert.AreEqual(0.446442995732737m, ratios.OperatingMargin);
        Assert.AreEqual(0.483628560471928m, ratios.OperatingCashFlowMargin);
        Assert.AreEqual(0.328281379782998m, ratios.ReturnOnEquity);
        Assert.AreEqual(0.172085839859576m, ratios.ReturnOnAssets);
        Assert.AreEqual(1.86784215657186m, ratios.ReturnOnDebt);
        Assert.AreEqual(0.231465373328413m, ratios.CashReturnOnAssets);
        Assert.AreEqual(2.71925718025803m, ratios.CashTurnoverRatio);
    }

    [TestMethod]
    public void ProfitabilityRatios_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"MSFT\",\n    \"central_index_key\": \"0000789019\",\n    \"registrant_name\": \"MICROSOFT CORP\",\n    \"fiscal_year\": \"2024\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-06-30\",\n    \"ebit\": 114471000000.0,\n    \"ebitda\": 136758000000.0,\n    \"profit_margin\": 0.35955972944085,\n    \"gross_margin\": 0.697644438279714,\n    \"operating_margin\": 0.446442995732737,\n    \"operating_cash_flow_margin\": 0.483628560471928,\n    \"return_on_equity\": 0.328281379782998,\n    \"return_on_assets\": 0.172085839859576,\n    \"return_on_debt\": 1.86784215657186,\n    \"cash_return_on_assets\": 0.231465373328413,\n    \"cash_turnover_ratio\": 2.71925718025803\n}";
        using var doc = JsonDocument.Parse(json);
        var ratios = FinancialDataSerializer.Instance.Deserialize<ProfitabilityRatios>(doc);
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(114471000000.0m, ratios.EBIT);
        Assert.AreEqual(136758000000.0m, ratios.EBITDA);
        Assert.AreEqual(0.35955972944085m, ratios.ProfitMargin);
        Assert.AreEqual(0.697644438279714m, ratios.GrossMargin);
        Assert.AreEqual(0.446442995732737m, ratios.OperatingMargin);
        Assert.AreEqual(0.483628560471928m, ratios.OperatingCashFlowMargin);
        Assert.AreEqual(0.328281379782998m, ratios.ReturnOnEquity);
        Assert.AreEqual(0.172085839859576m, ratios.ReturnOnAssets);
        Assert.AreEqual(1.86784215657186m, ratios.ReturnOnDebt);
        Assert.AreEqual(0.231465373328413m, ratios.CashReturnOnAssets);
        Assert.AreEqual(2.71925718025803m, ratios.CashTurnoverRatio);
    }
}
