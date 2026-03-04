using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Tudormobile.FinancialData.Entities;
using Tudormobile.FinancialData;

namespace FinancialData.Tests.Entities
{
    [TestClass]
    public class MutualFundStatisticsTests
    {
        [TestMethod]
        public void MutualFundStatistics_Deserialize_FromJson_Works()
        {
            var json = @"{
    ""central_index_key"": ""0000036405"",
    ""registrant_name"": ""VANGUARD INDEX FUNDS"",
    ""period_of_report"": ""2025-06-30"",
    ""fund_name"": ""Admiral Shares"",
    ""fund_symbol"": ""VTSAX"",
    ""series_id"": ""S000002848"",
    ""class_id"": ""C000007806"",
    ""total_assets"": 1915212703487.01,
    ""total_liabilities"": 5763123365.99,
    ""net_assets"": 1909449580121.02,
    ""return_preceding_month1"": -0.6729,
    ""return_preceding_month2"": 6.3455,
    ""return_preceding_month3"": 5.07574,
    ""realized_gain_preceding_month1"": 983065935.64,
    ""change_in_unrealized_appreciation_preceding_month1"": -11394591977.19,
    ""realized_gain_preceding_month2"": 287029511.93,
    ""change_in_unrealized_appreciation_preceding_month2"": 105734824564.66,
    ""realized_gain_preceding_month3"": 2243886605.76,
    ""change_in_unrealized_appreciation_preceding_month3"": 87596494350.2,
    ""share_sale_preceding_month1"": 30533447572.6504,
    ""share_redemption_preceding_month1"": 9354960674.63,
    ""share_sale_preceding_month2"": 9024030148.45996,
    ""share_redemption_preceding_month2"": 9833704993.95,
    ""share_sale_preceding_month3"": 12681244786.0796,
    ""share_redemption_preceding_month3"": 12999259996.1
}";
            using var doc = JsonDocument.Parse(json);
            var mutualFundStatistics = FinancialDataSerializer.Instance.Deserialize<MutualFundStatistics>(doc);
            Assert.AreEqual("0000036405", mutualFundStatistics.CentralIndexKey);
            Assert.AreEqual("VTSAX", mutualFundStatistics.FundSymbol);
            Assert.AreEqual(1915212703487.01m, mutualFundStatistics.TotalAssets);
            Assert.AreEqual(1909449580121.02m, mutualFundStatistics.NetAssets);
            Assert.AreEqual(-0.6729m, mutualFundStatistics.ReturnPrecedingMonth1);
        }
    }
}
