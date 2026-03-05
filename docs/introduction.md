# Introduction

```
using Tudormobile.FinancialData;
```

> [!IMPORTANT]  
> **Pre-release Status**: This SDK is currently in pre-release with **10 out of 80+** FinancialData.Net API endpoints implemented. See [API Coverage](api-coverage.md) for complete status details.

## Overview

**Tudormobile.FinancialData** is a comprehensive C# SDK for accessing the [FinancialData.Net](https://financialdata.net/) API. It provides strongly-typed access to financial market data, company information, and analytical tools through a modern .NET interface.

### 🎯 Current Implementation Status

| Category | Implemented | Total | Status |
|----------|------------|-------|--------|
| Market Data | 4/8 | 50% | ✅ Core functionality ready |
| Financial Statements | 1/6 | 17% | 🚧 Basic balance sheets |
| Symbol Lists | 5/5 | 100% | ✅ Complete coverage |
| Company Information | 0/7 | 0% | 📋 Planned for Phase 3 |  
| Cryptocurrencies | 0/5 | 0% | 💎 Planned for Phase 4 |
| Advanced Analytics | 0/50+ | 0% | 🌟 Future releases |

### 🚀 What's Ready Now

The following features are **fully implemented and production-ready**:

- **📊 Essential Market Data**: Historical stock prices, commodity data, OTC markets
- **🏷️ Symbol Discovery**: Complete symbol lists for stocks, ETFs, and international markets  
- **📄 Basic Financial Data**: Balance sheet statements with period filtering
- **🔧 Flexible Architecture**: Builder pattern, dependency injection, extensible design

## Core Architecture

### IFinancialDataClient Interface

The basic model consists of a client interface to access the FinancialData.Net web service. Use the `IFinancialDataClient` interface to retrieve data from available API endpoints:

```cs
using Tudormobile.FinancialData;
using var httpClient = new HttpClient();

// Replace "your_api_key" with your actual API key for the financial data service.
var client = IFinancialDataClient.Create("your_api_key", httpClient);
```

**HttpClient management** is the responsibility of the host application. This design allows for:
- Connection pooling and reuse
- Custom timeout and retry policies  
- Integration with existing HTTP infrastructure
- Better resource management in server applications

### Response Pattern

All endpoint results are wrapped in a consistent response object that indicates success or failure:

```cs
public class FinancialDataResponse<T>
{
    public bool IsSuccess { get; }
    public T? Data { get; }
    public string? Error { get; }
}
```

This pattern enables:
- **Explicit error handling** - No exceptions for API failures
- **Null safety** - Clear indication when data is unavailable  
- **Consistent interface** - Same pattern across all endpoints

```cs
var stockPrices = await client.GetStockPricesAsync(identifier: "MSFT");
if (stockPrices.IsSuccess)
{
    // Safe to use stockPrices.Data
    var prices = stockPrices.Data;
    Console.WriteLine($"Retrieved {prices?.Count} price records");
}
else
{
    // Handle API errors gracefully
    Console.WriteLine($"Error: {stockPrices.Error}");
}
```

All public methods on the FinancialDataClient are **asynchronous** to support:
- Non-blocking operations in web applications
- Concurrent API requests
- Cancellation support for long-running operations

### Extension Architecture

The `Tudormobile.FinancialData.Extensions` namespace provides building blocks for extensible implementation:

```cs
var client = FinancialDataApi.CreateClientBuilder()
            .WithApiKey("your_api_key")
            .WithHttpClient(new HttpClient())
            .WithSerializer(customSerializer)  // IFinancialDataSerializer
            .AddLogging(customLogger)          // ILogger integration
            .Build();
```

**Extensibility Points:**
- **IFinancialDataSerializer**: Custom JSON serialization
- **ILogger integration**: Comprehensive logging support
- **HttpClient configuration**: Custom policies and handlers  
- **Builder pattern**: Fluent configuration API

### Dependency Injection Support

The SDK integrates seamlessly with .NET's dependency injection container:

```cs
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddFinancialDataClient(options => options.WithApiKey("your_api_key"));
    
using IHost host = builder.Build();
var client = host.Services.GetRequiredService<IFinancialDataClient>();
```

**Benefits of DI Integration:**
- **Automatic lifecycle management** - No manual disposal needed
- **Configuration binding** - API keys from appsettings.json
- **Service composition** - Easy integration with other services  
- **Testing support** - Mock implementations for unit tests

## Implementation Roadmap

### ✅ Phase 1: Foundation (Current)
**Status: Complete**
- Core market data endpoints  
- Symbol discovery functionality
- Basic financial statements
- Extensible architecture foundation

### 🚧 Phase 2: Enhanced Data (In Progress)  
**Target: Q2 2026**
- Complete financial statements (Income, Cash Flow)
- Real-time quotes and minute data
- International market expansion
- Improved error handling and retries

### 📋 Phase 3: Business Intelligence (Planned)
**Target: Q3 2026**  
- Company fundamental data
- Financial ratios and key metrics
- Event calendars (earnings, dividends)
- Industry analysis tools

### 💎 Phase 4: Advanced Analytics (Future)
**Target: Q4 2026**
- Cryptocurrency market data
- Options and derivatives analysis  
- ESG and sustainability metrics
- Institutional trading insights

### 🌟 Phase 5: Complete Platform (Future)
**Target: 2027**
- News and sentiment analysis
- Advanced charting data
- Portfolio analytics
- Custom alert systems

## Sample Applications

Interactive code examples are provided in the `src/samples/` directory: 
Interactive code examples are provided in the `src/samples/` directory:

- **SimpleConsoleApp**
    - A minimal console application using the basic `IFinancialDataClient` interface
    - Demonstrates core API usage patterns
    - Perfect starting point for new developers

- **ExtendedConsoleApp**
    - A comprehensive console application showcasing advanced features
    - Uses Microsoft's dependency injection and logging frameworks
    - Demonstrates builder pattern and configuration options
    - Shows best practices for production applications

## Next Steps

1. **Start Simple**: Follow the [Getting Started Guide](getting-started.md) for basic usage
2. **Explore Coverage**: Review [API Coverage](api-coverage.md) to understand current capabilities  
3. **Detailed Reference**: Check [API Reference](api-reference.md) for complete method documentation
4. **Run Examples**: Study the sample applications in `src/samples/`
5. **Stay Updated**: Watch the [GitHub repository](https://github.com/tudormobile/fdncs) for new releases

---

## Support & Contribution

- **📖 Documentation**: [https://tudormobile.github.io/fdncs/](https://tudormobile.github.io/fdncs/)
- **🐛 Bug Reports**: [GitHub Issues](https://github.com/tudormobile/fdncs/issues)
- **💡 Feature Requests**: [GitHub Discussions](https://github.com/tudormobile/fdncs/discussions)  
- **📦 NuGet Package**: [Tudormobile.FinancialData](https://www.nuget.org/packages/Tudormobile.FinancialData)
