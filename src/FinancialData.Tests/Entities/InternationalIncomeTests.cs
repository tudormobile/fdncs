using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class InternationalIncomeTests
{
    [TestMethod]
    public void InternationalIncome_Initialization_Works()
    {
        var income = new InternationalIncome
        {
            TradingSymbol = "SHEL.L",
            RegistrantName = "Shell plc",
            FiscalPeriod = "FY",
            PeriodEndDate = new DateOnly(2024, 12, 31),
            CurrencyCode = "USD",
            Revenue = 284312000000.0m,
            CostOfRevenue = 238371000000.0m,
            GrossProfit = 45941000000.0m,
            ResearchAndDevelopmentExpenses = 1099000000.0m,
            GeneralAndAdministrativeExpenses = 12439000000.0m,
            OperatingExpenses = 15949000000.0m,
            OperatingIncome = 29992000000.0m,
            InterestExpense = 4858000000.0m,
            InterestIncome = 2461000000.0m,
            NetIncome = 16094000000.0m,
            EarningsPerShareBasic = 2.55m,
            EarningsPerShareDiluted = 2.53m,
            WeightedAverageSharesOutstandingBasic = 6299600000m,
            WeightedAverageSharesOutstandingDiluted = 6363700000m
        };
        Assert.AreEqual("SHEL.L", income.TradingSymbol);
        Assert.AreEqual("Shell plc", income.RegistrantName);
        Assert.AreEqual("FY", income.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 12, 31), income.PeriodEndDate);
        Assert.AreEqual("USD", income.CurrencyCode);
        Assert.AreEqual(284312000000.0m, income.Revenue);
        Assert.AreEqual(238371000000.0m, income.CostOfRevenue);
        Assert.AreEqual(45941000000.0m, income.GrossProfit);
        Assert.AreEqual(1099000000.0m, income.ResearchAndDevelopmentExpenses);
        Assert.AreEqual(12439000000.0m, income.GeneralAndAdministrativeExpenses);
        Assert.AreEqual(15949000000.0m, income.OperatingExpenses);
        Assert.AreEqual(29992000000.0m, income.OperatingIncome);
        Assert.AreEqual(4858000000.0m, income.InterestExpense);
        Assert.AreEqual(2461000000.0m, income.InterestIncome);
        Assert.AreEqual(16094000000.0m, income.NetIncome);
        Assert.AreEqual(2.55m, income.EarningsPerShareBasic);
        Assert.AreEqual(2.53m, income.EarningsPerShareDiluted);
        Assert.AreEqual(6299600000m, income.WeightedAverageSharesOutstandingBasic);
        Assert.AreEqual(6363700000m, income.WeightedAverageSharesOutstandingDiluted);
    }

    [TestMethod]
    public void InternationalIncome_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"SHEL.L\",\n    \"registrant_name\": \"Shell plc\",\n    \"fiscal_period\": \"FY\",\n    \"period_end_date\": \"2024-12-31\",\n    \"currency_code\": \"USD\",\n    \"revenue\": 284312000000.0,\n    \"cost_of_revenue\": 238371000000.0,\n    \"gross_profit\": 45941000000.0,\n    \"research_and_development_expenses\": 1099000000.0,\n    \"general_and_administrative_expenses\": 12439000000.0,\n    \"operating_expenses\": 15949000000.0,\n    \"operating_income\": 29992000000.0,\n    \"interest_expense\": 4858000000.0,\n    \"interest_income\": 2461000000.0,\n    \"net_income\": 16094000000.0,\n    \"earnings_per_share_basic\": 2.55,\n    \"earnings_per_share_diluted\": 2.53,\n    \"weighted_average_shares_outstanding_basic\": 6299600000,\n    \"weighted_average_shares_outstanding_diluted\": 6363700000\n}";
        using var doc = JsonDocument.Parse(json);
        var income = FinancialDataSerializer.Instance.Deserialize<InternationalIncome>(doc);
        Assert.AreEqual("SHEL.L", income.TradingSymbol);
        Assert.AreEqual("Shell plc", income.RegistrantName);
        Assert.AreEqual("FY", income.FiscalPeriod);
        Assert.AreEqual(new DateOnly(2024, 12, 31), income.PeriodEndDate);
        Assert.AreEqual("USD", income.CurrencyCode);
        Assert.AreEqual(284312000000.0m, income.Revenue);
        Assert.AreEqual(238371000000.0m, income.CostOfRevenue);
        Assert.AreEqual(45941000000.0m, income.GrossProfit);
        Assert.AreEqual(1099000000.0m, income.ResearchAndDevelopmentExpenses);
        Assert.AreEqual(12439000000.0m, income.GeneralAndAdministrativeExpenses);
        Assert.AreEqual(15949000000.0m, income.OperatingExpenses);
        Assert.AreEqual(29992000000.0m, income.OperatingIncome);
        Assert.AreEqual(4858000000.0m, income.InterestExpense);
        Assert.AreEqual(2461000000.0m, income.InterestIncome);
        Assert.AreEqual(16094000000.0m, income.NetIncome);
        Assert.AreEqual(2.55m, income.EarningsPerShareBasic);
        Assert.AreEqual(2.53m, income.EarningsPerShareDiluted);
        Assert.AreEqual(6299600000m, income.WeightedAverageSharesOutstandingBasic);
        Assert.AreEqual(6363700000m, income.WeightedAverageSharesOutstandingDiluted);
    }
}
