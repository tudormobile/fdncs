using Tudormobile.FinancialData.Entities;

namespace Tudormobile.FinancialData;

/// <summary>
/// Provides methods for retrieving basic company information from the FinancialData API.
/// </summary>
public partial interface IFinancialDataClient
{
    // Suppress warnings to document unsupported api endpoints.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    // Company Information - Standard Subscription
    Task<FinancialDataResponse<List<CompanyInformation>>> GetCompanyInformationAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<CompanyInformation>>.StandardSubscriptionNotImplemented();

    // International Company Information - Premium Subscription
    Task<FinancialDataResponse<List<InternationalCompanyInformation>>> GetInternationalCompanyInformationAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<InternationalCompanyInformation>>.PremiumSubscriptionNotImplemented();

    // Key Metrics - Standard Subscription
    Task<FinancialDataResponse<List<KeyMetrics>>> GetKeyMetricsAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<KeyMetrics>>.StandardSubscriptionNotImplemented();

    // Market Cap - Standard Subscription
    Task<FinancialDataResponse<List<MarketCap>>> GetMarketCapAsync(string identifier, int offset = 0, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<MarketCap>>.StandardSubscriptionNotImplemented();

    // Employee Count - Standard Subscription
    Task<FinancialDataResponse<List<EmployeeCount>>> GetEmployeeCountAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<EmployeeCount>>.StandardSubscriptionNotImplemented();

    // Executive Compensation - Premium Subscription
    Task<FinancialDataResponse<List<ExecutiveCompensation>>> GetExecutiveCompensationAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<ExecutiveCompensation>>.PremiumSubscriptionNotImplemented();

    // Securities Information - Standard Subscription
    Task<FinancialDataResponse<List<SecuritiesInformation>>> GetSecuritiesInformationAsync(string identifier, CancellationToken cancellationToken = default)
        => FinancialDataResponse<List<SecuritiesInformation>>.StandardSubscriptionNotImplemented();

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}