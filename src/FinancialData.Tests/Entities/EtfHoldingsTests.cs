using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class EtfHoldingsTests
    {
        [TestMethod]
        public void EtfHoldings_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""central_index_key"": ""0000884394"",
    ""registrant_name"": ""SPDR S&P 500 ETF TRUST"",
    ""period_of_report"": ""2025-06-30"",
    ""etf_name"": ""SPDR S&P 500 ETF TRUST"",
    ""etf_symbol"": ""SPY"",
    ""series_id"": ""N/A"",
    ""class_id"": ""N/A"",
    ""issuer_name"": ""Johnson & Johnson"",
    ""lei_number"": ""549300G0CFPGEF6X2043"",
    ""title_of_security"": ""Johnson & Johnson"",
    ""trading_symbol"": ""JNJ"",
    ""cusip_number"": ""478160104"",
    ""isin_number"": ""US4781601046"",
    ""amount_of_units"": 29181009,
    ""description_of_units"": ""NS"",
    ""denomination_currency"": ""USD"",
    ""value_in_usd"": 4457399124.75,
    ""percentage_value_compared_to_assets"": 0.699985772661,
    ""payoff_profile"": ""Long"",
    ""asset_type"": ""EC"",
    ""issuer_type"": ""CORP"",
    ""country_of_issuer_or_investment"": ""US"",
    ""is_restricted_security"": false,
    ""fair_value_level"": 1,
    ""is_cash_collateral"": false,
    ""is_non_cash_collateral"": false,
    ""is_loan_by_fund"": false
}";
            using var doc = JsonDocument.Parse(json);
            var etfHoldings = FinancialDataSerializer.Instance.Deserialize<EtfHoldings>(doc);
            Assert.AreEqual("0000884394", etfHoldings.CentralIndexKey);
            Assert.AreEqual("SPY", etfHoldings.EtfSymbol);
            Assert.AreEqual("JNJ", etfHoldings.TradingSymbol);
            Assert.AreEqual(4457399124.75m, etfHoldings.ValueInUsd);
            Assert.AreEqual(false, etfHoldings.IsRestrictedSecurity);
        }
    }
}
