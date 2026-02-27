using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

public partial interface IFinancialDataClient
{
    // Supress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    Task<FinancialDataResponse<List<Income>>> GetIncomeStatementsAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<Income>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<CashFlow>>> GetCashFlowStatementsAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<CashFlow>>.StandardSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<InternationalIncome>>> GetInternationalIncomeStatementsAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InternationalIncome>>.PremiumSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<InternationalBalanceSheet>>> GetInternationalBalanceSheetStatementsAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InternationalBalanceSheet>>.PremiumSubscriptionNotImplemented();
    Task<FinancialDataResponse<List<InternationalCashFlow>>> GetInternationalCashFlowStatementsAsync(string identifier, Period period = Period.All, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InternationalCashFlow>>.PremiumSubscriptionNotImplemented();
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// Balance Sheet Statements Endpoint: Asynchronously retrieves the balance sheet statements for the specified entity identifier.
    /// </summary>
    /// <remarks>An <see cref="ArgumentException"/> is thrown if <paramref name="identifier"/> is null or
    /// empty. The operation may be canceled by passing a cancellation token.</remarks>
    /// <param name="identifier">The unique identifier of the entity whose balance sheet statements are to be retrieved. This parameter cannot be
    /// null or empty.</param>
    /// <param name="period">(Optional) The accounting period for which the entity's financial statements are prepared. By default, statements are returned for all accounting periods.</param>
    /// <param name="offset">(Optional) The initial position of the record subset, which indicates how many records to skip. Defaults to 0.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation. The default value is <see
    /// cref="CancellationToken.None"/>.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the balance sheets associated with
    /// the specified identifier.</returns>
    Task<FinancialDataResponse<List<BalanceSheet>>> GetBalanceSheetStatementsAsync(string identifier,
        Period period = Period.All,
        int offset = 0,
        CancellationToken cancellationToken = default) => GetApiResultAsync<List<BalanceSheet>>(
            $"balance-sheet-statements?identifier={identifier}&period={period.ToString().ToLower()}&offset={offset}",
            cancellationToken);

}
