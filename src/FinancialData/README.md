# Tudormobile Financial Data API
**Tudormobile.FinancialData** provides a C# SDK for [FinancialData.Net](https://financialdata.net/) API

[Source Code](https://github.com/tudormobile/fdncs) | [Documentation](https://tudormobile.github.io/fdncs/) | [API documentation](https://tudormobile.github.io/fdncs/api/Tudormobile.html)
## Getting Started
### Install the package
```bash
dotnet add package Tudormobile.FinancialData
```
### Prerequisites
**NONE**

### Dependencies
Microsoft.Extensions.Logging
Microsoft.Extensions.Http

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

**Tudormobile.FinancialData** is released as open source under the MIT license. Bug reports and contributions can be made at [the GitHub repository](https://github.com/tudormobile/fdncs).