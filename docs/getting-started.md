# Getting Started

> [!IMPORTANT]  
> **Pre-release Status**: Only a subset of FinancialData.Net API endpoints are currently implemented. See [API Coverage](api-coverage.md) for complete implementation status.

### Installation
```bash
dotnet add package Tudormobile.FinancialData
```

### Prerequisites
- **.NET 6.0** or later
- **FinancialData.Net API Key** - Get yours at [financialdata.net](https://financialdata.net/)
- **HttpClient** - For making HTTP requests

### Quick Start

#### Basic API Usage:
```cs
using Tudormobile.FinancialData;

// Create an instance of HttpClient to be used for making API requests.
using var httpClient = new HttpClient();

// Replace "your_api_key" with your actual API key for the financial data service.
var client = IFinancialDataClient.Create("your_api_key", httpClient);

// Get Stock Prices for Microsoft (MSFT)
var stockPrices = await client.GetStockPricesAsync(identifier: "MSFT");
if (stockPrices.IsSuccess)
{
    Console.WriteLine($"Latest price: {stockPrices.Data?[0]?.Close}");
}
else
{
    Console.WriteLine($"Error: {stockPrices.Error}");
}
```
> [!TIP]
> See the sample '*SimpleConsoleApp*' located in the *src/samples/* folder.

### ✅ Available Features (Fully Implemented)

#### 📊 Market Data Examples

##### Stock Prices
```cs
// Get historical stock prices with pagination
var stockPrices = await client.GetStockPricesAsync("AAPL", offset: 0);
if (stockPrices.IsSuccess && stockPrices.Data != null)
{
    foreach (var price in stockPrices.Data.Take(5))
    {
        Console.WriteLine($"Date: {price.Date}, Close: ${price.Close:F2}, Volume: {price.Volume:N0}");
    }
}
```

##### Commodity Prices  
```cs
// Get commodity prices (e.g., Gold, Oil, etc.)
var commodityPrices = await client.GetCommodityPricesAsync("GC=F"); // Gold futures
if (commodityPrices.IsSuccess)
{
    var latest = commodityPrices.Data?.FirstOrDefault();
    Console.WriteLine($"Gold Price: ${latest?.Close:F2} on {latest?.Date}");
}
```

##### OTC (Over-The-Counter) Data
```cs  
// Get OTC prices and volume
var otcPrices = await client.GetOtcPricesAsync("AAPL");
var otcVolume = await client.GetOtcVolumeAsync("AAPL");

if (otcPrices.IsSuccess && otcVolume.IsSuccess)
{
    Console.WriteLine($"OTC Price: ${otcPrices.Data?.FirstOrDefault()?.Close:F2}");
    Console.WriteLine($"OTC Volume: {otcVolume.Data?.FirstOrDefault()?.Volume:N0}");
}
```

#### 📄 Financial Statements Examples

##### Balance Sheet Data
```cs
// Get balance sheet statements for a company
var balanceSheets = await client.GetBalanceSheetStatementsAsync("MSFT");
if (balanceSheets.IsSuccess && balanceSheets.Data != null)
{
    var latest = balanceSheets.Data.FirstOrDefault();
    Console.WriteLine($"Total Assets: ${latest?.TotalAssets:N0}");
    Console.WriteLine($"Total Liabilities: ${latest?.TotalLiabilities:N0}");
    Console.WriteLine($"Shareholders Equity: ${latest?.ShareholdersEquity:N0}");
}

// Get balance sheets for specific period (quarterly vs annual)
var quarterlySheets = await client.GetBalanceSheetStatementsAsync("AAPL", Period.Quarter);
```

#### 🏷️ Symbol Lists Examples

##### Stock Symbols
```cs
// Get list of available stock symbols
var stockSymbols = await client.GetStockSymbolsAsync(offset: 0);
if (stockSymbols.IsSuccess)
{
    Console.WriteLine($"Found {stockSymbols.Data?.Count} stock symbols");
    foreach (var symbol in stockSymbols.Data?.Take(10) ?? [])
    {
        Console.WriteLine($"{symbol.Code} - {symbol.Name}");
    }
}
```

##### International and ETF Symbols
```cs
// Get international stock symbols
var intlSymbols = await client.GetInternationalStockSymbolsAsync();

// Get ETF symbols  
var etfSymbols = await client.GetEtfSymbolsAsync();

Console.WriteLine($"International symbols: {intlSymbols.Data?.Count}");
Console.WriteLine($"ETF symbols: {etfSymbols.Data?.Count}");
```

### 🔧 Advanced Usage Patterns

#### Using the Builder Pattern:
```cs
using Tudormobile.FinancialData;
using Tudormobile.FinancialData.Extensions;

// Create client using the builder pattern for more flexibility
var client = FinancialDataApi.CreateClientBuilder()
                .WithApiKey("your_api_key")  
                .WithHttpClient(new HttpClient())
                .Build();

// Use the client same as before
var stockPrices = await client.GetStockPricesAsync(identifier: "MSFT");
Console.WriteLine(stockPrices.Data?[0]);
```

#### Using Dependency Injection:
```cs
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tudormobile.FinancialData;
using Tudormobile.FinancialData.Extensions;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Register FinancialData client with dependency injection
builder.Services
    .AddFinancialDataClient(options => 
        { 
            options.WithApiKey("your-api-key"); 
        })
    .AddLogging(builder => builder.AddConsole());

using IHost host = builder.Build();

// Resolve client from DI container
var client = host.Services.GetRequiredService<IFinancialDataClient>();
var stockPrices = await client.GetStockPricesAsync(identifier: "MSFT");
Console.WriteLine(stockPrices.Data?[0]);
```
> [!TIP]
> See the sample '*ExtendedConsoleApp*' for a complete dependency injection example.

### 🚨 Error Handling Best Practices

The SDK wraps all responses in a `FinancialDataResponse<T>` object that indicates success or failure:

```cs
var result = await client.GetStockPricesAsync("INVALID_SYMBOL");

if (result.IsSuccess)
{
    // Process the data
    Console.WriteLine($"Retrieved {result.Data?.Count} price records");
}
else
{
    // Handle errors gracefully  
    Console.WriteLine($"API Error: {result.Error}");
    // Log error, show user message, etc.
}
```

#### Unimplemented Method Detection
Methods not yet implemented will return a specific error:

```cs
var cryptoPrices = await client.GetCryptoPricesAsync("BTC");
if (!cryptoPrices.IsSuccess)
{
    if (cryptoPrices.Error?.Contains("not implemented") == true)
    {
        Console.WriteLine("This feature is coming in a future release!");
        // Redirect user to implemented alternatives
    }
}
```

### 📄 Pagination Support

Many endpoints support pagination using the `offset` parameter:

```cs
// Get data in chunks of 100 records
int offset = 0;
const int pageSize = 100;
var allSymbols = new List<Symbol>();

do
{
    var symbols = await client.GetStockSymbolsAsync(offset);
    if (!symbols.IsSuccess || symbols.Data == null) break;
    
    allSymbols.AddRange(symbols.Data);
    offset += pageSize;
    
    Console.WriteLine($"Retrieved {allSymbols.Count} symbols so far...");
    
} while (symbols.Data?.Count == pageSize); // Continue while getting full pages

Console.WriteLine($"Total symbols retrieved: {allSymbols.Count}");
```

### 📊 Subscription Tiers

Different API endpoints require different FinancialData.Net subscription levels:

- **📋 Standard Subscription**: Stock prices, basic financial statements, symbol lists
- **💎 Premium Subscription**: Real-time quotes, cryptocurrency data, advanced analytics

See the [API Coverage](api-coverage.md) document for complete subscription tier information.

### 🔗 Next Steps

- **Explore Implementation Status**: Review [api-coverage.md](api-coverage.md) to see what's available
- **API Reference**: Check [api-reference.md](api-reference.md) for detailed method documentation  
- **Sample Applications**: Study the complete examples in `src/samples/`
- **Architecture**: Learn more in [introduction.md](introduction.md)

### 📚 Additional Resources

- [FinancialData.Net API Documentation](https://financialdata.net/documentation)
- [GitHub Repository](https://github.com/tudormobile/fdncs)
- [NuGet Package](https://www.nuget.org/packages/Tudormobile.FinancialData)