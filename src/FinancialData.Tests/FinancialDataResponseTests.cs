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
}
