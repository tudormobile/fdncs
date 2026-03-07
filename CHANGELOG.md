# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Planned
- Integration tests
- Standard and Premium implementations

## [0.2.0] - 2026-03-07
### Added
- Improved unit tests (100% coverage of library and entities)
- Placeholders for Standard and Premium endpoints implemented and tested

## [0.1.0] - 2026-03-05
### Added
- Improved documentation
- Additional endpoints for free tier
- Complete entity data model
- Endpoint stubs for completing the api surface area

## [0.0.1] - 2026-03-1
### Added
- Initial skeleton an minimal implementation

---

## Links

- [NuGet Package](https://www.nuget.org/packages/Tudormobile.FinancialData/)
- [GitHub Repository](https://github.com/tudormobile/fdncs)
- [Documentation](https://tudormobile.github.io/fdncs/)
- [API Documentation](https://tudormobile.github.io/fdncs/api/Tudormobile.html)
- [Financial Data Network API](https://financialdata.net/documentation/)

## How to Update This Changelog

### For Maintainers

When making changes, add entries under `## [Unreleased]` in the appropriate category:

- **Added** for new features
- **Changed** for changes in existing functionality
- **Deprecated** for soon-to-be removed features
- **Removed** for now removed features
- **Fixed** for any bug fixes
- **Security** in case of vulnerabilities

When releasing a new version:
1. Change `[Unreleased]` to the version number and date: `[X.Y.Z] - YYYY-MM-DD`
2. Add a new `[Unreleased]` section at the top
3. Commit with message: `chore: release vX.Y.Z`
