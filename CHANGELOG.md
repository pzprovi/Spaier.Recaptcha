# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [3.2.0]

### Added

- Add `configureHttpBuilder` parameter to `AddRecaptchaHttpClient` that allows to specify http policies like retry.

### Fixed

- Call `AddHttpClient` without the `name` parameter when `name is null`
- Configuration unspecified errors when `Configurations is null` in `ValidateRecaptchaAttribute`, but configuration was specified.
- First configuration value is used instead of the specified configuration.
- Don't check `AllowedAction` for `V2Android`

## [3.1.0]

### Fixed

- `AllowedAction` is checked for V2 and V3 reCAPTCHA

### Added

- Added `recaptcha-no-success` error code
- Added `timeout-or-duplicate` error code
- Added Custom url provider
- Added `AddModelErrors` flag
- Custom errors are added to `ErrorCodes`

## [3.0.0]

### Fixed

- Configuration is not allowed errors with multiple configurations
- Add `recaptcha-unspecified-configuration` MVC error
- Add `recaptcha-missing-configuration` MVC error

### Added

- `RecaptchaResponse` type that contains properties from all other responses

### Changed

- `IRecaptchaConfigurationStore` must implement `TryGetRecaptchaConfiguration`
- `ValidateRecaptchaAttribute` MVC errors were moved to `ValidateRecaptchaAttribute.ErrorCodes` from `RecaptchaDefaults`
- `MinimumScore` defaults to 0.5

### Removed

- Version specific responses
- Removed `IRecaptchaConfigurationStore.GetRecaptchaConfiguration`

## [2.0.0]

### Fixed

- Null reference exceptions in `RecaptchaTokenHeaderProvider`

## [2.0.0-alpha2]

### Fixed

- Null reference exception in Razor MVC when action has parameters

## [2.0.0-alpha1]

### Added

- Pass recaptcha response with `FromRecaptchaResponseAttribute`
- Add V3 Score and Action integration
- Add configuration store interface
- Add InMemory configuration store

### Changed

- Use model errors instead of exceptions

### Fixed

- Model errors cause to return 400 error in web api

### Removed

- Remove success handler

## [2.0.0-alpha0]

### Added

- Add success handler(Can be used to check response)
- Add test reCAPTCHA secrets
- Add di builder
- Add implementations of `IRecaptchaConfigurationProvider` and `IRecaptchaTokenProvider` that extract info from HTTP headers

### Changed

- Send only one request to google api
- Recaptcha configuration should be determined by `IRecaptchaConfigurationProvider`
- Recaptcha token should be determined by `IRecaptchaTokenProvider`

### Removed

- Remove predefined configurations and attributes

### Fixed

- Fix Http client injection bug 

[Unreleased]: https://github.com/Spaier/Spaier.Recaptcha/compare/3.2.0...HEAD
[3.2.0]: https://github.com/Spaier/Spaier.Recaptcha/compare/3.1.0...3.2.0
[3.1.0]: https://github.com/Spaier/Spaier.Recaptcha/compare/3.0.0...3.1.0
[3.0.0]: https://github.com/Spaier/Spaier.Recaptcha/compare/2.0.0...3.0.0
[2.0.0]: https://github.com/Spaier/Spaier.Recaptcha/compare/2.0.0-alpha2...2.0.0
[2.0.0-alpha2]: https://github.com/Spaier/Spaier.Recaptcha/compare/2.0.0-alpha1...2.0.0-alpha2
[2.0.0-alpha1]: https://github.com/Spaier/Spaier.Recaptcha/compare/2.0.0-alpha0...2.0.0-alpha1