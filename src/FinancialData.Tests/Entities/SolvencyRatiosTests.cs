using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class SolvencyRatiosTests
{
    [TestMethod]
    public void SolvencyRatios_Initialization_Works()
    {
        var ratios = new SolvencyRatios
        {
            TradingSymbol = "MSFT",
            CentralIndexKey = "0000789019",
            RegistrantName = "MICROSOFT CORP",
            FiscalYear = "2024",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 6, 30),
            EquityRatio = 0.524202255922431m,
            DebtCoverageRatio = 0m,
            AssetCoverageRatio = 8.24664095282499m,
            InterestCoverageRatio = 0m,
            DebtToEquityRatio = 0.17575434767224m,
            DebtToAssetsRatio = 0.0921308255379635m,
            DebtToCapitalRatio = 0.149482200954816m,
            DebtToIncomeRatio = 0m,
            CashFlowToDebtRatio = 2.51235535964057m
        };
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(0.524202255922431m, ratios.EquityRatio);
        Assert.AreEqual(0m, ratios.DebtCoverageRatio);
        Assert.AreEqual(8.24664095282499m, ratios.AssetCoverageRatio);
        Assert.AreEqual(0m, ratios.InterestCoverageRatio);
        Assert.AreEqual(0.17575434767224m, ratios.DebtToEquityRatio);
        Assert.AreEqual(0.0921308255379635m, ratios.DebtToAssetsRatio);
        Assert.AreEqual(0.149482200954816m, ratios.DebtToCapitalRatio);
        Assert.AreEqual(0m, ratios.DebtToIncomeRatio);
        Assert.AreEqual(2.51235535964057m, ratios.CashFlowToDebtRatio);
    }

    [TestMethod]
    public void SolvencyRatios_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"MSFT\",\n    \"central_index_key\": \"0000789019\",\n    \"registrant_name\": \"MICROSOFT CORP\",\n    \"fiscal_year\": \"2024\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-06-30\",\n    \"equity_ratio\": 0.524202255922431,\n    \"debt_coverage_ratio\": null,\n    \"asset_coverage_ratio\": 8.24664095282499,\n    \"interest_coverage_ratio\": null,\n    \"debt_to_equity_ratio\": 0.17575434767224,\n    \"debt_to_assets_ratio\": 0.0921308255379635,\n    \"debt_to_capital_ratio\": 0.149482200954816,\n    \"debt_to_income_ratio\": null,\n    \"cash_flow_to_debt_ratio\": 2.51235535964057\n}";
        using var doc = JsonDocument.Parse(json);
        var ratios = FinancialDataSerializer.Instance.Deserialize<SolvencyRatios>(doc);
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(0.524202255922431m, ratios.EquityRatio);
        Assert.AreEqual(0m, ratios.DebtCoverageRatio);
        Assert.AreEqual(8.24664095282499m, ratios.AssetCoverageRatio);
        Assert.AreEqual(0m, ratios.InterestCoverageRatio);
        Assert.AreEqual(0.17575434767224m, ratios.DebtToEquityRatio);
        Assert.AreEqual(0.0921308255379635m, ratios.DebtToAssetsRatio);
        Assert.AreEqual(0.149482200954816m, ratios.DebtToCapitalRatio);
        Assert.AreEqual(0m, ratios.DebtToIncomeRatio);
        Assert.AreEqual(2.51235535964057m, ratios.CashFlowToDebtRatio);
    }
}
