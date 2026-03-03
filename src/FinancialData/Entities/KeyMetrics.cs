namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents key financial metrics for a company such as P/E ratio, P/B ratio, free cash flow, etc.
/// <para>See: https://financialdata.net/documentation#key_metrics</para>
/// </summary>
public record KeyMetrics
{
    /// <summary>
    /// Gets or sets the trading symbol of the company.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the central index key (CIK) assigned by the SEC.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the registrant name of the company.
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the fiscal year.
    /// </summary>
    public string? FiscalYear { get; init; }

    /// <summary>
    /// Gets or sets the period end date.
    /// </summary>
    public DateOnly PeriodEndDate { get; init; }

    /// <summary>
    /// Gets or sets the earnings per share.
    /// </summary>
    public decimal EarningsPerShare { get; init; }

    /// <summary>
    /// Gets or sets the forecasted earnings per share.
    /// </summary>
    public decimal EarningsPerShareForecast { get; init; }

    /// <summary>
    /// Gets or sets the price-to-earnings ratio.
    /// </summary>
    public decimal PriceToEarningsRatio { get; init; }

    /// <summary>
    /// Gets or sets the forward price-to-earnings ratio.
    /// </summary>
    public decimal ForwardPriceToEarningsRatio { get; init; }

    /// <summary>
    /// Gets or sets the earnings growth rate.
    /// </summary>
    public decimal EarningsGrowthRate { get; init; }

    /// <summary>
    /// Gets or sets the price-earnings-to-growth (PEG) ratio.
    /// </summary>
    public decimal PriceEarningsToGrowthRatio { get; init; }

    /// <summary>
    /// Gets or sets the book value per share.
    /// </summary>
    public decimal BookValuePerShare { get; init; }

    /// <summary>
    /// Gets or sets the price-to-book ratio.
    /// </summary>
    public decimal PriceToBookRatio { get; init; }

    /// <summary>
    /// Gets or sets the EBITDA.
    /// </summary>
    public decimal Ebitda { get; init; }

    /// <summary>
    /// Gets or sets the enterprise value.
    /// </summary>
    public decimal EnterpriseValue { get; init; }

    /// <summary>
    /// Gets or sets the dividend yield.
    /// </summary>
    public decimal DividendYield { get; init; }

    /// <summary>
    /// Gets or sets the dividend payout ratio.
    /// </summary>
    public decimal DividendPayoutRatio { get; init; }

    /// <summary>
    /// Gets or sets the debt-to-equity ratio.
    /// </summary>
    public decimal DebtToEquityRatio { get; init; }

    /// <summary>
    /// Gets or sets the capital expenditures.
    /// </summary>
    public decimal CapitalExpenditures { get; init; }

    /// <summary>
    /// Gets or sets the free cash flow.
    /// </summary>
    public decimal FreeCashFlow { get; init; }

    /// <summary>
    /// Gets or sets the return on equity.
    /// </summary>
    public decimal ReturnOnEquity { get; init; }

    /// <summary>
    /// Gets or sets the one-year beta.
    /// </summary>
    public decimal OneYearBeta { get; init; }

    /// <summary>
    /// Gets or sets the three-year beta.
    /// </summary>
    public decimal ThreeYearBeta { get; init; }

    /// <summary>
    /// Gets or sets the five-year beta.
    /// </summary>
    public decimal FiveYearBeta { get; init; }
}
