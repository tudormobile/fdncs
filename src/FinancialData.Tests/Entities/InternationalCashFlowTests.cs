using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class InternationalCashFlowTests
{
    [TestMethod]
    public void InternationalCashFlow_Initialization_Works()
    {
        var cashFlow = new InternationalCashFlow
        {
            TradingSymbol = "SHEL.L",
            RegistrantName = "Shell plc",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 12, 31),
            CurrencyCode = "USD",
            DepreciationAndAmortization = 22703000000.0m,
            ShareBasedCompensationExpense = 0m,
            ChangeInAccountsReceivable = 0m,
            ChangeInInventories = 1273000000.0m,
            ChangeInOtherAssets = 0m,
            ChangeInAccountsPayable = 0m,
            ChangeInOtherLiabilities = 0m,
            CashFromOperatingActivities = 54687000000.0m,
            AcquisitionOfPropertyPlantAndEquipment = 0m,
            AcquisitionOfBusiness = -1404000000.0m,
            CashFromInvestingActivities = -15155000000.0m,
            PaymentsOfDividends = -8668000000.0m,
            IssuanceOfCommonStock = 0m,
            RepurchaseOfCommonStock = -14687000000.0m,
            IssuanceOfLongTermDebt = 363000000.0m,
            RepaymentOfLongTermDebt = -9672000000.0m,
            CashFromFinancingActivities = -38435000000.0m,
            ChangeInCash = 1097000000.0m,
            CashAtEndOfPeriod = 39110000000.0m
        };
        Assert.AreEqual("SHEL.L", cashFlow.TradingSymbol);
        Assert.AreEqual("Shell plc", cashFlow.RegistrantName);
        Assert.AreEqual("FY", cashFlow.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 12, 31), cashFlow.PeriodEndDate);
        Assert.AreEqual("USD", cashFlow.CurrencyCode);
        Assert.AreEqual(22703000000.0m, cashFlow.DepreciationAndAmortization);
        Assert.AreEqual(0m, cashFlow.ShareBasedCompensationExpense);
        Assert.AreEqual(0m, cashFlow.ChangeInAccountsReceivable);
        Assert.AreEqual(1273000000.0m, cashFlow.ChangeInInventories);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherAssets);
        Assert.AreEqual(0m, cashFlow.ChangeInAccountsPayable);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherLiabilities);
        Assert.AreEqual(54687000000.0m, cashFlow.CashFromOperatingActivities);
        Assert.AreEqual(0m, cashFlow.AcquisitionOfPropertyPlantAndEquipment);
        Assert.AreEqual(-1404000000.0m, cashFlow.AcquisitionOfBusiness);
        Assert.AreEqual(-15155000000.0m, cashFlow.CashFromInvestingActivities);
        Assert.AreEqual(-8668000000.0m, cashFlow.PaymentsOfDividends);
        Assert.AreEqual(0m, cashFlow.IssuanceOfCommonStock);
        Assert.AreEqual(-14687000000.0m, cashFlow.RepurchaseOfCommonStock);
        Assert.AreEqual(363000000.0m, cashFlow.IssuanceOfLongTermDebt);
        Assert.AreEqual(-9672000000.0m, cashFlow.RepaymentOfLongTermDebt);
        Assert.AreEqual(-38435000000.0m, cashFlow.CashFromFinancingActivities);
        Assert.AreEqual(1097000000.0m, cashFlow.ChangeInCash);
        Assert.AreEqual(39110000000.0m, cashFlow.CashAtEndOfPeriod);
    }

    [TestMethod]
    public void InternationalCashFlow_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"SHEL.L\",\n    \"registrant_name\": \"Shell plc\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-12-31\",\n    \"currency_code\": \"USD\",\n    \"depreciation_and_amortization\": 22703000000.0,\n    \"share_based_compensation_expense\": null,\n    \"change_in_accounts_receivable\": null,\n    \"change_in_inventories\": 1273000000.0,\n    \"change_in_other_assets\": null,\n    \"change_in_accounts_payable\": null,\n    \"change_in_other_liabilities\": null,\n    \"cash_from_operating_activities\": 54687000000.0,\n    \"acquisition_of_property_plant_and_equipment\": null,\n    \"acquisition_of_business\": -1404000000.0,\n    \"cash_from_investing_activities\": -15155000000.0,\n    \"payments_of_dividends\": -8668000000.0,\n    \"issuance_of_common_stock\": null,\n    \"repurchase_of_common_stock\": -14687000000.0,\n    \"issuance_of_long_term_debt\": 363000000.0,\n    \"repayment_of_long_term_debt\": -9672000000.0,\n    \"cash_from_financing_activities\": -38435000000.0,\n    \"change_in_cash\": 1097000000.0,\n    \"cash_at_end_of_period\": 39110000000.0\n}";
        using var doc = JsonDocument.Parse(json);
        var cashFlow = FinancialDataSerializer.Instance.Deserialize<InternationalCashFlow>(doc);
        Assert.AreEqual("SHEL.L", cashFlow.TradingSymbol);
        Assert.AreEqual("Shell plc", cashFlow.RegistrantName);
        Assert.AreEqual("FY", cashFlow.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 12, 31), cashFlow.PeriodEndDate);
        Assert.AreEqual("USD", cashFlow.CurrencyCode);
        Assert.AreEqual(22703000000.0m, cashFlow.DepreciationAndAmortization);
        Assert.AreEqual(0m, cashFlow.ShareBasedCompensationExpense);
        Assert.AreEqual(0m, cashFlow.ChangeInAccountsReceivable);
        Assert.AreEqual(1273000000.0m, cashFlow.ChangeInInventories);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherAssets);
        Assert.AreEqual(0m, cashFlow.ChangeInAccountsPayable);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherLiabilities);
        Assert.AreEqual(54687000000.0m, cashFlow.CashFromOperatingActivities);
        Assert.AreEqual(0m, cashFlow.AcquisitionOfPropertyPlantAndEquipment);
        Assert.AreEqual(-1404000000.0m, cashFlow.AcquisitionOfBusiness);
        Assert.AreEqual(-15155000000.0m, cashFlow.CashFromInvestingActivities);
        Assert.AreEqual(-8668000000.0m, cashFlow.PaymentsOfDividends);
        Assert.AreEqual(0m, cashFlow.IssuanceOfCommonStock);
        Assert.AreEqual(-14687000000.0m, cashFlow.RepurchaseOfCommonStock);
        Assert.AreEqual(363000000.0m, cashFlow.IssuanceOfLongTermDebt);
        Assert.AreEqual(-9672000000.0m, cashFlow.RepaymentOfLongTermDebt);
        Assert.AreEqual(-38435000000.0m, cashFlow.CashFromFinancingActivities);
        Assert.AreEqual(1097000000.0m, cashFlow.ChangeInCash);
        Assert.AreEqual(39110000000.0m, cashFlow.CashAtEndOfPeriod);
    }
}
