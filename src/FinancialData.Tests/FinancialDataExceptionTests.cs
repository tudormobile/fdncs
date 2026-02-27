namespace FinancialData.Tests;

[TestClass]
public class FinancialDataExceptionTests
{
    [TestMethod]
    public void FinancialDataException_DefaultConstructorTest()
    {
        // Arrange & Act
        var exception = new FinancialDataException();

        // Assert
        Assert.IsInstanceOfType<FinancialDataException>(exception);
    }

    [TestMethod]
    public void FinancialDataException_ConstructorWithMessage_SetsMessage()
    {
        // Arrange
        var message = "this is an exception message";
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        // Act
        var exception = new FinancialDataException(message);

        // Assert
        Assert.AreEqual(message, exception.Message);
    }

    [TestMethod]
    public void FinancialDataException_ConstructorWithInnerException_SetsInnerException()
    {
        // Arrange
        var inner = new Exception();
        var message = "this is an exception message";

        // Act
        var exception = new FinancialDataException(message, inner);

        // Assert
        Assert.AreEqual(message, exception.Message);
        Assert.AreEqual(inner, exception.InnerException);
    }

}