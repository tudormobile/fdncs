using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class ValuationRatiosTests
{
    [TestMethod]
    public void ValuationRatios_Initialization_Works()
    {
        var ratios = new ValuationRatios
        {
            TradingSymbol = "MSFT",
            CentralIndexKey = "0000789019",
            RegistrantName = "MICROSOFT CORP",
            FiscalYear = "2024",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 6, 30),
            DividendsPerShare = 3.00040371417037m,
            DividendPayoutRatio = 0.252985136102055m,
            BookValuePerShare = 36.1293231059077m,
            RetentionRatio = 0.747027321412363m,
            NetFixedAssets = 113304000000.0m
        };
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(3.00040371417037m, ratios.DividendsPerShare);
        Assert.AreEqual(0.252985136102055m, ratios.DividendPayoutRatio);
        Assert.AreEqual(36.1293231059077m, ratios.BookValuePerShare);
        Assert.AreEqual(0.747027321412363m, ratios.RetentionRatio);
        Assert.AreEqual(113304000000.0m, ratios.NetFixedAssets);
    }

    [TestMethod]
    public void ValuationRatios_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"MSFT\",\n    \"central_index_key\": \"0000789019\",\n    \"registrant_name\": \"MICROSOFT CORP\",\n    \"fiscal_year\": \"2024\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-06-30\",\n    \"dividends_per_share\": 3.00040371417037,\n    \"dividend_payout_ratio\": 0.252985136102055,\n    \"book_value_per_share\": 36.1293231059077,\n    \"retention_ratio\": 0.747027321412363,\n    \"net_fixed_assets\": 113304000000.0\n}";
        using var doc = JsonDocument.Parse(json);
        var ratios = FinancialDataSerializer.Instance.Deserialize<ValuationRatios>(doc);
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(3.00040371417037m, ratios.DividendsPerShare);
        Assert.AreEqual(0.252985136102055m, ratios.DividendPayoutRatio);
        Assert.AreEqual(36.1293231059077m, ratios.BookValuePerShare);
        Assert.AreEqual(0.747027321412363m, ratios.RetentionRatio);
        Assert.AreEqual(113304000000.0m, ratios.NetFixedAssets);
    }
}
