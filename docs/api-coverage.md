# API Coverage & Implementation Status

This document provides a comprehensive overview of the FinancialData.Net API endpoints and their current implementation status in the Tudormobile.FinancialData SDK.

> [!IMPORTANT]  
> **Current Status**: This SDK is in pre-release. Only **10 out of 80+ available API endpoints** are currently implemented.

## Legend
| Status | Description |
|--------|-------------|
| ✅ | **Fully Implemented** - Ready for production use |
| 🚧 | **Planned** - Method signature exists, implementation pending |
| 📋 | **Standard Subscription** - Requires basic FinancialData.Net subscription |
| 💎 | **Premium Subscription** - Requires premium FinancialData.Net subscription |

---

## 📊 Market Data
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetStockPricesAsync` | ✅ | 📋 | Historical stock price data |
| `GetCommodityPricesAsync` | ✅ | 📋 | Commodity price data |
| `GetOtcPricesAsync` | ✅ | 📋 | Over-the-counter price data |
| `GetOtcVolumeAsync` | ✅ | 📋 | OTC volume data |
| `GetStockQuotesAsync` | 🚧 | 💎 | Real-time stock quotes |
| `GetInternationalStockPricesAsync` | 🚧 | 📋 | International stock prices |
| `GetMinutePricesAsync` | 🚧 | 📋 | Minute-by-minute price data |
| `GetLatestPricesAsync` | 🚧 | 💎 | Latest price information |

## 📄 Financial Statements  
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetBalanceSheetStatementsAsync` | ✅ | 📋 | Balance sheet data |
| `GetIncomeStatementsAsync` | 🚧 | 📋 | Income statement data |
| `GetCashFlowStatementsAsync` | 🚧 | 📋 | Cash flow statement data |
| `GetInternationalIncomeStatementsAsync` | 🚧 | 💎 | International income statements |
| `GetInternationalBalanceSheetStatementsAsync` | 🚧 | 💎 | International balance sheets |
| `GetInternationalCashFlowStatementsAsync` | 🚧 | 💎 | International cash flow statements |

## 🏷️ Symbol Lists
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetStockSymbolsAsync` | ✅ | 📋 | List of stock symbols |
| `GetInternationalStockSymbolsAsync` | ✅ | 📋 | International stock symbols |
| `GetEtfSymbolsAsync` | ✅ | 📋 | ETF symbols |
| `GetInternationalEtfSymbolsAsync` | ✅ | 📋 | International ETF symbols |
| `GetMutualFundSymbolsAsync` | ✅ | 📋 | Mutual fund symbols |

## 🏢 Basic Information
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetCompanyInformationAsync` | 🚧 | 📋 | Company profile information |
| `GetInternationalCompanyInformationAsync` | 🚧 | 💎 | International company data |
| `GetKeyMetricsAsync` | 🚧 | 📋 | Key financial metrics |
| `GetMarketCapAsync` | 🚧 | 📋 | Market capitalization data |
| `GetEmployeeCountAsync` | 🚧 | 📋 | Employee count information |
| `GetExecutiveCompensationAsync` | 🚧 | 💎 | Executive compensation data |
| `GetSecuritiesInformationAsync` | 🚧 | 📋 | Securities information |

## 💰 Cryptocurrencies
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetCryptoSymbolsAsync` | 🚧 | 💎 | Cryptocurrency symbols |
| `GetCryptoInformationAsync` | 🚧 | 💎 | Cryptocurrency information |
| `GetCryptoQuotesAsync` | 🚧 | 💎 | Real-time crypto quotes |
| `GetCryptoPricesAsync` | 🚧 | 💎 | Historical crypto prices |
| `GetCryptoMinutePricesAsync` | 🚧 | 💎 | Minute crypto price data |

## 📈 Derivatives Data
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetOptionChainAsync` | 🚧 | 💎 | Options chain data |
| `GetOptionPricesAsync` | 🚧 | 💎 | Options pricing |
| `GetOptionGreeksAsync` | 🚧 | 💎 | Options Greeks calculation |
| `GetFuturesSymbolsAsync` | 🚧 | 💎 | Futures symbols |
| `GetFuturesPricesAsync` | 🚧 | 💎 | Futures pricing data |

## 🌍 ESG Data
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetEsgScoresAsync` | 🚧 | 💎 | ESG scores |
| `GetEsgRatingsAsync` | 🚧 | 💎 | ESG ratings |
| `GetIndustryEsgScoresAsync` | 🚧 | 💎 | Industry ESG benchmarks |

## 📊 ETF Data
| Method | Status | Subscription | Description |
|--------|---------|-------------|-------------|
| `GetEtfQuotesAsync` | 🚧 | 💎 | ETF quote data |

## 📅 Event Calendars
*Coming Soon* - Calendar endpoints for earnings, dividends, economic events

## 🔢 Financial Ratios  
*Coming Soon* - Financial ratio calculations and industry comparisons

## 💱 Forex Data
*Coming Soon* - Foreign exchange rates and currency data

## 👥 Insider Trading
*Coming Soon* - Insider trading activity data

## 🏦 Institutional Trading
*Coming Soon* - Institutional trading patterns

## 💼 Investment Advisers
*Coming Soon* - Investment adviser information

## 🏛️ Market Indexes
*Coming Soon* - Market index data and components

## 📰 Market News
*Coming Soon* - Financial news and sentiment data

## 🔧 Miscellaneous Data
*Coming Soon* - Additional market data endpoints

## 💹 Mutual Funds
*Coming Soon* - Mutual fund performance and holdings data

---

## Implementation Timeline

### ✅ Phase 1: Core Market Data (Completed)
- Basic stock prices and symbol lists
- Essential financial statements
- Foundation for expansion

### 🚧 Phase 2: Enhanced Market Data (In Progress)
- Real-time quotes and minute data
- Complete financial statements suite
- International market coverage

### 📋 Phase 3: Advanced Analytics (Planned)
- Financial ratios and key metrics
- Company fundamental data
- Basic event calendars

### 💎 Phase 4: Premium Features (Future)
- Cryptocurrency data
- Options and derivatives
- ESG and sustainability metrics

### 🌟 Phase 5: Comprehensive Coverage (Future)
- News and sentiment analysis  
- Institutional and insider data
- Complete calendar events

---

## Getting Help

- **Implementation Status**: Check this document for current coverage
- **API Reference**: See [api-reference.md](api-reference.md) for detailed method documentation
- **Examples**: Visit [getting-started.md](getting-started.md) for usage examples
- **Issues**: Report bugs or request features on [GitHub](https://github.com/tudormobile/fdncs/issues)

> [!TIP]
> Methods marked as 🚧 will return `NotImplemented()` responses. Check their return values before processing data.