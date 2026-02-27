using System.Text.Json;
using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Defines methods for serializing and deserializing financial data objects, such as balance sheets and stock prices.
/// </summary>
/// <remarks>Implementations of this interface should provide the logic for converting financial data to a string
/// format and vice versa. The Serialize methods convert specific financial data types into a JSON string, while the
/// Deserialize method reconstructs an object of type T from a JSON document.</remarks>
public interface IFinancialDataSerializer
{
    /// <summary>
    /// Serializes the specified BalanceSheet object to its JSON string representation.
    /// </summary>
    /// <remarks>Use this method to convert a StockPrice instance into a format suitable for storage or
    /// transmission. Ensure that the StockPrice object is fully populated before serialization.</remarks>
    /// <param name="balanceSheet">The BalanceSheet object to serialize. This parameter must not be null.</param>
    /// <returns>A JSON string that represents the serialized StockPrice object.</returns>
    public string Serialize(BalanceSheet balanceSheet);

    /// <summary>
    /// Serializes the specified StockPrice object to its JSON string representation.
    /// </summary>
    /// <remarks>Use this method to convert a StockPrice instance into a format suitable for storage or
    /// transmission. Ensure that the StockPrice object is fully populated before serialization.</remarks>
    /// <param name="stockPrice">The StockPrice object to serialize. This parameter must not be null.</param>
    /// <returns>A JSON string that represents the serialized StockPrice object.</returns>
    public string Serialize(StockPrice stockPrice);

    /// <summary>
    /// Deserializes the specified JSON document to an object of the specified type.
    /// </summary>
    /// <remarks>The structure of the JSON document must match the properties of the target type T for
    /// successful deserialization. If the document does not conform to the expected structure, an exception may be
    /// thrown.</remarks>
    /// <typeparam name="T">The type of the object to create from the JSON document.</typeparam>
    /// <param name="doc">The JSON document to deserialize, represented as a JsonDocument instance.</param>
    /// <returns>An object of type T that represents the data contained in the JSON document.</returns>
    public T Deserialize<T>(JsonDocument doc);

}
