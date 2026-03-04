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
            Assert.AreEqual("VTSAX", mutualFundHoldings.FundSymbol);
            Assert.AreEqual("FEIM", mutualFundHoldings.TradingSymbol);
            Assert.AreEqual(5181945.09m, mutualFundHoldings.ValueInUsd);
            Assert.AreEqual(true, mutualFundHoldings.IsLoanByFund);
        }
    }
}
