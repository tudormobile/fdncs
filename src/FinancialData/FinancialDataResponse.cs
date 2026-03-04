namespace Tudormobile.FinancialData;

/// <summary>
/// Represents the response from a financial data API call.
/// </summary>
/// <typeparam name="T">The type of data returned by the API call.</typeparam>
public class FinancialDataResponse<T>
{
    /// <summary>
    /// Gets a value indicating whether the operation completed successfully.
    /// </summary>
    /// <remarks>The property returns <see langword="true"/> if the response contains data; otherwise, it
    /// returns <see langword="false"/>. Use this property to determine whether the operation produced a valid result
    /// before accessing the data.</remarks>
    public bool IsSuccess => Error == null && Data != null;

    /// <summary>
    /// Gets the data associated with the response, or null if no data is available.
    /// </summary>
    public T? Data { get; }

    /// <summary>
    /// Gets the error message associated with the current instance, if any.
    /// </summary>
    /// <remarks>This property returns a string that provides details about the error that occurred. It will
    /// be null if no error has been recorded.</remarks>
    public string? Error { get; }

    /// <summary>
    /// Creates and initializes a new instance of the <see cref="FinancialDataResponse{T}"/> class with the specified data and error message.
    /// </summary>
    /// <param name="data">The data associated with the response, or null if no data is available.</param>
    /// <param name="error">The error message associated with the current instance, if any.</param>
    public FinancialDataResponse(T? data = default, string? error = null)
    {
        Data = data;
        Error = error;
    }

    /// <summary>
    /// Returns a task that represents an asynchronous operation indicating that the premium subscription API is not
    /// implemented.
    /// </summary>
    /// <returns>A task containing a <see cref="FinancialDataResponse{T}"/> object with an error message stating that the premium subscription
    /// API is not implemented.</returns>
    public static Task<FinancialDataResponse<T>> PremiumSubscriptionNotImplemented()
        => Task.FromResult(new FinancialDataResponse<T>(error: "Premium subscription api not implemented."));

    /// <summary>
    /// Returns a task that represents the asynchronous operation of retrieving financial data, indicating that the
    /// standard subscription API is not implemented.    
    /// </summary>
    /// <returns>A task containing a <see cref="FinancialDataResponse{T}"/> object with an error message stating that the standard
    /// subscription API is not implemented.</returns>
    public static Task<FinancialDataResponse<T>> StandardSubscriptionNotImplemented()
        => Task.FromResult(new FinancialDataResponse<T>(error: "Standard subscription api not implemented."));

}
