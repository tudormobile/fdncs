namespace Tudormobile.FinancialData.Entities;

/// <summary>
/// Represents the holdings of a mutual fund, including details such as fund identifiers, issuer information, 
/// and asset characteristics.
/// </summary>
public record MutualFundHoldings
{
    /// <summary>
    /// Gets the unique central index key for the mutual fund.
    /// </summary>
    public string? CentralIndexKey { get; init; }

    /// <summary>
    /// Gets the name of the registrant (fund family or provider).
    /// </summary>
    public string? RegistrantName { get; init; }

    /// <summary>
    /// Gets the period of report (end date of the reporting period).
    /// </summary>
    public DateOnly? PeriodOfReport { get; init; }

    /// <summary>
    /// Gets the name of the mutual fund.
    /// </summary>
    public string? FundName { get; init; }

    /// <summary>
    /// Gets the symbol of the mutual fund.
    /// </summary>
    public string? FundSymbol { get; init; }

    /// <summary>
    /// Gets the series ID of the mutual fund.
    /// </summary>
    public string? SeriesId { get; init; }

    /// <summary>
    /// Gets the class ID of the mutual fund.
    /// </summary>
    public string? ClassId { get; init; }

    /// <summary>
    /// Gets the issuer name of the holding.
    /// </summary>
    public string? IssuerName { get; init; }

    /// <summary>
    /// Gets the Legal Entity Identifier (LEI) number of the issuer.
    /// </summary>
    public string? LeiNumber { get; init; }

    /// <summary>
    /// Gets the title of the security.
    /// </summary>
    public string? TitleOfSecurity { get; init; }

    /// <summary>
    /// Gets the trading symbol of the security.
    /// </summary>
    public string? TradingSymbol { get; init; }

    /// <summary>
    /// Gets the CUSIP number of the security.
    /// </summary>
    public string? CusipNumber { get; init; }

    /// <summary>
    /// Gets the ISIN number of the security.
    /// </summary>
    public string? IsinNumber { get; init; }

    /// <summary>
    /// Gets the amount of units held.
    /// </summary>
    public decimal AmountOfUnits { get; init; }

    /// <summary>
    /// Gets the description of units.
    /// </summary>
    public string? DescriptionOfUnits { get; init; }

    /// <summary>
    /// Gets the denomination currency.
    /// </summary>
    public string? DenominationCurrency { get; init; }

    /// <summary>
    /// Gets the value in USD.
    /// </summary>
    public decimal ValueInUsd { get; init; }

    /// <summary>
    /// Gets the percentage value compared to assets.
    /// </summary>
    public decimal PercentageValueComparedToAssets { get; init; }

    /// <summary>
    /// Gets the payoff profile (e.g., Long/Short).
    /// </summary>
    public string? PayoffProfile { get; init; }

    /// <summary>
    /// Gets the asset type.
    /// </summary>
    public string? AssetType { get; init; }

    /// <summary>
    /// Gets the issuer type.
    /// </summary>
    public string? IssuerType { get; init; }

    /// <summary>
    /// Gets the country of issuer or investment.
    /// </summary>
    public string? CountryOfIssuerOrInvestment { get; init; }

    /// <summary>
    /// Gets a value indicating whether the security is restricted.
    /// </summary>
    public bool? IsRestrictedSecurity { get; init; }

    /// <summary>
    /// Gets the fair value level.
    /// </summary>
    public int? FairValueLevel { get; init; }

    /// <summary>
    /// Gets a value indicating whether this is cash collateral.
    /// </summary>
    public bool? IsCashCollateral { get; init; }

    /// <summary>
    /// Gets a value indicating whether this is non-cash collateral.
    /// </summary>
    public bool? IsNonCashCollateral { get; init; }

    /// <summary>
    /// Gets a value indicating whether this is a loan by the fund.
    /// </summary>
    public bool? IsLoanByFund { get; init; }
}
/* ref: https://financialdata.net/documentation#mutual_fund_holdings
{
    "central_index_key": "0000036405",
    "registrant_name": "VANGUARD INDEX FUNDS",
    "period_of_report": "2025-06-30",
    "fund_name": "Admiral Shares",
    "fund_symbol": "VTSAX",
    "series_id": "S000002848",
    "class_id": "C000007806",
    "issuer_name": "Frequency Electronics Inc",
    "lei_number": "549300S56SO2JB5JBE31",
    "title_of_security": "FREQUENCY ELECT",
    "trading_symbol": "FEIM",
    "cusip_number": "358010106",
    "isin_number": "US3580101067",
    "amount_of_units": 228179,
    "description_of_units": "NS",
    "denomination_currency": "USD",
    "value_in_usd": 5181945.09,
    "percentage_value_compared_to_assets": 0.000271384232,
    "payoff_profile": "Long",
    "asset_type": "EC",
    "issuer_type": "CORP",
    "country_of_issuer_or_investment": "US",
    "is_restricted_security": false,
    "fair_value_level": 1,
    "is_cash_collateral": false,
    "is_non_cash_collateral": false,
    "is_loan_by_fund": true
  }
*/