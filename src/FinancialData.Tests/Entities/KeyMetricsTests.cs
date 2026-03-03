using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class KeyMetricsTests
    {
        [TestMethod]
        public void KeyMetrics_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""trading_symbol"": ""AAPL"",
    ""central_index_key"": ""0000320193"",
    ""registrant_name"": ""Apple Inc."",
    ""fiscal_year"": ""2024"",
    ""period_end_date"": ""2024-09-30"",
    ""earnings_per_share"": 6.42,
    ""earnings_per_share_forecast"": 6.50,
    ""price_to_earnings_ratio"": 28.5,
    ""forward_price_to_earnings_ratio"": 27.8,
    ""price_to_book_ratio"": 45.2,
    ""ebitda"": 131000000000.0,
    ""free_cash_flow"": 99000000000.0,
    ""return_on_equity"": 0.625,
    ""one_year_beta"": 1.25,
    ""debt_to_equity_ratio"": null
}";
            using var doc = JsonDocument.Parse(json);
            var keyMetrics = FinancialDataSerializer.Instance.Deserialize<KeyMetrics>(doc);
            Assert.AreEqual("AAPL", keyMetrics.TradingSymbol);
            Assert.AreEqual(6.42m, keyMetrics.EarningsPerShare);
            Assert.AreEqual(28.5m, keyMetrics.PriceToEarningsRatio);
            Assert.AreEqual(99000000000m, keyMetrics.FreeCashFlow);
            Assert.AreEqual(0m, keyMetrics.DebtToEquityRatio);
        }
    }
}
