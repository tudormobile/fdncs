---
_layout: landing
---

# Tudormobile.FinancialData

***Tudormobile.FinancialData*** provides a C# SDK for accessing the FinancialData.Net API.

> [!IMPORTANT]  
> **Pre-release Status**: This SDK currently implements **10 out of 80+** available FinancialData.Net API endpoints. See [API Coverage](api-coverage.md) for complete implementation status.

## 📚 Documentation

- **[Introduction](introduction.md)** - Architecture overview and roadmap  
- **[Getting Started](getting-started.md)** - Installation, examples, and best practices
- **[API Coverage](api-coverage.md)** - Complete implementation status by endpoint
- **[API Reference](api-reference.md)** - Detailed method documentation for implemented features
- **[Generated API Docs](api/Tudormobile.md)** - Auto-generated technical reference  

## 🚀 Quick Start

```cs
using Tudormobile.FinancialData;

using var httpClient = new HttpClient();
var client = IFinancialDataClient.Create("your_api_key", httpClient);

var stockPrices = await client.GetStockPricesAsync("MSFT");
if (stockPrices.IsSuccess)
{
    Console.WriteLine($"MSFT Price: ${stockPrices.Data?[0]?.Close:F2}");
}
```

## 🔧 Build Documentation

[Building the documentation](README.md) locally using DocFX.    

---

**Links:** [`Source Code`](https://github.com/tudormobile/fdncs) | [`NuGet Package`](https://www.nuget.org/packages/Tudormobile.FinancialData) | [`FinancialData.Net API`](https://financialdata.net/)  

