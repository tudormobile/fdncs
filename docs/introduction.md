# Introduction

```
using Tudormobile.FinancialData;
```

## Tudormobile.FinancialData
This namespace contains the basic building blocks for accessing the FinancialData.Net API.

The basic model consists of a client to access the FinancialData.Net web service. Use the *IFinancialDataClient* interface to retrieve data from the available API endpoints.
```cs
using Tudormobile.FinancialData;
using var httpClient = new HttpClient();

// Replace "your_api_key" with your actual API key for the financial data service.
var client = FinancialDataClientApi.CreateClient("your_api_key", httpClient);
```
HttpClient management is the responsibility of the host application. All endpoint results are wrapped in a response object that indicates the success or failure of the operation, providing access to the data and/or error message.
```cs
public class FinancialDataResponse<T>
{
    public bool IsSuccess { get; };
    public T? Data { get; }
    public string? Error { get; }
}
```
All public methods on the FinancialDataClient are asynchronous.
```cs
var stockPrices = await client.GetStockPricesAsync(identifier: "MSFT");
if (stockPrices.IsSuccess)
{
    StockPrices prices = stockPrices.Data;
    // ...
}
```
### Tudormobile.FinancialData.Extensions
The extensibility model provides the building blocks for an extensible implementation, including interfaces for the *IFinancialDataClient*, *HttpClient*, Json serialization (*IFinancialDataSerializer*), loggers, a builder pattern, and additional methods that extend the library.   
```cs
var client = FinancialDataApi.GetClientBuilder()
            .WithApiKey("your_api_key")
            .WithHttpClient(new HttpClient())
            .WithSerializer(customSerializer)
            .AddLogging(customLogger)
            .Build();
```

### Dependency Injection
The FinancialData library takes advantage of the dotnet dependency injection model, extending the IServiceCollection to provide an implementation of IFinancialDataClient that can be added to the collection using *AddFinancialDataClient()* extension method.
```cs
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services
    .AddFinancialDataClient(options => options.WithApiKey("your_api_key"));
```
The dependency injection container (host) can resolve HttpClient, Loggers, and any custom serializers to support extensibility options of the core library and to facilitate osting in a variety of environments (desktop, console, web, etc.).

### Sample Code
Some simple code samples are provided in the *src/samples/* folder. 
- SimpleConsoleApp
    - A console application using the simple FinancialDataClient (no extensions).
- ExtendedConsoleApp
    - A console application using the entity object model provided by the library as well as Microsoft's dependency injection, logging, and application host extensions.
