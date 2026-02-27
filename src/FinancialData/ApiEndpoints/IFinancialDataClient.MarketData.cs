using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

public partial interface IFinancialDataClient
{
    // Supress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    // https://financialdata.net/api/v1/stock-quotes?identifiers=MSFT,AAPL&key=
    Task<FinancialDataResponse<List<StockQuote>>> GetStockQuotesAsync(IEnumerable<string> identifiers, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<StockQuote>>.PremiumSubscriptionNotImplemented();

    // https://financialdata.net/api/v1/international-stock-prices?identifier=SHEL.L
    Task<FinancialDataResponse<List<StockQuote>>> GetInternationalStockPricesAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<StockQuote>>.StandardSubscriptionNotImplemented();

    // https://financialdata.net/api/v1/minute-prices?identifier=MSFT&date=2020-01-15&key=
    Task<FinancialDataResponse<List<StockPrice>>> GetMinutePricesAsync(string identifier, DateTimeOffset date, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<StockPrice>>.StandardSubscriptionNotImplemented();

    // https://financialdata.net/api/v1/latest-prices?identifier=MSFT&key=
    Task<FinancialDataResponse<List<StockPrice>>> GetLatestPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<StockPrice>>.PremiumSubscriptionNotImplemented();
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// Stock Prices Endpoint: Asynchronously retrieves historical stock price data for a specified stock identifier (e.g., ticker symbol) over a given time period. The response includes details such as opening price, closing price, high, low, and trading volume for each day within the specified range.
    /// </summary>
    /// <param name="identifier">The stock identifier (e.g., ticker symbol) for which to retrieve historical price data.</param>
    /// <param name="offset">(Optional) The initial position of the record subset, which indicates how many records to skip. Defaults to 0.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of historical stock prices.</returns>
    Task<FinancialDataResponse<List<StockPrice>>> GetStockPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<StockPrice>>($"stock-prices?identifier={identifier}&offset={offset}", cancellationToken);


    /// <summary>
    /// Asynchronously retrieves price data for a specified commodity.
    /// </summary>
    /// <param name="identifier">The unique identifier of the commodity for which to retrieve stock prices. This value cannot be null or empty.</param>
    /// <param name="offset">The number of records to skip before starting to return results. Must be a non-negative integer. Useful for
    /// paginating large result sets.</param>
    /// <param name="cancellationToken">A token that can be used to request cancellation of the asynchronous operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the prices for
    /// the specified commodity.</returns>
    Task<FinancialDataResponse<List<CommodityPrice>>> GetCommodityPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<CommodityPrice>>($"commodity-prices?identifier={identifier}&offset={offset}", cancellationToken);

    /// <summary>
    /// Asynchronously retrieves over-the-counter (OTC) price data for the specified financial instrument.  
    /// </summary>
    /// <param name="identifier">The unique identifier of the financial instrument for which to retrieve OTC prices. This value cannot be null or
    /// empty.</param>
    /// <param name="offset">The number of records to skip before starting to return results. Must be greater than or equal to 0. Defaults to
    /// 0.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a response with the OTC prices for
    /// the specified instrument.</returns>
    Task<FinancialDataResponse<List<OtcPrice>>> GetOtcPricesAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<OtcPrice>>($"otc-prices?identifier={identifier}&offset={offset}", cancellationToken);

    /// <summary>
    /// Asynchronously retrieves over-the-counter (OTC) volume data for the specified identifier.
    /// </summary>
    /// <param name="identifier">The unique identifier for which to retrieve OTC volume data. This parameter cannot be null or empty.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation. The default value is <see
    /// cref="CancellationToken.None"/>.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see
    /// cref="FinancialDataResponse{OtcVolumes}"/> with the OTC volume data for the specified identifier.</returns>
    Task<FinancialDataResponse<List<OtcVolume>>> GetOtcVolumesAsync(string identifier, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<OtcVolume>>($"otc-volume?identifier={identifier}", cancellationToken);

}

