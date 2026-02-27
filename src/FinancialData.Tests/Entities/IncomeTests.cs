using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class IncomeTests
{
    [TestMethod]
    public void Income_Initialization_Works()
    {
        var income = new Income
        {
            TradingSymbol = "MSFT",
            CentralIndexKey = "0000789019",
            RegistrantName = "MICROSOFT CORP",
            FiscalYear = "2024",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 6, 30),
            Revenue = 245122000000.0m,
            CostOfRevenue = 74114000000.0m,
            GrossProfit = 171008000000.0m,
            ResearchAndDevelopmentExpenses = 29510000000.0m,
            GeneralAndAdministrativeExpenses = 7609000000.0m,
            OperatingExpenses = 0m,
            OperatingIncome = 109433000000.0m,
            InterestExpense = 2935000000.0m,
            InterestIncome = 3157000000.0m,
            NetIncome = 88136000000.0m,
            EarningsPerShareBasic = 11.86m,
            EarningsPerShareDiluted = 11.8m,
            WeightedAverageSharesOutstandingBasic = 7431000000m,
            WeightedAverageSharesOutstandingDiluted = 7469000000m
        };
        Assert.AreEqual("MSFT", income.TradingSymbol);
        Assert.AreEqual("0000789019", income.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", income.RegistrantName);
        Assert.AreEqual("2024", income.FiscalYear);
        Assert.AreEqual("FY", income.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), income.PeriodEndDate);
        Assert.AreEqual(245122000000.0m, income.Revenue);
        Assert.AreEqual(74114000000.0m, income.CostOfRevenue);
        Assert.AreEqual(171008000000.0m, income.GrossProfit);
        Assert.AreEqual(29510000000.0m, income.ResearchAndDevelopmentExpenses);
        Assert.AreEqual(7609000000.0m, income.GeneralAndAdministrativeExpenses);
        Assert.AreEqual(0m, income.OperatingExpenses);
        Assert.AreEqual(109433000000.0m, income.OperatingIncome);
        Assert.AreEqual(2935000000.0m, income.InterestExpense);
        Assert.AreEqual(3157000000.0m, income.InterestIncome);
        Assert.AreEqual(88136000000.0m, income.NetIncome);
        Assert.AreEqual(11.86m, income.EarningsPerShareBasic);
        Assert.AreEqual(11.8m, income.EarningsPerShareDiluted);
        Assert.AreEqual(7431000000m, income.WeightedAverageSharesOutstandingBasic);
        Assert.AreEqual(7469000000m, income.WeightedAverageSharesOutstandingDiluted);
    }

    [TestMethod]
    public void Income_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"MSFT\",\n    \"central_index_key\": \"0000789019\",\n    \"registrant_name\": \"MICROSOFT CORP\",\n    \"fiscal_year\": \"2024\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-06-30\",\n    \"revenue\": 245122000000.0,\n    \"cost_of_revenue\": 74114000000.0,\n    \"gross_profit\": 171008000000.0,\n    \"research_and_development_expenses\": 29510000000.0,\n    \"general_and_administrative_expenses\": 7609000000.0,\n    \"operating_expenses\": null,\n    \"operating_income\": 109433000000.0,\n    \"interest_expense\": 2935000000.0,\n    \"interest_income\": 3157000000.0,\n    \"net_income\": 88136000000.0,\n    \"earnings_per_share_basic\": 11.86,\n    \"earnings_per_share_diluted\": 11.8,\n    \"weighted_average_shares_outstanding_basic\": 7431000000,\n    \"weighted_average_shares_outstanding_diluted\": 7469000000\n}";
        using var doc = JsonDocument.Parse(json);
        var income = FinancialDataSerializer.Instance.Deserialize<Income>(doc);
        Assert.AreEqual("MSFT", income.TradingSymbol);
        Assert.AreEqual("0000789019", income.CentralIndexKey);
        Assert.AreEqual("MICROSOFT CORP", income.RegistrantName);
        Assert.AreEqual("2024", income.FiscalYear);
        Assert.AreEqual("FY", income.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 6, 30), income.PeriodEndDate);
        Assert.AreEqual(245122000000.0m, income.Revenue);
        Assert.AreEqual(74114000000.0m, income.CostOfRevenue);
        Assert.AreEqual(171008000000.0m, income.GrossProfit);
        Assert.AreEqual(29510000000.0m, income.ResearchAndDevelopmentExpenses);
        Assert.AreEqual(7609000000.0m, income.GeneralAndAdministrativeExpenses);
        Assert.AreEqual(0m, income.OperatingExpenses);
        Assert.AreEqual(109433000000.0m, income.OperatingIncome);
        Assert.AreEqual(2935000000.0m, income.InterestExpense);
        Assert.AreEqual(3157000000.0m, income.InterestIncome);
        Assert.AreEqual(88136000000.0m, income.NetIncome);
        Assert.AreEqual(11.86m, income.EarningsPerShareBasic);
        Assert.AreEqual(11.8m, income.EarningsPerShareDiluted);
        Assert.AreEqual(7431000000m, income.WeightedAverageSharesOutstandingBasic);
        Assert.AreEqual(7469000000m, income.WeightedAverageSharesOutstandingDiluted);
    }
}
