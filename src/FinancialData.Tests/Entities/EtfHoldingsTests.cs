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
            Assert.AreEqual("SPDR S&P 500 ETF TRUST", etfHoldings.RegistrantName);
            Assert.AreEqual(new DateOnly(2025, 6, 30), etfHoldings.PeriodOfReport);
            Assert.AreEqual("SPDR S&P 500 ETF TRUST", etfHoldings.EtfName);
            Assert.AreEqual("SPY", etfHoldings.EtfSymbol);
            Assert.AreEqual("N/A", etfHoldings.SeriesId);
            Assert.AreEqual("N/A", etfHoldings.ClassId);
            Assert.AreEqual("Johnson & Johnson", etfHoldings.IssuerName);
            Assert.AreEqual("549300G0CFPGEF6X2043", etfHoldings.LeiNumber);
            Assert.AreEqual("Johnson & Johnson", etfHoldings.TitleOfSecurity);
            Assert.AreEqual("JNJ", etfHoldings.TradingSymbol);
            Assert.AreEqual("478160104", etfHoldings.CusipNumber);
            Assert.AreEqual("US4781601046", etfHoldings.IsinNumber);
            Assert.AreEqual(29181009m, etfHoldings.AmountOfUnits);
            Assert.AreEqual("NS", etfHoldings.DescriptionOfUnits);
            Assert.AreEqual("USD", etfHoldings.DenominationCurrency);
            Assert.AreEqual(4457399124.75m, etfHoldings.ValueInUsd);
            Assert.AreEqual(0.699985772661m, etfHoldings.PercentageValueComparedToAssets);
            Assert.AreEqual("Long", etfHoldings.PayoffProfile);
            Assert.AreEqual("EC", etfHoldings.AssetType);
            Assert.AreEqual("CORP", etfHoldings.IssuerType);
            Assert.AreEqual("US", etfHoldings.CountryOfIssuerOrInvestment);
            Assert.IsFalse(etfHoldings.IsRestrictedSecurity);
            Assert.AreEqual(1, etfHoldings.FairValueLevel);
            Assert.IsFalse(etfHoldings.IsCashCollateral);
            Assert.IsFalse(etfHoldings.IsNonCashCollateral);
            Assert.IsFalse(etfHoldings.IsLoanByFund);
        }
    }
}
