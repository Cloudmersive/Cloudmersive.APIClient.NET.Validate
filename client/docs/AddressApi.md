# Cloudmersive.APIClient.NET.Validate.Api.AddressApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressCountry**](AddressApi.md#addresscountry) | **POST** /validate/address/country | Validate and normalize country information, return ISO 3166-1 country codes and country name
[**AddressGetTimezone**](AddressApi.md#addressgettimezone) | **POST** /validate/address/country/get-timezones | Gets IANA/Olsen time zones for a country
[**AddressParseString**](AddressApi.md#addressparsestring) | **POST** /validate/address/parse | Parse an unstructured input text string into an international, formatted address
[**AddressValidateAddress**](AddressApi.md#addressvalidateaddress) | **POST** /validate/address/street-address | Validate a street address


<a name="addresscountry"></a>
# **AddressCountry**
> ValidateCountryResponse AddressCountry (ValidateCountryRequest input)

Validate and normalize country information, return ISO 3166-1 country codes and country name

Validates and normalizes country information, and returns key information about a country.  Also returns distinct time zones in the country.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class AddressCountryExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**ValidateCountryRequest**](ValidateCountryRequest.md)| Input request | 

### Return type

[**ValidateCountryResponse**](ValidateCountryResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressgettimezone"></a>
# **AddressGetTimezone**
> GetTimezonesResponse AddressGetTimezone (GetTimezonesRequest input)

Gets IANA/Olsen time zones for a country

Gets the IANA/Olsen time zones for a country.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class AddressGetTimezoneExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AddressApi();
            var input = new GetTimezonesRequest(); // GetTimezonesRequest | Input request

            try
            {
                // Gets IANA/Olsen time zones for a country
                GetTimezonesResponse result = apiInstance.AddressGetTimezone(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressGetTimezone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**GetTimezonesRequest**](GetTimezonesRequest.md)| Input request | 

### Return type

[**GetTimezonesResponse**](GetTimezonesResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressparsestring"></a>
# **AddressParseString**
> ParseAddressResponse AddressParseString (ParseAddressRequest input)

Parse an unstructured input text string into an international, formatted address

Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class AddressParseStringExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AddressApi();
            var input = new ParseAddressRequest(); // ParseAddressRequest | Input parse request

            try
            {
                // Parse an unstructured input text string into an international, formatted address
                ParseAddressResponse result = apiInstance.AddressParseString(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressParseString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**ParseAddressRequest**](ParseAddressRequest.md)| Input parse request | 

### Return type

[**ParseAddressResponse**](ParseAddressResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addressvalidateaddress"></a>
# **AddressValidateAddress**
> ValidateAddressResponse AddressValidateAddress (ValidateAddressRequest input)

Validate a street address

Determines if an input structured street address is valid or invalid.  If the address is valid, also returns the latitude and longitude of the address.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class AddressValidateAddressExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AddressApi();
            var input = new ValidateAddressRequest(); // ValidateAddressRequest | Input parse request

            try
            {
                // Validate a street address
                ValidateAddressResponse result = apiInstance.AddressValidateAddress(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressValidateAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**ValidateAddressRequest**](ValidateAddressRequest.md)| Input parse request | 

### Return type

[**ValidateAddressResponse**](ValidateAddressResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

