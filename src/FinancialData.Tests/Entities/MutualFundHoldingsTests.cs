using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class MutualFundHoldingsTests
    {
        [TestMethod]
        public void MutualFundHoldings_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""central_index_key"": ""0000036405"",
    ""registrant_name"": ""VANGUARD INDEX FUNDS"",
    ""period_of_report"": ""2025-06-30"",
    ""fund_name"": ""Admiral Shares"",
    ""fund_symbol"": ""VTSAX"",
    ""series_id"": ""S000002848"",
    ""class_id"": ""C000007806"",
    ""issuer_name"": ""Frequency Electronics Inc"",
    ""lei_number"": ""549300S56SO2JB5JBE31"",
    ""title_of_security"": ""FREQUENCY ELECT"",
    ""trading_symbol"": ""FEIM"",
    ""cusip_number"": ""358010106"",
    ""isin_number"": ""US3580101067"",
    ""amount_of_units"": 228179,
    ""description_of_units"": ""NS"",
    ""denomination_currency"": ""USD"",
    ""value_in_usd"": 5181945.09,
    ""percentage_value_compared_to_assets"": 0.000271384232,
    ""payoff_profile"": ""Long"",
    ""asset_type"": ""EC"",
    ""issuer_type"": ""CORP"",
    ""country_of_issuer_or_investment"": ""US"",
    ""is_restricted_security"": false,
    ""fair_value_level"": 1,
    ""is_cash_collateral"": false,
    ""is_non_cash_collateral"": false,
    ""is_loan_by_fund"": true
}";
            using var doc = JsonDocument.Parse(json);
            var mutualFundHoldings = FinancialDataSerializer.Instance.Deserialize<MutualFundHoldings>(doc);
            Assert.AreEqual("0000036405", mutualFundHoldings.CentralIndexKey);
            Assert.AreEqual("VANGUARD INDEX FUNDS", mutualFundHoldings.RegistrantName);
            Assert.AreEqual(new DateOnly(2025, 6, 30), mutualFundHoldings.PeriodOfReport);
            Assert.AreEqual("Admiral Shares", mutualFundHoldings.FundName);
            Assert.AreEqual("VTSAX", mutualFundHoldings.FundSymbol);
            Assert.AreEqual("S000002848", mutualFundHoldings.SeriesId);
            Assert.AreEqual("C000007806", mutualFundHoldings.ClassId);
            Assert.AreEqual("Frequency Electronics Inc", mutualFundHoldings.IssuerName);
            Assert.AreEqual("549300S56SO2JB5JBE31", mutualFundHoldings.LeiNumber);
            Assert.AreEqual("FREQUENCY ELECT", mutualFundHoldings.TitleOfSecurity);
            Assert.AreEqual("FEIM", mutualFundHoldings.TradingSymbol);
            Assert.AreEqual("358010106", mutualFundHoldings.CusipNumber);
            Assert.AreEqual("US3580101067", mutualFundHoldings.IsinNumber);
            Assert.AreEqual(228179m, mutualFundHoldings.AmountOfUnits);
            Assert.AreEqual("NS", mutualFundHoldings.DescriptionOfUnits);
            Assert.AreEqual("USD", mutualFundHoldings.DenominationCurrency);
            Assert.AreEqual(5181945.09m, mutualFundHoldings.ValueInUsd);
            Assert.AreEqual(0.000271384232m, mutualFundHoldings.PercentageValueComparedToAssets);
            Assert.AreEqual("Long", mutualFundHoldings.PayoffProfile);
            Assert.AreEqual("EC", mutualFundHoldings.AssetType);
            Assert.AreEqual("CORP", mutualFundHoldings.IssuerType);
            Assert.AreEqual("US", mutualFundHoldings.CountryOfIssuerOrInvestment);
            Assert.IsFalse(mutualFundHoldings.IsRestrictedSecurity);
            Assert.AreEqual(1, mutualFundHoldings.FairValueLevel);
            Assert.IsFalse(mutualFundHoldings.IsCashCollateral);
            Assert.IsFalse(mutualFundHoldings.IsNonCashCollateral);
            Assert.IsTrue(mutualFundHoldings.IsLoanByFund);
        }
    }
}
