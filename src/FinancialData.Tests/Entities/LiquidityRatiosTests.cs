using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class LiquidityRatiosTests
{
    [TestMethod]
    public void LiquidityRatios_Initialization_Works()
    {
        var ratios = new LiquidityRatios
        {
            TradingSymbol = "MSFT",
            CentralIndexKey = "0000789019",
            RegistrantName = "MICROSOFT CORP",
            FiscalYear = "2024",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 6, 30),
            WorkingCapital = 34448000000.0m,
            CurrentRatio = 1.27495490318152m,
            CashRatio = 0.719497789058634m,
            QuickRatio = 1.63062912057213m,
            DaysOfInventoryOutstanding = 2.97460668699571m,
            DaysSalesOutstanding = 90.1168295787404m,
            DaysPayablesOutstanding = 117.05619046334m,
            CashConversionCycle = -23.9647541976042m,
            SalesToWorkingCapitalRatio = 6.77619284569028m,
            CashToCurrentLiabilitiesRatio = 1.17627667895854m,
            WorkingCapitalToDebtRatio = 0.730047047853177m,
            CashFlowAdequacyRatio = 1.06121206695909m,
            SalesToCurrentAssetsRatio = 1.53456371217149m,
            CashToCurrentAssetsRatio = 0.922602576783903m,
            CashToWorkingCapitalRatio = 2.61678471899675m,
            InventoryToWorkingCapitalRatio = 0.0344446287388732m,
            NetDebt = -42957000000.0m
        };
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(34448000000.0m, ratios.WorkingCapital);
        Assert.AreEqual(1.27495490318152m, ratios.CurrentRatio);
        Assert.AreEqual(0.719497789058634m, ratios.CashRatio);
        Assert.AreEqual(1.63062912057213m, ratios.QuickRatio);
        Assert.AreEqual(2.97460668699571m, ratios.DaysOfInventoryOutstanding);
        Assert.AreEqual(90.1168295787404m, ratios.DaysSalesOutstanding);
        Assert.AreEqual(117.05619046334m, ratios.DaysPayablesOutstanding);
        Assert.AreEqual(-23.9647541976042m, ratios.CashConversionCycle);
        Assert.AreEqual(6.77619284569028m, ratios.SalesToWorkingCapitalRatio);
        Assert.AreEqual(1.17627667895854m, ratios.CashToCurrentLiabilitiesRatio);
        Assert.AreEqual(0.730047047853177m, ratios.WorkingCapitalToDebtRatio);
        Assert.AreEqual(1.06121206695909m, ratios.CashFlowAdequacyRatio);
        Assert.AreEqual(1.53456371217149m, ratios.SalesToCurrentAssetsRatio);
        Assert.AreEqual(0.922602576783903m, ratios.CashToCurrentAssetsRatio);
        Assert.AreEqual(2.61678471899675m, ratios.CashToWorkingCapitalRatio);
        Assert.AreEqual(0.0344446287388732m, ratios.InventoryToWorkingCapitalRatio);
        Assert.AreEqual(-42957000000.0m, ratios.NetDebt);
    }

    [TestMethod]
    public void LiquidityRatios_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"MSFT\",\n    \"central_index_key\": \"0000789019\",\n    \"registrant_name\": \"MICROSOFT CORP\",\n    \"fiscal_year\": \"2024\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-06-30\",\n    \"working_capital\": 34448000000.0,\n    \"current_ratio\": 1.27495490318152,\n    \"cash_ratio\": 0.719497789058634,\n    \"quick_ratio\": 1.63062912057213,\n    \"days_of_inventory_outstanding\": 2.97460668699571,\n    \"days_sales_outstanding\": 90.1168295787404,\n    \"days_payables_outstanding\": 117.05619046334,\n    \"cash_conversion_cycle\": -23.9647541976042,\n    \"sales_to_working_capital_ratio\": 6.77619284569028,\n    \"cash_to_current_liabilities_ratio\": 1.17627667895854,\n    \"working_capital_to_debt_ratio\": 0.730047047853177,\n    \"cash_flow_adequacy_ratio\": 1.06121206695909,\n    \"sales_to_current_assets_ratio\": 1.53456371217149,\n    \"cash_to_current_assets_ratio\": 0.922602576783903,\n    \"cash_to_working_capital_ratio\": 2.61678471899675,\n    \"inventory_to_working_capital_ratio\": 0.0344446287388732,\n    \"net_debt\": -42957000000.0\n}";
        using var doc = JsonDocument.Parse(json);
        var ratios = FinancialDataSerializer.Instance.Deserialize<LiquidityRatios>(doc);
        Assert.AreEqual("MSFT", ratios.TradingSymbol);
        Assert.AreEqual("0000789019", ratios.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", ratios.RegistrantName);
        Assert.AreEqual("2024", ratios.FiscalYear);
        Assert.AreEqual("FY", ratios.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), ratios.PeriodEndDate);
        Assert.AreEqual(34448000000.0m, ratios.WorkingCapital);
        Assert.AreEqual(1.27495490318152m, ratios.CurrentRatio);
        Assert.AreEqual(0.719497789058634m, ratios.CashRatio);
        Assert.AreEqual(1.63062912057213m, ratios.QuickRatio);
        Assert.AreEqual(2.97460668699571m, ratios.DaysOfInventoryOutstanding);
        Assert.AreEqual(90.1168295787404m, ratios.DaysSalesOutstanding);
        Assert.AreEqual(117.05619046334m, ratios.DaysPayablesOutstanding);
        Assert.AreEqual(-23.9647541976042m, ratios.CashConversionCycle);
        Assert.AreEqual(6.77619284569028m, ratios.SalesToWorkingCapitalRatio);
        Assert.AreEqual(1.17627667895854m, ratios.CashToCurrentLiabilitiesRatio);
        Assert.AreEqual(0.730047047853177m, ratios.WorkingCapitalToDebtRatio);
        Assert.AreEqual(1.06121206695909m, ratios.CashFlowAdequacyRatio);
        Assert.AreEqual(1.53456371217149m, ratios.SalesToCurrentAssetsRatio);
        Assert.AreEqual(0.922602576783903m, ratios.CashToCurrentAssetsRatio);
        Assert.AreEqual(2.61678471899675m, ratios.CashToWorkingCapitalRatio);
        Assert.AreEqual(0.0344446287388732m, ratios.InventoryToWorkingCapitalRatio);
        Assert.AreEqual(-42957000000.0m, ratios.NetDebt);
    }
}
