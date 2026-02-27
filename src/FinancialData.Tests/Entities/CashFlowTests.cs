using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class CashFlowTests
{
    [TestMethod]
    public void CashFlow_Initialization_Works()
    {
        var cashFlow = new CashFlow
        {
            TradingSymbol = "MSFT",
            CentralIndexKey = "0000789019",
            RegistrantName = "MICROSOFT CORP",
            FiscalYear = "2024",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 6, 30),
            DepreciationAndAmortization = 22287000000.0m,
            ShareBasedCompensationExpense = 10734000000.0m,
            DeferredIncomeTaxExpense = -4738000000.0m,
            OtherNonCashIncomeExpense = 0m,
            ChangeInAccountsReceivable = 7191000000.0m,
            ChangeInInventories = -1284000000.0m,
            ChangeInNonTradeReceivables = 0m,
            ChangeInOtherAssets = 0m,
            ChangeInAccountsPayable = 3545000000.0m,
            ChangeInDeferredRevenue = 5348000000.0m,
            ChangeInOtherLiabilities = 0m,
            CashFromOperatingActivities = 118548000000.0m,
            PurchasesOfMarketableSecurities = 17732000000.0m,
            SalesOfMarketableSecurities = 24775000000.0m,
            AcquisitionOfPropertyPlantAndEquipment = 44477000000.0m,
            AcquisitionOfBusiness = 0m,
            OtherInvestingActivities = 1298000000.0m,
            CashFromInvestingActivities = -96970000000.0m,
            TaxWithholdingForShareBasedCompensation = 5300000000.0m,
            PaymentsOfDividends = 22296000000.0m,
            IssuanceOfCommonStock = 2002000000.0m,
            RepurchaseOfCommonStock = 17254000000.0m,
            IssuanceOfLongTermDebt = 0m,
            RepaymentOfLongTermDebt = 0m,
            OtherFinancingActivities = -1309000000.0m,
            CashFromFinancingActivities = -37757000000.0m,
            ChangeInCash = -16389000000.0m,
            CashAtEndOfPeriod = 90143000000.0m,
            IncomeTaxesPaid = 23400000000.0m,
            InterestPaid = 1700000000.0m
        };
        Assert.AreEqual("MSFT", cashFlow.TradingSymbol);
        Assert.AreEqual("0000789019", cashFlow.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", cashFlow.RegistrantName);
        Assert.AreEqual("2024", cashFlow.FiscalYear);
        Assert.AreEqual("FY", cashFlow.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), cashFlow.PeriodEndDate);
        Assert.AreEqual(22287000000.0m, cashFlow.DepreciationAndAmortization);
        Assert.AreEqual(10734000000.0m, cashFlow.ShareBasedCompensationExpense);
        Assert.AreEqual(-4738000000.0m, cashFlow.DeferredIncomeTaxExpense);
        Assert.AreEqual(0m, cashFlow.OtherNonCashIncomeExpense);
        Assert.AreEqual(7191000000.0m, cashFlow.ChangeInAccountsReceivable);
        Assert.AreEqual(-1284000000.0m, cashFlow.ChangeInInventories);
        Assert.AreEqual(0m, cashFlow.ChangeInNonTradeReceivables);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherAssets);
        Assert.AreEqual(3545000000.0m, cashFlow.ChangeInAccountsPayable);
        Assert.AreEqual(5348000000.0m, cashFlow.ChangeInDeferredRevenue);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherLiabilities);
        Assert.AreEqual(118548000000.0m, cashFlow.CashFromOperatingActivities);
        Assert.AreEqual(17732000000.0m, cashFlow.PurchasesOfMarketableSecurities);
        Assert.AreEqual(24775000000.0m, cashFlow.SalesOfMarketableSecurities);
        Assert.AreEqual(44477000000.0m, cashFlow.AcquisitionOfPropertyPlantAndEquipment);
        Assert.AreEqual(0m, cashFlow.AcquisitionOfBusiness);
        Assert.AreEqual(1298000000.0m, cashFlow.OtherInvestingActivities);
        Assert.AreEqual(-96970000000.0m, cashFlow.CashFromInvestingActivities);
        Assert.AreEqual(5300000000.0m, cashFlow.TaxWithholdingForShareBasedCompensation);
        Assert.AreEqual(22296000000.0m, cashFlow.PaymentsOfDividends);
        Assert.AreEqual(2002000000.0m, cashFlow.IssuanceOfCommonStock);
        Assert.AreEqual(17254000000.0m, cashFlow.RepurchaseOfCommonStock);
        Assert.AreEqual(0m, cashFlow.IssuanceOfLongTermDebt);
        Assert.AreEqual(0m, cashFlow.RepaymentOfLongTermDebt);
        Assert.AreEqual(-1309000000.0m, cashFlow.OtherFinancingActivities);
        Assert.AreEqual(-37757000000.0m, cashFlow.CashFromFinancingActivities);
        Assert.AreEqual(-16389000000.0m, cashFlow.ChangeInCash);
        Assert.AreEqual(90143000000.0m, cashFlow.CashAtEndOfPeriod);
        Assert.AreEqual(23400000000.0m, cashFlow.IncomeTaxesPaid);
        Assert.AreEqual(1700000000.0m, cashFlow.InterestPaid);
    }

    [TestMethod]
    public void CashFlow_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"MSFT\",\n    \"central_index_key\": \"0000789019\",\n    \"registrant_name\": \"MICROSOFT CORP\",\n    \"fiscal_year\": \"2024\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-06-30\",\n    \"depreciation_and_amortization\": 22287000000.0,\n    \"share_based_compensation_expense\": 10734000000.0,\n    \"deferred_income_tax_expense\": -4738000000.0,\n    \"other_non_cash_income_expense\": null,\n    \"change_in_accounts_receivable\": 7191000000.0,\n    \"change_in_inventories\": -1284000000.0,\n    \"change_in_non_trade_receivables\": null,\n    \"change_in_other_assets\": null,\n    \"change_in_accounts_payable\": 3545000000.0,\n    \"change_in_deferred_revenue\": 5348000000.0,\n    \"change_in_other_liabilities\": null,\n    \"cash_from_operating_activities\": 118548000000.0,\n    \"purchases_of_marketable_securities\": 17732000000.0,\n    \"sales_of_marketable_securities\": 24775000000.0,\n    \"acquisition_of_property_plant_and_equipment\": 44477000000.0,\n    \"acquisition_of_business\": null,\n    \"other_investing_activities\": 1298000000.0,\n    \"cash_from_investing_activities\": -96970000000.0,\n    \"tax_withholding_for_share_based_compensation\": 5300000000.0,\n    \"payments_of_dividends\": 22296000000.0,\n    \"issuance_of_common_stock\": 2002000000.0,\n    \"repurchase_of_common_stock\": 17254000000.0,\n    \"issuance_of_long_term_debt\": null,\n    \"repayment_of_long_term_debt\": null,\n    \"other_financing_activities\": -1309000000.0,\n    \"cash_from_financing_activities\": -37757000000.0,\n    \"change_in_cash\": -16389000000.0,\n    \"cash_at_end_of_period\": 90143000000.0,\n    \"income_taxes_paid\": 23400000000.0,\n    \"interest_paid\": 1700000000.0\n}";
        using var doc = JsonDocument.Parse(json);
        var cashFlow = FinancialDataSerializer.Instance.Deserialize<CashFlow>(doc);
        Assert.AreEqual("MSFT", cashFlow.TradingSymbol);
        Assert.AreEqual("0000789019", cashFlow.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", cashFlow.RegistrantName);
        Assert.AreEqual("2024", cashFlow.FiscalYear);
        Assert.AreEqual("FY", cashFlow.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), cashFlow.PeriodEndDate);
        Assert.AreEqual(22287000000.0m, cashFlow.DepreciationAndAmortization);
        Assert.AreEqual(10734000000.0m, cashFlow.ShareBasedCompensationExpense);
        Assert.AreEqual(-4738000000.0m, cashFlow.DeferredIncomeTaxExpense);
        Assert.AreEqual(0m, cashFlow.OtherNonCashIncomeExpense);
        Assert.AreEqual(7191000000.0m, cashFlow.ChangeInAccountsReceivable);
        Assert.AreEqual(-1284000000.0m, cashFlow.ChangeInInventories);
        Assert.AreEqual(0m, cashFlow.ChangeInNonTradeReceivables);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherAssets);
        Assert.AreEqual(3545000000.0m, cashFlow.ChangeInAccountsPayable);
        Assert.AreEqual(5348000000.0m, cashFlow.ChangeInDeferredRevenue);
        Assert.AreEqual(0m, cashFlow.ChangeInOtherLiabilities);
        Assert.AreEqual(118548000000.0m, cashFlow.CashFromOperatingActivities);
        Assert.AreEqual(17732000000.0m, cashFlow.PurchasesOfMarketableSecurities);
        Assert.AreEqual(24775000000.0m, cashFlow.SalesOfMarketableSecurities);
        Assert.AreEqual(44477000000.0m, cashFlow.AcquisitionOfPropertyPlantAndEquipment);
        Assert.AreEqual(0m, cashFlow.AcquisitionOfBusiness);
        Assert.AreEqual(1298000000.0m, cashFlow.OtherInvestingActivities);
        Assert.AreEqual(-96970000000.0m, cashFlow.CashFromInvestingActivities);
        Assert.AreEqual(5300000000.0m, cashFlow.TaxWithholdingForShareBasedCompensation);
        Assert.AreEqual(22296000000.0m, cashFlow.PaymentsOfDividends);
        Assert.AreEqual(2002000000.0m, cashFlow.IssuanceOfCommonStock);
        Assert.AreEqual(17254000000.0m, cashFlow.RepurchaseOfCommonStock);
        Assert.AreEqual(0m, cashFlow.IssuanceOfLongTermDebt);
        Assert.AreEqual(0m, cashFlow.RepaymentOfLongTermDebt);
        Assert.AreEqual(-1309000000.0m, cashFlow.OtherFinancingActivities);
        Assert.AreEqual(-37757000000.0m, cashFlow.CashFromFinancingActivities);
        Assert.AreEqual(-16389000000.0m, cashFlow.ChangeInCash);
        Assert.AreEqual(90143000000.0m, cashFlow.CashAtEndOfPeriod);
        Assert.AreEqual(23400000000.0m, cashFlow.IncomeTaxesPaid);
        Assert.AreEqual(1700000000.0m, cashFlow.InterestPaid);
    }
}
