using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving various symbol lists from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    /// <summary>
    /// Retrieves a list of stock symbols.
    /// </summary>
    /// <param name="offset">The offset for pagination. Defaults to 0.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="FinancialDataResponse{T}"/> containing a list of stock symbols.
    /// </returns>
    /// <remarks>
    /// See: https://financialdata.net/documentation#operation/getStockSymbols
    /// </remarks>
    Task<FinancialDataResponse<List<Symbol>>> GetStockSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<Symbol>>($"stock_symbols?offset={offset}", cancellationToken);

    /// <summary>
    /// Retrieves a list of international stock symbols.
    /// </summary>
    /// <param name="offset">The offset for pagination. Defaults to 0.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="FinancialDataResponse{T}"/> containing a list of international stock symbols.
    /// </returns>
    /// <remarks>
    /// See: https://financialdata.net/documentation#operation/getInternationalStockSymbols
    /// </remarks>
    Task<FinancialDataResponse<List<Symbol>>> GetInternationalStockSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<Symbol>>($"international-stock-symbols?offset={offset}", cancellationToken);

    /// <summary>
    /// Retrieves a list of ETF symbols.
    /// </summary>
    /// <param name="offset">The offset for pagination. Defaults to 0.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="FinancialDataResponse{T}"/> containing a list of ETF symbols.
    /// </returns>
    /// <remarks>
    /// See: https://financialdata.net/documentation#operation/getEtfSymbols
    /// </remarks>
    Task<FinancialDataResponse<List<Symbol>>> GetEtfSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<Symbol>>($"etf-symbols?offset={offset}", cancellationToken);

    /// <summary>
    /// Retrieves a list of commodity symbols.
    /// </summary>
    /// <param name="offset">The offset for pagination. Defaults to 0.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="FinancialDataResponse{T}"/> containing a list of commodity symbols.
    /// </returns>
    /// <remarks>
    /// See: https://financialdata.net/documentation#operation/getCommoditySymbols
    /// </remarks>
    Task<FinancialDataResponse<List<Symbol>>> GetCommoditySymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<Symbol>>($"international-stock-symbols?offset={offset}", cancellationToken);

    /// <summary>
    /// Retrieves a list of OTC symbols.
    /// </summary>
    /// <param name="offset">The offset for pagination. Defaults to 0.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>
    /// A <see cref="FinancialDataResponse{T}"/> containing a list of OTC symbols.
    /// </returns>
    /// <remarks>
    /// See: https://financialdata.net/documentation#operation/getOtcSymbols
    /// </remarks>
    Task<FinancialDataResponse<List<Symbol>>> GetOtcSymbolsAsync(int offset = 0, CancellationToken cancellationToken = default)
        => GetApiResultAsync<List<Symbol>>($"international-stock-symbols?offset={offset}", cancellationToken);
}
