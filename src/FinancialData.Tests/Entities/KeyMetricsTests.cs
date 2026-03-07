using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class KeyMetricsTests
    {
        [TestMethod]
        public void KeyMetrics_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""MSFT"",
    ""central_index_key"": ""0000789019"",
    ""registrant_name"": ""MICROSOFT CORP"",
    ""fiscal_year"": ""2024"",
    ""period_end_date"": ""2024-06-30"",
    ""earnings_per_share"": 11.86,
    ""earnings_per_share_forecast"": 13.33,
    ""price_to_earnings_ratio"": 38.5101180438449,
    ""forward_price_to_earnings_ratio"": 34.2633158289572,
    ""earnings_growth_rate"": 22.0164609053498,
    ""price_earnings_to_growth_ratio"": 1.74915115601015,
    ""book_value_per_share"": 36.1293231059077,
    ""price_to_book_ratio"": 12.6415321610417,
    ""ebitda"": 136758000000.0,
    ""enterprise_value"": 3351003630000.0,
    ""dividend_yield"": 0.00656931603829476,
    ""dividend_payout_ratio"": 0.252972678587637,
    ""debt_to_equity_ratio"": 0.17575434767224,
    ""capital_expenditures"": 62237000000.0,
    ""free_cash_flow"": 56311000000.0,
    ""return_on_equity"": 0.328281379782998,
    ""one_year_beta"": 1.19353548418252,
    ""three_year_beta"": 1.25034202198802,
    ""five_year_beta"": 1.19116942054093
  }";
            using var doc = JsonDocument.Parse(json);
            var keyMetrics = FinancialDataSerializer.Instance.Deserialize<KeyMetrics>(doc);
            Assert.AreEqual("MSFT", keyMetrics.TradingSymbol);
            Assert.AreEqual("0000789019", keyMetrics.CentralIndexKey);
            Assert.AreEqual("MICROSOFT CORP", keyMetrics.RegistrantName);
            Assert.AreEqual("2024", keyMetrics.FiscalYear);
            Assert.AreEqual(new DateOnly(2024, 6, 30), keyMetrics.PeriodEndDate);
            Assert.AreEqual(11.86m, keyMetrics.EarningsPerShare);
            Assert.AreEqual(13.33m, keyMetrics.EarningsPerShareForecast);
            Assert.AreEqual(38.5101180438449m, keyMetrics.PriceToEarningsRatio);
            Assert.AreEqual(34.2633158289572m, keyMetrics.ForwardPriceToEarningsRatio);
            Assert.AreEqual(22.0164609053498m, keyMetrics.EarningsGrowthRate);
            Assert.AreEqual(1.74915115601015m, keyMetrics.PriceEarningsToGrowthRatio);
            Assert.AreEqual(36.1293231059077m, keyMetrics.BookValuePerShare);
            Assert.AreEqual(12.6415321610417m, keyMetrics.PriceToBookRatio);
            Assert.AreEqual(136758000000m, keyMetrics.Ebitda);
            Assert.AreEqual(3351003630000m, keyMetrics.EnterpriseValue);
            Assert.AreEqual(0.00656931603829476m, keyMetrics.DividendYield);
            Assert.AreEqual(0.252972678587637m, keyMetrics.DividendPayoutRatio);
            Assert.AreEqual(0.17575434767224m, keyMetrics.DebtToEquityRatio);
            Assert.AreEqual(62237000000m, keyMetrics.CapitalExpenditures);
            Assert.AreEqual(56311000000m, keyMetrics.FreeCashFlow);
            Assert.AreEqual(0.328281379782998m, keyMetrics.ReturnOnEquity);
            Assert.AreEqual(1.19353548418252m, keyMetrics.OneYearBeta);
            Assert.AreEqual(1.25034202198802m, keyMetrics.ThreeYearBeta);
            Assert.AreEqual(1.19116942054093m, keyMetrics.FiveYearBeta);
        }
    }
}
