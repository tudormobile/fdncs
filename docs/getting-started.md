# Getting Started

### Installation
```bash
dotnet add package Tudormobile.FinancialData
```
### Quick Start

#### Basic API:
```cs
using Tudormobile.FinancialData;

// Create an instance of HttpClient to be used for making API requests.
using var httpClient = new HttpClient();

// Replace "your_api_key" with your actual API key for the financial data service.
var client = IFinancialDataClient.Create("your_api_key", httpClient);

// Get Stock Prices for Microsoft (MSFT)
var stockPrices = client.GetStockPricesAsync(identifier: "MSFT").Result;
Console.WriteLine(stockPrices.Data?[0]);
```
> [!TIP]
> See the sample '*SimpleConsoleApp*' located in the *src/samples/* folder.

#### Using the extensions:
```cs
using Tudormobile.FinancialData;
using Tudormobile.FinancialData.Extensions;

// Create an instance of HttpClient to be used for making API requests.
using var httpClient = new HttpClient();

// Replace "your_api_key" with your actual API key for the financial data service.
var client = FinancialDataApi.CreateClientBuilder()
                .WithApiKey("your_api_key")
                .WithHttpClient(httpClient)
                .Build();

// Get Stock Prices for Microsoft (MSFT)
var stockPrices = client.GetStockPricesAsync(identifier: "MSFT").Result;
Console.WriteLine(stockPrices.Data?[0]);
```
#### Using dependency injection:
```cs
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tudormobile.FinancialData;
using Tudormobile.FinancialData.Extensions;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Replace "your_api_key" with your actual API key for the financial data service.
builder.Services
    .AddFinancialDataClient(options => 
        { 
            options.WithApiKey("your-api-key"); 
        })
    .AddLogging(builder => builder.AddConsole());

using IHost host = builder.Build();

var client = host.Services.GetRequiredService<IFinancialDataClient>();
// Get Stock Prices for Microsoft (MSFT)
var stockPrices = client.GetStockPricesAsync(identifier: "MSFT").Result;
Console.WriteLine(stockPrices.Data?[0]);
```
> [!TIP]
> See the sample '*ExtendedConsoleApp*'.