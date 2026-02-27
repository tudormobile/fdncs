namespace Tudormobile.FinancialData;

/// <summary>
/// Represents errors that occur when an API request fails or returns an unexpected response.
/// </summary>
/// <remarks>Use this exception to handle failures related to API operations, such as invalid responses,
/// connectivity issues, or unexpected status codes. This exception is typically thrown by methods interacting with
/// external APIs to signal that the operation could not be completed successfully.</remarks>
public class FinancialDataException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FinancialDataException"/> class.
    /// </summary>
    public FinancialDataException() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="FinancialDataException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public FinancialDataException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="FinancialDataException"/> class with a specified error message
    /// and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="inner">The exception that is the cause of the current exception, or null if no inner exception is specified.</param>
    public FinancialDataException(string message, Exception inner)
        : base(message, inner) { }
}