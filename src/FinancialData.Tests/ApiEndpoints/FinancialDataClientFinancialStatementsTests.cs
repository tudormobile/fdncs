using Tudormobile.FinancialData.Entities;

namespace FinancialData.Tests.ApiEndpoints;

[TestClass]
public class FinancialDataClientFinancialStatementsTests
{
    private IFinancialDataClient _client = null!;

    public TestContext TestContext { get; set; } // MSTest will set this property


    [TestInitialize]
    public void Setup()
    {
        _client = CreateTestClient();
    }

    [TestMethod]
    public async Task FinancialDataClient_GetBalanceSheetStatements_ReturnsApiResult()
    {
        // Arrange
        var json = @"[{
    ""trading_symbol"": ""MSFT"",
    ""central_index_key"": ""0000789019"",
    ""registrant_name"": ""MICROSOFT CORP"",
    ""fiscal_year"": ""2024"",
    ""fiscal_period"": ""FY"",
    ""period_end_date"": ""2024-06-30"",
    ""cash_and_cash_equivalents"": 90143000000.0,
    ""marketable_securities_current"": 57228000000.0,
    ""accounts_receivable"": 56924000000.0,
    ""inventories"": 1246000000.0,
    ""non_trade_receivables"": null,
    ""other_assets_current"": 26021000000.0,
    ""total_assets_current"": 159734000000.0,
    ""marketable_securities_non_current"": 14600000000.0,
    ""property_plant_and_equipment"": 135591000000.0,
    ""other_assets_non_current"": 36460000000.0,
    ""total_assets_non_current"": 301369000000.0,
    ""total_assets"": 512163000000.0,
    ""accounts_payable"": 21996000000.0,
    ""deferred_revenue"": 57582000000.0,
    ""short_term_debt"": 2249000000.0,
    ""other_liabilities_current"": 19185000000.0,
    ""total_liabilities_current"": 125286000000.0,
    ""long_term_debt"": 44937000000.0,
    ""other_liabilities_non_current"": 27064000000.0,
    ""total_liabilities_non_current"": 118400000000.0,
    ""total_liabilities"": 243686000000.0,
    ""common_stock"": 100923000000.0,
    ""retained_earnings"": 173144000000.0,
    ""accumulated_other_comprehensive_income"": -5590000000.0,
    ""total_shareholders_equity"": 268477000000.0
}]";
        var apiKey = "some-api-key";
        using var mockHandler = new MockHttpMessageHandler() { JsonResponse = json };
        using var httpClient = new HttpClient(mockHandler);
        var client = IFinancialDataClient.Create(apiKey, httpClient);
        var identifier = "MSFT";

        // Act
        var response = await client.GetBalanceSheetStatementsAsync(identifier, cancellationToken: TestContext.CancellationToken);

        // Assert
        Assert.IsTrue(response.IsSuccess);
        Assert.IsNotNull(response.Data);
        Assert.HasCount(1, response.Data);
        Assert.AreEqual(identifier, response.Data[0].TradingSymbol);
    }

    #region Standard Subscription Endpoints

    [TestMethod]
    [DataRow("AAPL", Period.All, 0)]
    [DataRow("MSFT", Period.Year, 10)]
    [DataRow("GOOGL", Period.Quarter, 5)]
    public async Task GetIncomeStatementsAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetIncomeStatementsAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("TSLA", Period.All, 0)]
    [DataRow("NVDA", Period.Year, 15)]
    public async Task GetCashFlowStatementsAsync_ReturnsStandardSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetCashFlowStatementsAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }

    #endregion

    #region Premium Subscription Endpoints

    [TestMethod]
    [DataRow("SHEL.L", Period.All, 0)]
    [DataRow("BP.L", Period.Year, 10)]
    public async Task GetInternationalIncomeStatementsAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetInternationalIncomeStatementsAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("NESN.SW", Period.All, 0)]
    [DataRow("VOW.DE", Period.Quarter, 5)]
    public async Task GetInternationalBalanceSheetStatementsAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetInternationalBalanceSheetStatementsAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    [DataRow("SAP.DE", Period.All, 0)]
    [DataRow("TM", Period.Year, 20)]
    public async Task GetInternationalCashFlowStatementsAsync_ReturnsPremiumSubscriptionNotImplemented(string identifier, Period period, int offset)
    {
        // Act
        var response = await _client.GetInternationalCashFlowStatementsAsync(identifier, period, offset);

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    #endregion

    #region Helper Methods

    private static IFinancialDataClient CreateTestClient()
    {
        using var mockHandler = new MockHttpMessageHandler();
        var httpClient = new HttpClient(mockHandler);
        return IFinancialDataClient.Create("test-api-key", httpClient);
    }

    #endregion
}
