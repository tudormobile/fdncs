using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class BalanceSheetTests
    {
        [TestMethod]
        public void BalanceSheet_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""central_index_key"": ""0000789019"",
    ""registrant_name"": ""MICROSOFT CORP"",
    ""fiscal_year"": ""2024"",
    ""fiscal_period"": ""FY"",
    ""period_end_date"": ""2024-06-30"",
    ""cash_and_cash_equivalents"": 90143000000.0,
    ""marketable_securities_current"": 57228000000.0,
    ""accounts_receivable"": 56924000000.0,
    ""inventories"": 1246000000.0,
    ""non_trade_receivables"": null,
    ""other_assets_current"": 26021000000.0,
    ""total_assets_current"": 159734000000.0,
    ""marketable_securities_non_current"": 14600000000.0,
    ""property_plant_and_equipment"": 135591000000.0,
    ""other_assets_non_current"": 36460000000.0,
    ""total_assets_non_current"": 301369000000.0,
    ""total_assets"": 512163000000.0,
    ""accounts_payable"": 21996000000.0,
    ""deferred_revenue"": 57582000000.0,
    ""short_term_debt"": 2249000000.0,
    ""other_liabilities_current"": 19185000000.0,
    ""total_liabilities_current"": 125286000000.0,
    ""long_term_debt"": 44937000000.0,
    ""other_liabilities_non_current"": 27064000000.0,
    ""total_liabilities_non_current"": 118400000000.0,
    ""total_liabilities"": 243686000000.0,
    ""common_stock"": 100923000000.0,
    ""retained_earnings"": 173144000000.0,
    ""accumulated_other_comprehensive_income"": -5590000000.0,
    ""total_shareholders_equity"": 268477000000.0
}";
            using var doc = JsonDocument.Parse(json);
            var balanceSheet = FinancialDataSerializer.Instance.Deserialize<BalanceSheet>(doc);
            Assert.AreEqual("MSFT", balanceSheet.TradingSymbol);
            Assert.AreEqual("0000789019", balanceSheet.CentralIndexKey);
            Assert.AreEqual("MICROSOFT CORP", balanceSheet.RegistrantName);
            Assert.AreEqual("2024", balanceSheet.FiscalYear);
            Assert.AreEqual("FY", balanceSheet.FiscalPeriod);
            Assert.AreEqual(new DateOnly(2024, 6, 30), balanceSheet.PeriodEndDate);
            Assert.AreEqual(90143000000.0m, balanceSheet.CashAndCashEquivalents);
            Assert.AreEqual(57228000000.0m, balanceSheet.MarketableSecuritiesCurrent);
            Assert.AreEqual(56924000000.0m, balanceSheet.AccountsReceivable);
            Assert.AreEqual(1246000000.0m, balanceSheet.Inventories);
            Assert.AreEqual(0m, balanceSheet.NonTradeReceivables); // Null converts to 0 with DecimalNullToZeroConverter
            Assert.AreEqual(26021000000.0m, balanceSheet.OtherAssetsCurrent);
            Assert.AreEqual(159734000000.0m, balanceSheet.TotalAssetsCurrent);
            Assert.AreEqual(14600000000.0m, balanceSheet.MarketableSecuritiesNonCurrent);
            Assert.AreEqual(135591000000.0m, balanceSheet.PropertyPlantAndEquipment);
            Assert.AreEqual(36460000000.0m, balanceSheet.OtherAssetsNonCurrent);
            Assert.AreEqual(301369000000.0m, balanceSheet.TotalAssetsNonCurrent);
            Assert.AreEqual(512163000000.0m, balanceSheet.TotalAssets);
            Assert.AreEqual(21996000000.0m, balanceSheet.AccountsPayable);
            Assert.AreEqual(57582000000.0m, balanceSheet.DeferredRevenue);
            Assert.AreEqual(2249000000.0m, balanceSheet.ShortTermDebt);
            Assert.AreEqual(19185000000.0m, balanceSheet.OtherLiabilitiesCurrent);
            Assert.AreEqual(125286000000.0m, balanceSheet.TotalLiabilitiesCurrent);
            Assert.AreEqual(44937000000.0m, balanceSheet.LongTermDebt);
            Assert.AreEqual(27064000000.0m, balanceSheet.OtherLiabilitiesNonCurrent);
            Assert.AreEqual(118400000000.0m, balanceSheet.TotalLiabilitiesNonCurrent);
            Assert.AreEqual(243686000000.0m, balanceSheet.TotalLiabilities);
            Assert.AreEqual(100923000000.0m, balanceSheet.CommonStock);
            Assert.AreEqual(173144000000.0m, balanceSheet.RetainedEarnings);
            Assert.AreEqual(-5590000000.0m, balanceSheet.AccumulatedOtherComprehensiveIncome);
            Assert.AreEqual(268477000000.0m, balanceSheet.TotalShareholdersEquity);
        }
    }
}
