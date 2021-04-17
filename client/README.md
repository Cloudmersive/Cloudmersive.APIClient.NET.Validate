# Cloudmersive.APIClient.NET.Validate - the C# library for the validateapi

The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.

This C# SDK is for the [Cloudmersive Validate API](https://www.cloudmersive.com/validate-api):

- API version: v1
- SDK version: 3.2.4
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.Validate.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new AddressApi();
            var input = new ValidateCountryRequest(); // ValidateCountryRequest | Input request

            try
            {
                // Check if a country is a member of the European Union (EU)
                ValidateCountryResponse result = apiInstance.AddressCheckEUMembership(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressCheckEUMembership: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddressApi* | [**AddressCheckEUMembership**](docs/AddressApi.md#addresscheckeumembership) | **POST** /validate/address/country/check-eu-membership | Check if a country is a member of the European Union (EU)
*AddressApi* | [**AddressCountry**](docs/AddressApi.md#addresscountry) | **POST** /validate/address/country | Validate and normalize country information, return ISO 3166-1 country codes and country name
*AddressApi* | [**AddressCountryList**](docs/AddressApi.md#addresscountrylist) | **POST** /validate/address/country/list | Get a list of ISO 3166-1 countries
*AddressApi* | [**AddressGeocode**](docs/AddressApi.md#addressgeocode) | **POST** /validate/address/geocode | Geocode a street address into latitude and longitude
*AddressApi* | [**AddressGetCountryCurrency**](docs/AddressApi.md#addressgetcountrycurrency) | **POST** /validate/address/country/get-currency | Get the currency of the input country
*AddressApi* | [**AddressGetCountryRegion**](docs/AddressApi.md#addressgetcountryregion) | **POST** /validate/address/country/get-region | Get the region, subregion and continent of the country
*AddressApi* | [**AddressGetTimezone**](docs/AddressApi.md#addressgettimezone) | **POST** /validate/address/country/get-timezones | Gets IANA/Olsen time zones for a country
*AddressApi* | [**AddressNormalizeAddress**](docs/AddressApi.md#addressnormalizeaddress) | **POST** /validate/address/street-address/normalize | Normalize a street address
*AddressApi* | [**AddressParseString**](docs/AddressApi.md#addressparsestring) | **POST** /validate/address/parse | Parse an unstructured input text string into an international, formatted address
*AddressApi* | [**AddressReverseGeocodeAddress**](docs/AddressApi.md#addressreversegeocodeaddress) | **POST** /validate/address/geocode/reverse | Reverse geocode a lattitude and longitude into an address
*AddressApi* | [**AddressValidateAddress**](docs/AddressApi.md#addressvalidateaddress) | **POST** /validate/address/street-address | Validate a street address
*AddressApi* | [**AddressValidateCity**](docs/AddressApi.md#addressvalidatecity) | **POST** /validate/address/city | Validate a City and State/Province combination, get location information about it
*AddressApi* | [**AddressValidatePostalCode**](docs/AddressApi.md#addressvalidatepostalcode) | **POST** /validate/address/postal-code | Validate a postal code, get location information about it
*AddressApi* | [**AddressValidateState**](docs/AddressApi.md#addressvalidatestate) | **POST** /validate/address/state | Validate a state or province, name or abbreviation, get location information about it
*DateTimeApi* | [**DateTimeGetNowSimple**](docs/DateTimeApi.md#datetimegetnowsimple) | **GET** /validate/date-time/get/now | Get current date and time as of now
*DateTimeApi* | [**DateTimeGetPublicHolidays**](docs/DateTimeApi.md#datetimegetpublicholidays) | **POST** /validate/date-time/get/holidays | Get public holidays in the specified country and year
*DateTimeApi* | [**DateTimeParseNaturalLanguageDateTime**](docs/DateTimeApi.md#datetimeparsenaturallanguagedatetime) | **POST** /validate/date-time/parse/date-time/natural-language | Parses a free-form natural language date and time string into a date and time
*DateTimeApi* | [**DateTimeParseStandardDateTime**](docs/DateTimeApi.md#datetimeparsestandarddatetime) | **POST** /validate/date-time/parse/date-time/structured | Parses a standardized date and time string into a date and time
*DomainApi* | [**DomainCheck**](docs/DomainApi.md#domaincheck) | **POST** /validate/domain/check | Validate a domain name
*DomainApi* | [**DomainGetTopLevelDomainFromUrl**](docs/DomainApi.md#domaingettopleveldomainfromurl) | **POST** /validate/domain/url/get-top-level-domain | Get top-level domain name from URL
*DomainApi* | [**DomainPhishingCheck**](docs/DomainApi.md#domainphishingcheck) | **POST** /validate/domain/url/phishing-threat-check | Check a URL for Phishing threats
*DomainApi* | [**DomainPost**](docs/DomainApi.md#domainpost) | **POST** /validate/domain/whois | Get WHOIS information for a domain
*DomainApi* | [**DomainQualityScore**](docs/DomainApi.md#domainqualityscore) | **POST** /validate/domain/quality-score | Validate a domain name's quality score
*DomainApi* | [**DomainSafetyCheck**](docs/DomainApi.md#domainsafetycheck) | **POST** /validate/domain/url/safety-threat-check | Check a URL for safety threats
*DomainApi* | [**DomainSsrfCheck**](docs/DomainApi.md#domainssrfcheck) | **POST** /validate/domain/url/ssrf-threat-check | Check a URL for SSRF threats
*DomainApi* | [**DomainSsrfCheckBatch**](docs/DomainApi.md#domainssrfcheckbatch) | **POST** /validate/domain/url/ssrf-threat-check/batch | Check a URL for SSRF threats in batches
*DomainApi* | [**DomainUrlFull**](docs/DomainApi.md#domainurlfull) | **POST** /validate/domain/url/full | Validate a URL fully
*DomainApi* | [**DomainUrlSyntaxOnly**](docs/DomainApi.md#domainurlsyntaxonly) | **POST** /validate/domain/url/syntax-only | Validate a URL syntactically
*EmailApi* | [**EmailAddressGetServers**](docs/EmailApi.md#emailaddressgetservers) | **POST** /validate/email/address/servers | Partially check whether an email address is valid
*EmailApi* | [**EmailFullValidation**](docs/EmailApi.md#emailfullvalidation) | **POST** /validate/email/address/full | Fully validate an email address
*EmailApi* | [**EmailPost**](docs/EmailApi.md#emailpost) | **POST** /validate/email/address/syntaxOnly | Validate email adddress for syntactic correctness only
*IPAddressApi* | [**IPAddressGeolocateStreetAddress**](docs/IPAddressApi.md#ipaddressgeolocatestreetaddress) | **POST** /validate/ip/geolocate/street-address | Geolocate an IP address to a street address
*IPAddressApi* | [**IPAddressIpIntelligence**](docs/IPAddressApi.md#ipaddressipintelligence) | **POST** /validate/ip/intelligence | Get intelligence on an IP address
*IPAddressApi* | [**IPAddressIsBot**](docs/IPAddressApi.md#ipaddressisbot) | **POST** /validate/ip/is-bot | Check if IP address is a Bot client
*IPAddressApi* | [**IPAddressIsThreat**](docs/IPAddressApi.md#ipaddressisthreat) | **POST** /validate/ip/is-threat | Check if IP address is a known threat
*IPAddressApi* | [**IPAddressIsTorNode**](docs/IPAddressApi.md#ipaddressistornode) | **POST** /validate/ip/is-tor-node | Check if IP address is a Tor node server
*IPAddressApi* | [**IPAddressPost**](docs/IPAddressApi.md#ipaddresspost) | **POST** /validate/ip/geolocate | Geolocate an IP address
*IPAddressApi* | [**IPAddressReverseDomainLookup**](docs/IPAddressApi.md#ipaddressreversedomainlookup) | **POST** /validate/ip/reverse-domain-lookup | Perform a reverse domain name (DNS) lookup on an IP address
*LeadEnrichmentApi* | [**LeadEnrichmentEnrichLead**](docs/LeadEnrichmentApi.md#leadenrichmentenrichlead) | **POST** /validate/lead-enrichment/lead/enrich | Enrich an input lead with additional fields of data
*NameApi* | [**NameGetGender**](docs/NameApi.md#namegetgender) | **POST** /validate/name/get-gender | Get the gender of a first name
*NameApi* | [**NameIdentifier**](docs/NameApi.md#nameidentifier) | **POST** /validate/name/identifier | Validate a code identifier
*NameApi* | [**NameValidateFirstName**](docs/NameApi.md#namevalidatefirstname) | **POST** /validate/name/first | Validate a first name
*NameApi* | [**NameValidateFullName**](docs/NameApi.md#namevalidatefullname) | **POST** /validate/name/full-name | Parse and validate a full name
*NameApi* | [**NameValidateLastName**](docs/NameApi.md#namevalidatelastname) | **POST** /validate/name/last | Validate a last name
*PhoneNumberApi* | [**PhoneNumberSyntaxOnly**](docs/PhoneNumberApi.md#phonenumbersyntaxonly) | **POST** /validate/phonenumber/basic | Validate phone number (basic)
*TextInputApi* | [**TextInputCheckSqlInjection**](docs/TextInputApi.md#textinputchecksqlinjection) | **POST** /validate/text-input/check/sql-injection | Check text input for SQL Injection (SQLI) attacks
*TextInputApi* | [**TextInputCheckSqlInjectionBatch**](docs/TextInputApi.md#textinputchecksqlinjectionbatch) | **POST** /validate/text-input/check/sql-injection/batch | Check and protect multiple text inputs for SQL Injection (SQLI) attacks in batch
*TextInputApi* | [**TextInputCheckXss**](docs/TextInputApi.md#textinputcheckxss) | **POST** /validate/text-input/check/xss | Check text input for Cross-Site-Scripting (XSS) attacks
*TextInputApi* | [**TextInputCheckXssBatch**](docs/TextInputApi.md#textinputcheckxssbatch) | **POST** /validate/text-input/check-and-protect/xss/batch | Check and protect multiple text inputs for Cross-Site-Scripting (XSS) attacks in batch
*TextInputApi* | [**TextInputCheckXxe**](docs/TextInputApi.md#textinputcheckxxe) | **POST** /validate/text-input/check/xxe | Protect text input from XML External Entity (XXE) attacks
*TextInputApi* | [**TextInputCheckXxeBatch**](docs/TextInputApi.md#textinputcheckxxebatch) | **POST** /validate/text-input/check/xxe/batch | Protect text input from XML External Entity (XXE) attacks
*TextInputApi* | [**TextInputProtectXss**](docs/TextInputApi.md#textinputprotectxss) | **POST** /validate/text-input/protect/xss | Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
*UserAgentApi* | [**UserAgentParse**](docs/UserAgentApi.md#useragentparse) | **POST** /validate/useragent/parse | Parse an HTTP User-Agent string, identify robots
*VatApi* | [**VatVatLookup**](docs/VatApi.md#vatvatlookup) | **POST** /validate/vat/lookup | Validate a VAT number


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressGetServersResponse](docs/AddressGetServersResponse.md)
 - [Model.AddressVerifySyntaxOnlyResponse](docs/AddressVerifySyntaxOnlyResponse.md)
 - [Model.BotCheckResponse](docs/BotCheckResponse.md)
 - [Model.CheckResponse](docs/CheckResponse.md)
 - [Model.CountryDetails](docs/CountryDetails.md)
 - [Model.CountryListResult](docs/CountryListResult.md)
 - [Model.DateTimeNaturalLanguageParseRequest](docs/DateTimeNaturalLanguageParseRequest.md)
 - [Model.DateTimeNowResult](docs/DateTimeNowResult.md)
 - [Model.DateTimeStandardizedParseRequest](docs/DateTimeStandardizedParseRequest.md)
 - [Model.DateTimeStandardizedParseResponse](docs/DateTimeStandardizedParseResponse.md)
 - [Model.DomainQualityResponse](docs/DomainQualityResponse.md)
 - [Model.FirstNameValidationRequest](docs/FirstNameValidationRequest.md)
 - [Model.FirstNameValidationResponse](docs/FirstNameValidationResponse.md)
 - [Model.FullEmailValidationResponse](docs/FullEmailValidationResponse.md)
 - [Model.FullNameValidationRequest](docs/FullNameValidationRequest.md)
 - [Model.FullNameValidationResponse](docs/FullNameValidationResponse.md)
 - [Model.GeolocateResponse](docs/GeolocateResponse.md)
 - [Model.GeolocateStreetAddressResponse](docs/GeolocateStreetAddressResponse.md)
 - [Model.GetGenderRequest](docs/GetGenderRequest.md)
 - [Model.GetGenderResponse](docs/GetGenderResponse.md)
 - [Model.GetPublicHolidaysRequest](docs/GetPublicHolidaysRequest.md)
 - [Model.GetTimezonesRequest](docs/GetTimezonesRequest.md)
 - [Model.GetTimezonesResponse](docs/GetTimezonesResponse.md)
 - [Model.IPIntelligenceResponse](docs/IPIntelligenceResponse.md)
 - [Model.IPReverseDNSLookupResponse](docs/IPReverseDNSLookupResponse.md)
 - [Model.IPThreatResponse](docs/IPThreatResponse.md)
 - [Model.LastNameValidationRequest](docs/LastNameValidationRequest.md)
 - [Model.LastNameValidationResponse](docs/LastNameValidationResponse.md)
 - [Model.LeadEnrichmentRequest](docs/LeadEnrichmentRequest.md)
 - [Model.LeadEnrichmentResponse](docs/LeadEnrichmentResponse.md)
 - [Model.NormalizeAddressResponse](docs/NormalizeAddressResponse.md)
 - [Model.ParseAddressRequest](docs/ParseAddressRequest.md)
 - [Model.ParseAddressResponse](docs/ParseAddressResponse.md)
 - [Model.PhishingCheckRequest](docs/PhishingCheckRequest.md)
 - [Model.PhishingCheckResponse](docs/PhishingCheckResponse.md)
 - [Model.PhoneNumberValidateRequest](docs/PhoneNumberValidateRequest.md)
 - [Model.PhoneNumberValidationResponse](docs/PhoneNumberValidationResponse.md)
 - [Model.PublicHolidayOccurrence](docs/PublicHolidayOccurrence.md)
 - [Model.PublicHolidaysResponse](docs/PublicHolidaysResponse.md)
 - [Model.ReverseGeocodeAddressRequest](docs/ReverseGeocodeAddressRequest.md)
 - [Model.ReverseGeocodeAddressResponse](docs/ReverseGeocodeAddressResponse.md)
 - [Model.SqlInjectionCheckBatchRequest](docs/SqlInjectionCheckBatchRequest.md)
 - [Model.SqlInjectionCheckBatchResponse](docs/SqlInjectionCheckBatchResponse.md)
 - [Model.SqlInjectionCheckRequestItem](docs/SqlInjectionCheckRequestItem.md)
 - [Model.SqlInjectionDetectionResult](docs/SqlInjectionDetectionResult.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.TorNodeResponse](docs/TorNodeResponse.md)
 - [Model.UrlSafetyCheckRequestFull](docs/UrlSafetyCheckRequestFull.md)
 - [Model.UrlSafetyCheckResponseFull](docs/UrlSafetyCheckResponseFull.md)
 - [Model.UrlSsrfRequestBatch](docs/UrlSsrfRequestBatch.md)
 - [Model.UrlSsrfRequestFull](docs/UrlSsrfRequestFull.md)
 - [Model.UrlSsrfResponseBatch](docs/UrlSsrfResponseBatch.md)
 - [Model.UrlSsrfResponseFull](docs/UrlSsrfResponseFull.md)
 - [Model.UserAgentValidateRequest](docs/UserAgentValidateRequest.md)
 - [Model.UserAgentValidateResponse](docs/UserAgentValidateResponse.md)
 - [Model.ValidateAddressRequest](docs/ValidateAddressRequest.md)
 - [Model.ValidateAddressResponse](docs/ValidateAddressResponse.md)
 - [Model.ValidateCityRequest](docs/ValidateCityRequest.md)
 - [Model.ValidateCityResponse](docs/ValidateCityResponse.md)
 - [Model.ValidateCountryRequest](docs/ValidateCountryRequest.md)
 - [Model.ValidateCountryResponse](docs/ValidateCountryResponse.md)
 - [Model.ValidateIdentifierRequest](docs/ValidateIdentifierRequest.md)
 - [Model.ValidateIdentifierResponse](docs/ValidateIdentifierResponse.md)
 - [Model.ValidatePostalCodeRequest](docs/ValidatePostalCodeRequest.md)
 - [Model.ValidatePostalCodeResponse](docs/ValidatePostalCodeResponse.md)
 - [Model.ValidateStateRequest](docs/ValidateStateRequest.md)
 - [Model.ValidateStateResponse](docs/ValidateStateResponse.md)
 - [Model.ValidateUrlRequestFull](docs/ValidateUrlRequestFull.md)
 - [Model.ValidateUrlRequestSyntaxOnly](docs/ValidateUrlRequestSyntaxOnly.md)
 - [Model.ValidateUrlResponseFull](docs/ValidateUrlResponseFull.md)
 - [Model.ValidateUrlResponseSyntaxOnly](docs/ValidateUrlResponseSyntaxOnly.md)
 - [Model.VatLookupRequest](docs/VatLookupRequest.md)
 - [Model.VatLookupResponse](docs/VatLookupResponse.md)
 - [Model.WhoisResponse](docs/WhoisResponse.md)
 - [Model.XssProtectionBatchRequest](docs/XssProtectionBatchRequest.md)
 - [Model.XssProtectionBatchResponse](docs/XssProtectionBatchResponse.md)
 - [Model.XssProtectionRequestItem](docs/XssProtectionRequestItem.md)
 - [Model.XssProtectionResult](docs/XssProtectionResult.md)
 - [Model.XxeDetectionBatchRequest](docs/XxeDetectionBatchRequest.md)
 - [Model.XxeDetectionBatchResponse](docs/XxeDetectionBatchResponse.md)
 - [Model.XxeDetectionRequestItem](docs/XxeDetectionRequestItem.md)
 - [Model.XxeDetectionResult](docs/XxeDetectionResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

