# Cloudmersive.APIClient.NET.Validate.Api.VatApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VatVatLookup**](VatApi.md#vatvatlookup) | **POST** /validate/vat/lookup | Validate a VAT number


<a name="vatvatlookup"></a>
# **VatVatLookup**
> VatLookupResponse VatVatLookup (VatLookupRequest input)

Validate a VAT number

Checks if a VAT code is valid, and if it is, returns more information about it.  The first two letters of the VAT number must be letters that indicate the country, such as LU20260743.  Possible country codes include Austria (AT), Belgium (BE), Bulgaria (BG), Cyprus (CY), Czech Republic (CZ), Germany (DE), Denmark (DK), Estonia (EE), Greece (EL), Spain (ES), Finland (FI), France (FR), United Kingdom (GB), Croatia (HR), Hungary (HU), Ireland (IE), Italy (IT), Lithuania (LT), Luxembourg (LU), Latvia (LV), Malta (MT), The Netherlands (NL), Poland (PL), Portugal (PT), Romania (RO), Sweden (SE), Slovenia (SI), Slovakia (SK).

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class VatVatLookupExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new VatApi();
            var input = new VatLookupRequest(); // VatLookupRequest | Input VAT code

            try
            {
                // Validate a VAT number
                VatLookupResponse result = apiInstance.VatVatLookup(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VatApi.VatVatLookup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**VatLookupRequest**](VatLookupRequest.md)| Input VAT code | 

### Return type

[**VatLookupResponse**](VatLookupResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

