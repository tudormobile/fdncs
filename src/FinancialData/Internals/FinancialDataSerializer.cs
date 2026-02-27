using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

internal class FinancialDataSerializer : IFinancialDataSerializer
{
    internal static readonly IFinancialDataSerializer Instance = new FinancialDataSerializer();

    private readonly JsonSerializerOptions _options;

    public FinancialDataSerializer()
    {
        _options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase),
                new DecimalNullToZeroConverter(),
                new CustomDateTimeConverter()
            }
        };
    }

    public T Deserialize<T>(JsonDocument doc) => doc.Deserialize<T>(_options) ?? throw new JsonException("Failed to deserialize JSON document.");

    public string Serialize(BalanceSheet balanceSheet) => JsonSerializer.Serialize(balanceSheet, _options);
    public string Serialize(StockPrice stockPrice) => JsonSerializer.Serialize(stockPrice, _options);

    internal class DecimalNullToZeroConverter : JsonConverter<decimal>
    {
        // This is crucial: without it, null JSON tokens won't be passed to the converter
        public override bool HandleNull => true;

        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return 0m; // Return default value (0) for null
            }
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDecimal();
            }
            // Handle cases where the value might be a string "null" or an empty string, if necessary
            if (reader.TokenType == JsonTokenType.String && string.IsNullOrEmpty(reader.GetString()))
            {
                return 0m;
            }

            throw new JsonException($"Cannot convert {reader.TokenType} to Decimal");
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }

    internal class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        private const string Format = "yyyy-MM-dd HH:mm:ss";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var dateTimeString = reader.GetString();
            if (DateTime.TryParseExact(dateTimeString, Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                return result;
            }
            throw new JsonException($"Cannot parse DateTime from string: {dateTimeString}");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
        }
    }
}
