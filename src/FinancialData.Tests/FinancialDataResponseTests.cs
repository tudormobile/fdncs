namespace FinancialData.Tests;

[TestClass]
public class FinancialDataResponseTests
{
    [TestMethod]
    public void FinancialDataResponse_ConstructorValueType_ShouldIndicateSuccessAndDefaultData()
    {
        // Arrange
        var apiResponse = new FinancialDataResponse<int>();
        // Assert
        Assert.IsTrue(apiResponse.IsSuccess);
        Assert.AreEqual(default, apiResponse.Data);
        Assert.IsNull(apiResponse.Error);
    }

    [TestMethod]
    public void FinancialDataResponse_ConstructorNullableType_ShouldIndicateNoSuccessAndDefaultData()
    {
        // Arrange
        var apiResponse = new FinancialDataResponse<string>();
        // Assert
        Assert.IsFalse(apiResponse.IsSuccess);
        Assert.AreEqual(default, apiResponse.Data);
        Assert.IsNull(apiResponse.Error);
    }

    [TestMethod]
    public void FinancialDataResponse_SuccessfulResponse_ShouldHaveDataAndNoError()
    {
        // Arrange
        var expectedData = new { Price = 123.45m };
        var apiResponse = new FinancialDataResponse<object>(expectedData);

        // Act
        var actualData = apiResponse.Data;
        var actualError = apiResponse.Error;
        var actualIsSuccess = apiResponse.IsSuccess;

        // Assert
        Assert.IsNotNull(actualData);
        Assert.AreEqual(expectedData, actualData);
        Assert.IsNull(actualError);
        Assert.IsNull(apiResponse.Error);
        Assert.IsTrue(actualIsSuccess);
    }

    [TestMethod]
    public void FinancialDataResponse_ErrorResponse_ShouldHaveErrorAndNoData()
    {
        // Arrange
        var expectedError = "An error occurred.";
        var apiResponse = new FinancialDataResponse<object>(error: expectedError);

        // Act
        var actualData = apiResponse.Data;
        var actualError = apiResponse.Error;
        var actualIsSuccess = apiResponse.IsSuccess;

        // Assert
        Assert.IsNull(actualData);
        Assert.IsNotNull(actualError);
        Assert.AreEqual(expectedError, actualError);
        Assert.IsFalse(actualIsSuccess);
    }

    [TestMethod]
    public void FinancialDataResponse_WithDataAndError_ShouldIndicateNoSuccess()
    {
        // Arrange
        var data = "some data";
        var error = "some error";
        var apiResponse = new FinancialDataResponse<string>(data, error);

        // Act & Assert
        Assert.AreEqual(data, apiResponse.Data);
        Assert.AreEqual(error, apiResponse.Error);
        Assert.IsFalse(apiResponse.IsSuccess);
    }

    [TestMethod]
    public void FinancialDataResponse_WithNullData_ShouldIndicateNoSuccess()
    {
        // Arrange
        var apiResponse = new FinancialDataResponse<string>(data: null);

        // Act & Assert
        Assert.IsNull(apiResponse.Data);
        Assert.IsNull(apiResponse.Error);
        Assert.IsFalse(apiResponse.IsSuccess);
    }

    [TestMethod]
    public void FinancialDataResponse_WithEmptyString_ShouldIndicateSuccess()
    {
        // Arrange
        var apiResponse = new FinancialDataResponse<string>(data: string.Empty);

        // Act & Assert
        Assert.IsNotNull(apiResponse.Data);
        Assert.AreEqual(string.Empty, apiResponse.Data);
        Assert.IsNull(apiResponse.Error);
        Assert.IsTrue(apiResponse.IsSuccess);
    }

    [TestMethod]
    public async Task PremiumSubscriptionNotImplemented_ReturnsErrorResponse()
    {
        // Act
        var response = await FinancialDataResponse<object>.PremiumSubscriptionNotImplemented();

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Premium subscription api not implemented.", response.Error);
    }

    [TestMethod]
    public async Task StandardSubscriptionNotImplemented_ReturnsErrorResponse()
    {
        // Act
        var response = await FinancialDataResponse<object>.StandardSubscriptionNotImplemented();

        // Assert
        Assert.IsFalse(response.IsSuccess);
        Assert.IsNull(response.Data);
        Assert.IsNotNull(response.Error);
        Assert.AreEqual("Standard subscription api not implemented.", response.Error);
    }
}
