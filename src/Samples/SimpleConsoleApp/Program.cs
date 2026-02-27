using Tudormobile.FinancialData;
namespace SimpleConsoleApp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // Create an instance of HttpClient to be used for making API requests.
        using var httpClient = new HttpClient();

        // Replace "your_api_key" with your actual API key for the financial data service.
        string apiKey = Environment.GetEnvironmentVariable("FINANCIAL_DATA_API_KEY") ?? "your_api_key";
        var client = IFinancialDataClient.Create(apiKey, httpClient);

        // Get Stock Prices for Microsoft (MSFT)
        var stockPrices = client.GetStockPricesAsync(identifier: "MSFT").Result;
        Console.WriteLine(stockPrices.Data?[0]);

        // Get Balance Sheet Statements for Microsoft (MSFT)
        var balanceSheets = client.GetBalanceSheetStatementsAsync(identifier: "MSFT").Result;
        Console.WriteLine(balanceSheets.Data?[0]);

        Console.WriteLine(stockPrices.Error ?? string.Empty);
        Console.WriteLine(balanceSheets.Error ?? string.Empty);
    }
}
