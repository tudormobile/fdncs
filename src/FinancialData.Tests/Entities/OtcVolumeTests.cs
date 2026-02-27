using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.Entities;

[TestClass]
public class OtcVolumeTests
{
    [TestMethod]
    public void OtcVolume_Initialization_Works()
    {
        var volume = new OtcVolume
        {
            TradingSymbol = "AABB",
            TitleOfSecurity = "Asia Broadband Inc Common Stock",
            MonthStartDate = new DateOnly(2024, 10, 1),
            MonthlyVolume = 140366022,
            PreviousMonthlyVolume = 263720143,
            VolumeYearToDate = 2237440816
        };
        Assert.AreEqual("AABB", volume.TradingSymbol);
        Assert.AreEqual("Asia Broadband Inc Common Stock", volume.TitleOfSecurity);
        Assert.AreEqual(new DateOnly(2024, 10, 1), volume.MonthStartDate);
        Assert.AreEqual(140366022, volume.MonthlyVolume);
        Assert.AreEqual(263720143, volume.PreviousMonthlyVolume);
        Assert.AreEqual(2237440816, volume.VolumeYearToDate);
    }

    [TestMethod]
    public void OtcVolume_Deserialize_FromJson_Works()
    {
        var json = "{\n    \"trading_symbol\": \"AABB\",\n    \"title_of_security\": \"Asia Broadband Inc Common Stock\",\n    \"month_start_date\": \"2024-10-01\",\n    \"monthly_volume\": 140366022,\n    \"previous_monthly_volume\": 263720143,\n    \"volume_year_to_date\": 2237440816\n}";
        using var doc = JsonDocument.Parse(json);
        var volume = FinancialDataSerializer.Instance.Deserialize<OtcVolume>(doc);
        Assert.AreEqual("AABB", volume.TradingSymbol);
        Assert.AreEqual("Asia Broadband Inc Common Stock", volume.TitleOfSecurity);
        Assert.AreEqual(new DateOnly(2024, 10, 1), volume.MonthStartDate);
        Assert.AreEqual(140366022, volume.MonthlyVolume);
        Assert.AreEqual(263720143, volume.PreviousMonthlyVolume);
        Assert.AreEqual(2237440816, volume.VolumeYearToDate);
    }
}
