using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class EfficiencyRatiosTests
{
    [TestMethod]
    public void EfficiencyRatios_Initialization_Works()
    {
        var ratios = new EfficiencyRatios
        {
            TradingSymbol = "MSFT",
            CentralIndexKey = "0000789019",
            RegistrantName = "MICROSOFT CORP",
            FiscalYear = "2024",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 6, 30),
            AssetTurnoverRatio = 0.478601538963182m,
            InventoryTurnoverRatio = 122.705298013245m,
            AccountsReceivableTurnoverRatio = 4.05029783788696m,
            AccountsPayableTurnoverRatio = 3.17218166901571m,
            EquityMultiplier = 1.90766061897295m,
            DaysSalesInInventory = 2.97460668699571m,
            FixedAssetTurnoverRatio = 1.55308101463922m,
            DaysWorkingCapital = 51.2949470059807m,
            WorkingCapitalTurnoverRatio = 7.11571063632141m,
            DaysCashOnHand = 0m,
            CapitalIntensityRatio = 2.08942077822472m,
            SalesToEquityRatio = 0.913009308059908m,
            InventoryToSalesRatio = 0.00246407911162605m,
            InvestmentTurnoverRatio = 0.77653066719888m,
            SalesToOperatingIncomeRatio = 2.23992762694982m
        };
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(0.478601538963182m, ratios.AssetTurnoverRatio);
        Assert.AreEqual(122.705298013245m, ratios.InventoryTurnoverRatio);
        Assert.AreEqual(4.05029783788696m, ratios.AccountsReceivableTurnoverRatio);
        Assert.AreEqual(3.17218166901571m, ratios.AccountsPayableTurnoverRatio);
        Assert.AreEqual(1.90766061897295m, ratios.EquityMultiplier);
        Assert.AreEqual(2.97460668699571m, ratios.DaysSalesInInventory);
        Assert.AreEqual(1.55308101463922m, ratios.FixedAssetTurnoverRatio);
        Assert.AreEqual(51.2949470059807m, ratios.DaysWorkingCapital);
        Assert.AreEqual(7.11571063632141m, ratios.WorkingCapitalTurnoverRatio);
        Assert.AreEqual(0m, ratios.DaysCashOnHand);
        Assert.AreEqual(2.08942077822472m, ratios.CapitalIntensityRatio);
        Assert.AreEqual(0.913009308059908m, ratios.SalesToEquityRatio);
        Assert.AreEqual(0.00246407911162605m, ratios.InventoryToSalesRatio);
        Assert.AreEqual(0.77653066719888m, ratios.InvestmentTurnoverRatio);
        Assert.AreEqual(2.23992762694982m, ratios.SalesToOperatingIncomeRatio);
    }

    [TestMethod]
    public void EfficiencyRatios_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"MSFT\",\n    \"central_index_key\": \"0000789019\",\n    \"registrant_name\": \"MICROSOFT CORP\",\n    \"fiscal_year\": \"2024\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-06-30\",\n    \"asset_turnover_ratio\": 0.478601538963182,\n    \"inventory_turnover_ratio\": 122.705298013245,\n    \"accounts_receivable_turnover_ratio\": 4.05029783788696,\n    \"accounts_payable_turnover_ratio\": 3.17218166901571,\n    \"equity_multiplier\": 1.90766061897295,\n    \"days_sales_in_inventory\": 2.97460668699571,\n    \"fixed_asset_turnover_ratio\": 1.55308101463922,\n    \"days_working_capital\": 51.2949470059807,\n    \"working_capital_turnover_ratio\": 7.11571063632141,\n    \"days_cash_on_hand\": null,\n    \"capital_intensity_ratio\": 2.08942077822472,\n    \"sales_to_equity_ratio\": 0.913009308059908,\n    \"inventory_to_sales_ratio\": 0.00246407911162605,\n    \"investment_turnover_ratio\": 0.77653066719888,\n    \"sales_to_operating_income_ratio\": 2.23992762694982\n}";
        using var doc = JsonDocument.Parse(json);
        var ratios = FinancialDataSerializer.Instance.Deserialize<EfficiencyRatios>(doc);
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(0.478601538963182m, ratios.AssetTurnoverRatio);
        Assert.AreEqual(122.705298013245m, ratios.InventoryTurnoverRatio);
        Assert.AreEqual(4.05029783788696m, ratios.AccountsReceivableTurnoverRatio);
        Assert.AreEqual(3.17218166901571m, ratios.AccountsPayableTurnoverRatio);
        Assert.AreEqual(1.90766061897295m, ratios.EquityMultiplier);
        Assert.AreEqual(2.97460668699571m, ratios.DaysSalesInInventory);
        Assert.AreEqual(1.55308101463922m, ratios.FixedAssetTurnoverRatio);
        Assert.AreEqual(51.2949470059807m, ratios.DaysWorkingCapital);
        Assert.AreEqual(7.11571063632141m, ratios.WorkingCapitalTurnoverRatio);
        Assert.AreEqual(0m, ratios.DaysCashOnHand);
        Assert.AreEqual(2.08942077822472m, ratios.CapitalIntensityRatio);
        Assert.AreEqual(0.913009308059908m, ratios.SalesToEquityRatio);
        Assert.AreEqual(0.00246407911162605m, ratios.InventoryToSalesRatio);
        Assert.AreEqual(0.77653066719888m, ratios.InvestmentTurnoverRatio);
        Assert.AreEqual(2.23992762694982m, ratios.SalesToOperatingIncomeRatio);
    }
}
