# Cloudmersive.APIClient.NET.Validate - the C# library for the validateapi

The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.

This C# SDK is for the [Cloudmersive Validate API](https://www.cloudmersive.com/validate-api):

- API version: v1
- SDK version: 3.0.5
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
                // Validate and normalize country information, return ISO 3166-1 country codes and country name
                ValidateCountryResponse result = apiInstance.AddressCountry(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressCountry: " + e.Message );
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
*AddressApi* | [**AddressCountry**](docs/AddressApi.md#addresscountry) | **POST** /validate/address/country | Validate and normalize country information, return ISO 3166-1 country codes and country name
*AddressApi* | [**AddressGetTimezone**](docs/AddressApi.md#addressgettimezone) | **POST** /validate/address/country/get-timezones | Gets IANA/Olsen time zones for a country
*AddressApi* | [**AddressParseString**](docs/AddressApi.md#addressparsestring) | **POST** /validate/address/parse | Parse an unstructured input text string into an international, formatted address
*DomainApi* | [**DomainCheck**](docs/DomainApi.md#domaincheck) | **POST** /validate/domain/check | Validate a domain name
*DomainApi* | [**DomainPost**](docs/DomainApi.md#domainpost) | **POST** /validate/domain/whois | Get WHOIS information for a domain
*DomainApi* | [**DomainUrlFull**](docs/DomainApi.md#domainurlfull) | **POST** /validate/domain/url/full | Validate a URL fully
*DomainApi* | [**DomainUrlSyntaxOnly**](docs/DomainApi.md#domainurlsyntaxonly) | **POST** /validate/domain/url/syntax-only | Validate a URL syntactically
*EmailApi* | [**EmailAddressGetServers**](docs/EmailApi.md#emailaddressgetservers) | **POST** /validate/email/address/servers | Partially check whether an email address is valid
*EmailApi* | [**EmailFullValidation**](docs/EmailApi.md#emailfullvalidation) | **POST** /validate/email/address/full | Fully validate an email address
*EmailApi* | [**EmailPost**](docs/EmailApi.md#emailpost) | **POST** /validate/email/address/syntaxOnly | Validate email adddress for syntactic correctness only
*IPAddressApi* | [**IPAddressPost**](docs/IPAddressApi.md#ipaddresspost) | **POST** /validate/ip/geolocate | Geolocate an IP address
*LeadEnrichmentApi* | [**LeadEnrichmentEnrichLead**](docs/LeadEnrichmentApi.md#leadenrichmentenrichlead) | **POST** /validate/lead-enrichment/lead/enrich | Enrich an input lead with additional fields of data
*NameApi* | [**NameGetGender**](docs/NameApi.md#namegetgender) | **POST** /validate/name/get-gender | Get the gender of a first name
*NameApi* | [**NameIdentifier**](docs/NameApi.md#nameidentifier) | **POST** /validate/name/identifier | Validate a code identifier
*NameApi* | [**NameValidateFirstName**](docs/NameApi.md#namevalidatefirstname) | **POST** /validate/name/first | Validate a first name
*NameApi* | [**NameValidateFullName**](docs/NameApi.md#namevalidatefullname) | **POST** /validate/name/full-name | Parse and validate a full name
*NameApi* | [**NameValidateLastName**](docs/NameApi.md#namevalidatelastname) | **POST** /validate/name/last | Validate a last name
*PhoneNumberApi* | [**PhoneNumberSyntaxOnly**](docs/PhoneNumberApi.md#phonenumbersyntaxonly) | **POST** /validate/phonenumber/basic | Validate phone number (basic)
*UserAgentApi* | [**UserAgentParse**](docs/UserAgentApi.md#useragentparse) | **POST** /validate/useragent/parse | Parse an HTTP User-Agent string, identify robots
*VatApi* | [**VatVatLookup**](docs/VatApi.md#vatvatlookup) | **POST** /validate/vat/lookup | Lookup a VAT code


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressGetServersResponse](docs/AddressGetServersResponse.md)
 - [Model.AddressVerifySyntaxOnlyResponse](docs/AddressVerifySyntaxOnlyResponse.md)
 - [Model.CheckResponse](docs/CheckResponse.md)
 - [Model.FirstNameValidationRequest](docs/FirstNameValidationRequest.md)
 - [Model.FirstNameValidationResponse](docs/FirstNameValidationResponse.md)
 - [Model.FullEmailValidationResponse](docs/FullEmailValidationResponse.md)
 - [Model.FullNameValidationRequest](docs/FullNameValidationRequest.md)
 - [Model.FullNameValidationResponse](docs/FullNameValidationResponse.md)
 - [Model.GeolocateResponse](docs/GeolocateResponse.md)
 - [Model.GetGenderRequest](docs/GetGenderRequest.md)
 - [Model.GetGenderResponse](docs/GetGenderResponse.md)
 - [Model.GetTimezonesRequest](docs/GetTimezonesRequest.md)
 - [Model.GetTimezonesResponse](docs/GetTimezonesResponse.md)
 - [Model.LastNameValidationRequest](docs/LastNameValidationRequest.md)
 - [Model.LastNameValidationResponse](docs/LastNameValidationResponse.md)
 - [Model.LeadEnrichmentRequest](docs/LeadEnrichmentRequest.md)
 - [Model.LeadEnrichmentResponse](docs/LeadEnrichmentResponse.md)
 - [Model.ParseAddressRequest](docs/ParseAddressRequest.md)
 - [Model.ParseAddressResponse](docs/ParseAddressResponse.md)
 - [Model.PhoneNumberValidateRequest](docs/PhoneNumberValidateRequest.md)
 - [Model.PhoneNumberValidationResponse](docs/PhoneNumberValidationResponse.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.UserAgentValidateRequest](docs/UserAgentValidateRequest.md)
 - [Model.UserAgentValidateResponse](docs/UserAgentValidateResponse.md)
 - [Model.ValidateCountryRequest](docs/ValidateCountryRequest.md)
 - [Model.ValidateCountryResponse](docs/ValidateCountryResponse.md)
 - [Model.ValidateIdentifierRequest](docs/ValidateIdentifierRequest.md)
 - [Model.ValidateIdentifierResponse](docs/ValidateIdentifierResponse.md)
 - [Model.ValidateUrlRequestFull](docs/ValidateUrlRequestFull.md)
 - [Model.ValidateUrlRequestSyntaxOnly](docs/ValidateUrlRequestSyntaxOnly.md)
 - [Model.ValidateUrlResponseFull](docs/ValidateUrlResponseFull.md)
 - [Model.ValidateUrlResponseSyntaxOnly](docs/ValidateUrlResponseSyntaxOnly.md)
 - [Model.VatLookupRequest](docs/VatLookupRequest.md)
 - [Model.VatLookupResponse](docs/VatLookupResponse.md)
 - [Model.WhoisResponse](docs/WhoisResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

