namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents a holding within an ETF, including issuer, security, value, and collateral information.
/// <para>See: https://financialdata.net/documentation#ETF_holdings</para>
/// </summary>
public record EtfHoldings
{
    // TODO: Define properties based on API response or JSON sample
    /// <summary>
    /// Gets or sets the unique central index key for the ETF.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets or sets the name of the registrant (ETF provider).
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets or sets the period of report (end date of the reporting period).
    /// </summary>
    public DateOnly? PeriodOfReport { get; init; }

    /// <summary>
    /// Gets or sets the name of the ETF.
    /// </summary>
    public string? EtfName { get; init; }

    /// <summary>
    /// Gets or sets the symbol of the ETF.
    /// </summary>
    public string? EtfSymbol { get; init; }

    /// <summary>
    /// Gets or sets the series ID of the ETF.
    /// </summary>
    public string? SeriesId { get; init; }

    /// <summary>
    /// Gets or sets the class ID of the ETF.
    /// </summary>
    public string? ClassId { get; init; }

    /// <summary>
    /// Gets or sets the issuer name of the holding.
    /// </summary>
    public string? IssuerName { get; init; }

    /// <summary>
    /// Gets or sets the Legal Entity Identifier (LEI) number of the issuer.
    /// </summary>
    public string? LeiNumber { get; init; }

    /// <summary>
    /// Gets or sets the title of the security.
    /// </summary>
    public string? TitleOfSecurity { get; init; }

    /// <summary>
    /// Gets or sets the trading symbol of the security.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets or sets the CUSIP number of the security.
    /// </summary>
    public string? CusipNumber { get; init; }

    /// <summary>
    /// Gets or sets the ISIN number of the security.
    /// </summary>
    public string? IsinNumber { get; init; }

    /// <summary>
    /// Gets or sets the amount of units held.
    /// </summary>
    public decimal? AmountOfUnits { get; init; }

    /// <summary>
    /// Gets or sets the description of units.
    /// </summary>
    public string? DescriptionOfUnits { get; init; }

    /// <summary>
    /// Gets or sets the denomination currency.
    /// </summary>
    public string? DenominationCurrency { get; init; }

    /// <summary>
    /// Gets or sets the value in USD.
    /// </summary>
    public decimal? ValueInUsd { get; init; }

    /// <summary>
    /// Gets or sets the percentage value compared to assets.
    /// </summary>
    public decimal? PercentageValueComparedToAssets { get; init; }

    /// <summary>
    /// Gets or sets the payoff profile (e.g., Long/Short).
    /// </summary>
    public string? PayoffProfile { get; init; }

    /// <summary>
    /// Gets or sets the asset type.
    /// </summary>
    public string? AssetType { get; init; }

    /// <summary>
    /// Gets or sets the issuer type.
    /// </summary>
    public string? IssuerType { get; init; }

    /// <summary>
    /// Gets or sets the country of issuer or investment.
    /// </summary>
    public string? CountryOfIssuerOrInvestment { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether the security is restricted.
    /// </summary>
    public bool? IsRestrictedSecurity { get; init; }

    /// <summary>
    /// Gets or sets the fair value level.
    /// </summary>
    public int? FairValueLevel { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether this is cash collateral.
    /// </summary>
    public bool? IsCashCollateral { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether this is non-cash collateral.
    /// </summary>
    public bool? IsNonCashCollateral { get; init; }

    /// <summary>
    /// Gets or sets a value indicating whether this is a loan by the fund.
    /// </summary>
    public bool? IsLoanByFund { get; init; }
}
/* ref: https://financialdata.net/documentation#ETF_holdings
{
    "central_index_key": "0000884394",
    "registrant_name": "SPDR S&P 500 ETF TRUST",
    "period_of_report": "2025-06-30",
    "etf_name": "SPDR S&P 500 ETF TRUST",
    "etf_symbol": "SPY",
    "series_id": "N/A",
    "class_id": "N/A",
    "issuer_name": "Johnson & Johnson",
    "lei_number": "549300G0CFPGEF6X2043",
    "title_of_security": "Johnson & Johnson",
    "trading_symbol": "JNJ",
    "cusip_number": "478160104",
    "isin_number": "US4781601046",
    "amount_of_units": 29181009,
    "description_of_units": "NS",
    "denomination_currency": "USD",
    "value_in_usd": 4457399124.75,
    "percentage_value_compared_to_assets": 0.699985772661,
    "payoff_profile": "Long",
    "asset_type": "EC",
    "issuer_type": "CORP",
    "country_of_issuer_or_investment": "US",
    "is_restricted_security": false,
    "fair_value_level": 1,
    "is_cash_collateral": false,
    "is_non_cash_collateral": false,
    "is_loan_by_fund": false
  }
*/