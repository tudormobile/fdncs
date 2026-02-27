using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class InternationalBalanceSheetTests
{
    [TestMethod]
    public void InternationalBalanceSheet_Initialization_Works()
    {
        var sheet = new InternationalBalanceSheet
        {
            TradingSymbol = "SHEL.L",
            RegistrantName = "Shell plc",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 12, 31),
            CurrencyCode = "USD",
            CashAndCashEquivalents = 37836000000.0m,
            AccountsReceivable = 31041000000.0m,
            Inventories = 23426000000.0m,
            OtherAssetsCurrent = 0m,
            TotalAssetsCurrent = 127926000000.0m,
            PropertyPlantAndEquipment = 185219000000.0m,
            OtherAssetsNonCurrent = 0m,
            TotalAssetsNonCurrent = 259683000000.0m,
            TotalAssets = 387609000000.0m,
            AccountsPayable = 29767000000.0m,
            ShortTermDebt = 6920000000.0m,
            OtherLiabilitiesCurrent = 0m,
            TotalLiabilitiesCurrent = 95034000000.0m,
            LongTermDebt = 41456000000.0m,
            OtherLiabilitiesNonCurrent = 0m,
            TotalLiabilitiesNonCurrent = 112407000000.0m,
            TotalLiabilities = 207441000000.0m,
            CommonStock = 178307000000.0m,
            RetainedEarnings = 158834000000.0m,
            TotalShareholdersEquity = 178307000000.0m
        };
        Assert.AreEqual("SHEL.L", sheet.TradingSymbol);
        Assert.AreEqual("Shell plc", sheet.RegistrantName);
        Assert.AreEqual("FY", sheet.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 12, 31), sheet.PeriodEndDate);
        Assert.AreEqual("USD", sheet.CurrencyCode);
        Assert.AreEqual(37836000000.0m, sheet.CashAndCashEquivalents);
        Assert.AreEqual(31041000000.0m, sheet.AccountsReceivable);
        Assert.AreEqual(23426000000.0m, sheet.Inventories);
        Assert.AreEqual(0m, sheet.OtherAssetsCurrent);
        Assert.AreEqual(127926000000.0m, sheet.TotalAssetsCurrent);
        Assert.AreEqual(185219000000.0m, sheet.PropertyPlantAndEquipment);
        Assert.AreEqual(0m, sheet.OtherAssetsNonCurrent);
        Assert.AreEqual(259683000000.0m, sheet.TotalAssetsNonCurrent);
        Assert.AreEqual(387609000000.0m, sheet.TotalAssets);
        Assert.AreEqual(29767000000.0m, sheet.AccountsPayable);
        Assert.AreEqual(6920000000.0m, sheet.ShortTermDebt);
        Assert.AreEqual(0m, sheet.OtherLiabilitiesCurrent);
        Assert.AreEqual(95034000000.0m, sheet.TotalLiabilitiesCurrent);
        Assert.AreEqual(41456000000.0m, sheet.LongTermDebt);
        Assert.AreEqual(0m, sheet.OtherLiabilitiesNonCurrent);
        Assert.AreEqual(112407000000.0m, sheet.TotalLiabilitiesNonCurrent);
        Assert.AreEqual(207441000000.0m, sheet.TotalLiabilities);
        Assert.AreEqual(178307000000.0m, sheet.CommonStock);
        Assert.AreEqual(158834000000.0m, sheet.RetainedEarnings);
        Assert.AreEqual(178307000000.0m, sheet.TotalShareholdersEquity);
    }

    [TestMethod]
    public void InternationalBalanceSheet_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"SHEL.L\",\n    \"registrant_name\": \"Shell plc\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-12-31\",\n    \"currency_code\": \"USD\",\n    \"cash_and_cash_equivalents\": 37836000000.0,\n    \"accounts_receivable\": 31041000000.0,\n    \"inventories\": 23426000000.0,\n    \"other_assets_current\": null,\n    \"total_assets_current\": 127926000000.0,\n    \"property_plant_and_equipment\": 185219000000.0,\n    \"other_assets_non_current\": null,\n    \"total_assets_non_current\": 259683000000.0,\n    \"total_assets\": 387609000000.0,\n    \"accounts_payable\": 29767000000.0,\n    \"short_term_debt\": 6920000000.0,\n    \"other_liabilities_current\": null,\n    \"total_liabilities_current\": 95034000000.0,\n    \"long_term_debt\": 41456000000.0,\n    \"other_liabilities_non_current\": null,\n    \"total_liabilities_non_current\": 112407000000.0,\n    \"total_liabilities\": 207441000000.0,\n    \"common_stock\": 178307000000.0,\n    \"retained_earnings\": 158834000000.0,\n    \"total_shareholders_equity\": 178307000000.0\n}";
        using var doc = JsonDocument.Parse(json);
        var sheet = FinancialDataSerializer.Instance.Deserialize<InternationalBalanceSheet>(doc);
        Assert.AreEqual("SHEL.L", sheet.TradingSymbol);
        Assert.AreEqual("Shell plc", sheet.RegistrantName);
        Assert.AreEqual("FY", sheet.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 12, 31), sheet.PeriodEndDate);
        Assert.AreEqual("USD", sheet.CurrencyCode);
        Assert.AreEqual(37836000000.0m, sheet.CashAndCashEquivalents);
        Assert.AreEqual(31041000000.0m, sheet.AccountsReceivable);
        Assert.AreEqual(23426000000.0m, sheet.Inventories);
        Assert.AreEqual(0m, sheet.OtherAssetsCurrent);
        Assert.AreEqual(127926000000.0m, sheet.TotalAssetsCurrent);
        Assert.AreEqual(185219000000.0m, sheet.PropertyPlantAndEquipment);
        Assert.AreEqual(0m, sheet.OtherAssetsNonCurrent);
        Assert.AreEqual(259683000000.0m, sheet.TotalAssetsNonCurrent);
        Assert.AreEqual(387609000000.0m, sheet.TotalAssets);
        Assert.AreEqual(29767000000.0m, sheet.AccountsPayable);
        Assert.AreEqual(6920000000.0m, sheet.ShortTermDebt);
        Assert.AreEqual(0m, sheet.OtherLiabilitiesCurrent);
        Assert.AreEqual(95034000000.0m, sheet.TotalLiabilitiesCurrent);
        Assert.AreEqual(41456000000.0m, sheet.LongTermDebt);
        Assert.AreEqual(0m, sheet.OtherLiabilitiesNonCurrent);
        Assert.AreEqual(112407000000.0m, sheet.TotalLiabilitiesNonCurrent);
        Assert.AreEqual(207441000000.0m, sheet.TotalLiabilities);
        Assert.AreEqual(178307000000.0m, sheet.CommonStock);
        Assert.AreEqual(158834000000.0m, sheet.RetainedEarnings);
        Assert.AreEqual(178307000000.0m, sheet.TotalShareholdersEquity);
    }
}
