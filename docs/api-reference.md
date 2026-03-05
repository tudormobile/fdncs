# API Reference

Complete reference for all implemented methods in the Tudormobile.FinancialData SDK.

> [!NOTE]
> This reference covers only the **fully implemented methods**. For complete API coverage status, see [API Coverage](api-coverage.md).

---

## 📊 Market Data Methods

### GetStockPricesAsync

Retrieves historical stock price data for a specified stock identifier.

#### Signature
```cs
Task<FinancialDataResponse<List<StockPrice>>> GetStockPricesAsync(
    string identifier, 
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

#### Parameters
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `identifier` | `string` | ✅ | Stock ticker symbol (e.g., "MSFT", "AAPL") |
| `offset` | `int` | ❌ | Number of records to skip for pagination. Default: 0 |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Returns
`FinancialDataResponse<List<StockPrice>>` - Response containing historical price data

#### StockPrice Properties
```cs
public class StockPrice
{
    public DateTime Date { get; set; }
    public decimal Open { get; set; }
    public decimal High { get; set; }
    public decimal Low { get; set; }
    public decimal Close { get; set; }
    public long Volume { get; set; }
    // Additional properties...
}
```

#### Example
```cs
var prices = await client.GetStockPricesAsync("MSFT");
if (prices.IsSuccess)
{
    var latestPrice = prices.Data.FirstOrDefault();
    Console.WriteLine($"MSFT Latest: ${latestPrice.Close:F2} on {latestPrice.Date:yyyy-MM-dd}");
}
```

### GetCommodityPricesAsync

Retrieves price data for specified commodities.

#### Signature
```cs
Task<FinancialDataResponse<List<CommodityPrice>>> GetCommodityPricesAsync(
    string identifier, 
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

#### Parameters
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `identifier` | `string` | ✅ | Commodity identifier (e.g., "GC=F" for Gold) |
| `offset` | `int` | ❌ | Number of records to skip for pagination. Default: 0 |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Returns
`FinancialDataResponse<List<CommodityPrice>>` - Response containing commodity price data

#### Example  
```cs
var goldPrices = await client.GetCommodityPricesAsync("GC=F");
if (goldPrices.IsSuccess)
{
    foreach (var price in goldPrices.Data.Take(5))
    {
        Console.WriteLine($"Gold: ${price.Close:F2} on {price.Date:yyyy-MM-dd}");
    }
}
```

### GetOtcPricesAsync

Retrieves over-the-counter (OTC) price data for the specified financial instrument.

#### Signature
```cs
Task<FinancialDataResponse<List<OtcPrice>>> GetOtcPricesAsync(
    string identifier, 
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

#### Parameters
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `identifier` | `string` | ✅ | Financial instrument identifier |
| `offset` | `int` | ❌ | Number of records to skip for pagination. Default: 0 |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Returns
`FinancialDataResponse<List<OtcPrice>>` - Response containing OTC price data

#### Example
```cs
var otcPrices = await client.GetOtcPricesAsync("AAPL");
if (otcPrices.IsSuccess)
{
    var latest = otcPrices.Data.FirstOrDefault();
    Console.WriteLine($"OTC Price: ${latest?.Close:F2}");
}
```

### GetOtcVolumeAsync

Retrieves over-the-counter (OTC) volume data for the specified financial instrument.

#### Signature
```cs
Task<FinancialDataResponse<List<OtcVolume>>> GetOtcVolumeAsync(
    string identifier, 
    CancellationToken cancellationToken = default)
```

#### Parameters
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `identifier` | `string` | ✅ | Financial instrument identifier |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Returns
`FinancialDataResponse<List<OtcVolume>>` - Response containing OTC volume data

#### Example
```cs
var otcVolume = await client.GetOtcVolumeAsync("MSFT");
if (otcVolume.IsSuccess)
{
    var latest = otcVolume.Data.FirstOrDefault();
    Console.WriteLine($"OTC Volume: {latest?.Volume:N0}");
}
```

---

## 📄 Financial Statements Methods

### GetBalanceSheetStatementsAsync

Retrieves balance sheet statements for the specified entity identifier.

#### Signature
```cs
Task<FinancialDataResponse<List<BalanceSheet>>> GetBalanceSheetStatementsAsync(
    string identifier, 
    Period period = Period.All, 
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

#### Parameters
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `identifier` | `string` | ✅ | Company ticker symbol |
| `period` | `Period` | ❌ | Reporting period. Default: `Period.All` |
| `offset` | `int` | ❌ | Number of records to skip for pagination. Default: 0 |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Period Enum Values
- `Period.All` - All available periods
- `Period.Annual` - Annual reports only  
- `Period.Quarter` - Quarterly reports only

#### Returns
`FinancialDataResponse<List<BalanceSheet>>` - Response containing balance sheet data

#### BalanceSheet Properties (Key Fields)
```cs
public class BalanceSheet  
{
    public DateTime Date { get; set; }
    public string Period { get; set; }
    public decimal TotalAssets { get; set; }
    public decimal TotalLiabilities { get; set; }
    public decimal ShareholdersEquity { get; set; }
    public decimal CurrentAssets { get; set; }
    public decimal CurrentLiabilities { get; set; }
    // Many additional financial properties...
}
```

#### Example
```cs
// Get all balance sheet periods
var balanceSheets = await client.GetBalanceSheetStatementsAsync("AAPL");
if (balanceSheets.IsSuccess)
{
    var latest = balanceSheets.Data.FirstOrDefault();
    Console.WriteLine($"Total Assets: ${latest?.TotalAssets:N0}");
    Console.WriteLine($"Total Liabilities: ${latest?.TotalLiabilities:N0}");
    Console.WriteLine($"Equity: ${latest?.ShareholdersEquity:N0}");
}

// Get only quarterly reports
var quarterlySheets = await client.GetBalanceSheetStatementsAsync("MSFT", Period.Quarter);
```

---

## 🏷️ Symbol Lists Methods

### GetStockSymbolsAsync

Retrieves a list of available stock symbols.

#### Signature
```cs
Task<FinancialDataResponse<List<Symbol>>> GetStockSymbolsAsync(
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

#### Parameters
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `offset` | `int` | ❌ | Number of records to skip for pagination. Default: 0 |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Returns
`FinancialDataResponse<List<Symbol>>` - Response containing stock symbols

#### Symbol Properties
```cs
public class Symbol
{
    public string Code { get; set; }        // Ticker symbol
    public string Name { get; set; }        // Company name
    public string Country { get; set; }     // Country code
    public string Exchange { get; set; }    // Exchange name
    // Additional properties...
}
```

#### Example
```cs
var symbols = await client.GetStockSymbolsAsync();
if (symbols.IsSuccess)
{
    Console.WriteLine($"Available symbols: {symbols.Data.Count}");
    foreach (var symbol in symbols.Data.Take(10))
    {
        Console.WriteLine($"{symbol.Code} - {symbol.Name} ({symbol.Exchange})");
    }
}
```

### GetInternationalStockSymbolsAsync

Retrieves international stock symbols from global exchanges.

#### Signature
```cs
Task<FinancialDataResponse<List<Symbol>>> GetInternationalStockSymbolsAsync(
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

#### Parameters  
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `offset` | `int` | ❌ | Number of records to skip for pagination. Default: 0 |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Returns
`FinancialDataResponse<List<Symbol>>` - Response containing international symbols

#### Example
```cs
var intlSymbols = await client.GetInternationalStockSymbolsAsync();
if (intlSymbols.IsSuccess)
{
    Console.WriteLine($"International symbols: {intlSymbols.Data.Count}");
    var europeanStocks = intlSymbols.Data
        .Where(s => s.Country == "GB" || s.Country == "DE")
        .Take(5);
        
    foreach (var stock in europeanStocks)
    {
        Console.WriteLine($"{stock.Code} - {stock.Name} ({stock.Country})");
    }
}
```

### GetEtfSymbolsAsync

Retrieves Exchange-Traded Fund (ETF) symbols.

#### Signature
```cs
Task<FinancialDataResponse<List<Symbol>>> GetEtfSymbolsAsync(
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

#### Parameters
| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|  
| `offset` | `int` | ❌ | Number of records to skip for pagination. Default: 0 |
| `cancellationToken` | `CancellationToken` | ❌ | Cancellation token for async operation |

#### Returns
`FinancialDataResponse<List<Symbol>>` - Response containing ETF symbols

#### Example
```cs
var etfSymbols = await client.GetEtfSymbolsAsync();
if (etfSymbols.IsSuccess)
{
    Console.WriteLine($"Available ETFs: {etfSymbols.Data.Count}");
    
    // Filter for popular index ETFs
    var indexEtfs = etfSymbols.Data
        .Where(etf => etf.Name.Contains("S&P") || etf.Name.Contains("Index"))
        .Take(10);
        
    foreach (var etf in indexEtfs)
    {
        Console.WriteLine($"{etf.Code} - {etf.Name}");
    }
}
```

### GetInternationalEtfSymbolsAsync

Retrieves international ETF symbols from global markets.

#### Signature
```cs
Task<FinancialDataResponse<List<Symbol>>> GetInternationalEtfSymbolsAsync(
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

### GetMutualFundSymbolsAsync

Retrieves mutual fund symbols.

#### Signature
```cs
Task<FinancialDataResponse<List<Symbol>>> GetMutualFundSymbolsAsync(
    int offset = 0, 
    CancellationToken cancellationToken = default)
```

---

## 🔄 Common Response Pattern

All API methods return a `FinancialDataResponse<T>` object with the following structure:

```cs
public class FinancialDataResponse<T>
{
    public bool IsSuccess { get; }
    public T? Data { get; }
    public string? Error { get; }
}
```

### Success Response
```cs
var response = await client.GetStockPricesAsync("AAPL");
if (response.IsSuccess)
{
    // response.Data contains List<StockPrice>
    // response.Error is null
}
```

### Error Response  
```cs
var response = await client.GetStockPricesAsync("INVALID");
if (!response.IsSuccess)
{
    // response.Data is null
    // response.Error contains error message
    Console.WriteLine($"API Error: {response.Error}");
}
```

---

## 🚀 Usage Best Practices

### 1. Always Check Response Status
```cs
var result = await client.GetStockPricesAsync("MSFT");
if (result.IsSuccess && result.Data?.Any() == true)
{
    // Safe to process data
}
```

### 2. Handle Pagination Efficiently
```cs
async Task<List<Symbol>> GetAllSymbols()
{
    var allSymbols = new List<Symbol>();
    int offset = 0;
    
    while (true)
    {
        var batch = await client.GetStockSymbolsAsync(offset);
        if (!batch.IsSuccess || batch.Data?.Any() != true)
            break;
            
        allSymbols.AddRange(batch.Data);
        offset += batch.Data.Count;
        
        if (batch.Data.Count < 100) // Assume page size of 100
            break;
    }
    
    return allSymbols;
}
```

### 3. Use Cancellation Tokens
```cs
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var result = await client.GetBalanceSheetStatementsAsync("AAPL", 
    cancellationToken: cts.Token);
```

### 4. Configure HttpClient Appropriately
```cs
var httpClient = new HttpClient()
{
    Timeout = TimeSpan.FromSeconds(60)
};

var client = IFinancialDataClient.Create("your_api_key", httpClient);
```

---

## 📚 See Also

- [Getting Started Guide](getting-started.md) - Basic usage examples  
- [API Coverage](api-coverage.md) - Complete implementation status
- [Introduction](introduction.md) - Architecture overview
- [FinancialData.Net API Docs](https://financialdata.net/documentation) - Official API reference