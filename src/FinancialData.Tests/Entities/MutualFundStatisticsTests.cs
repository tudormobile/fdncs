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
            Assert.AreEqual("VANGUARD INDEX FUNDS", mutualFundStatistics.RegistrantName);
            Assert.AreEqual(new DateOnly(2025, 6, 30), mutualFundStatistics.PeriodOfReport);
            Assert.AreEqual("Admiral Shares", mutualFundStatistics.FundName);
            Assert.AreEqual("VTSAX", mutualFundStatistics.FundSymbol);
            Assert.AreEqual("S000002848", mutualFundStatistics.SeriesId);
            Assert.AreEqual("C000007806", mutualFundStatistics.ClassId);
            Assert.AreEqual(1915212703487.01m, mutualFundStatistics.TotalAssets);
            Assert.AreEqual(5763123365.99m, mutualFundStatistics.TotalLiabilities);
            Assert.AreEqual(1909449580121.02m, mutualFundStatistics.NetAssets);
            Assert.AreEqual(-0.6729m, mutualFundStatistics.ReturnPrecedingMonth1);
            Assert.AreEqual(6.3455m, mutualFundStatistics.ReturnPrecedingMonth2);
            Assert.AreEqual(5.07574m, mutualFundStatistics.ReturnPrecedingMonth3);
            Assert.AreEqual(983065935.64m, mutualFundStatistics.RealizedGainPrecedingMonth1);
            Assert.AreEqual(-11394591977.19m, mutualFundStatistics.ChangeInUnrealizedAppreciationPrecedingMonth1);
            Assert.AreEqual(287029511.93m, mutualFundStatistics.RealizedGainPrecedingMonth2);
            Assert.AreEqual(105734824564.66m, mutualFundStatistics.ChangeInUnrealizedAppreciationPrecedingMonth2);
            Assert.AreEqual(2243886605.76m, mutualFundStatistics.RealizedGainPrecedingMonth3);
            Assert.AreEqual(87596494350.2m, mutualFundStatistics.ChangeInUnrealizedAppreciationPrecedingMonth3);
            Assert.AreEqual(30533447572.6504m, mutualFundStatistics.ShareSalePrecedingMonth1);
            Assert.AreEqual(9354960674.63m, mutualFundStatistics.ShareRedemptionPrecedingMonth1);
            Assert.AreEqual(9024030148.45996m, mutualFundStatistics.ShareSalePrecedingMonth2);
            Assert.AreEqual(9833704993.95m, mutualFundStatistics.ShareRedemptionPrecedingMonth2);
            Assert.AreEqual(12681244786.0796m, mutualFundStatistics.ShareSalePrecedingMonth3);
            Assert.AreEqual(12999259996.1m, mutualFundStatistics.ShareRedemptionPrecedingMonth3);
        }
    }
}
