# Cloudmersive.APIClient.NET.Validate.Api.TextInputApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TextInputCheckXss**](TextInputApi.md#textinputcheckxss) | **POST** /validate/text-input/check/xss | Check text input for Cross-Site-Scripting (XSS) attacks
[**TextInputCheckXssBatch**](TextInputApi.md#textinputcheckxssbatch) | **POST** /validate/text-input/check-and-protect/xss/batch | Check and protect multiple text inputs for Cross-Site-Scripting (XSS) attacks in batch
[**TextInputProtectXss**](TextInputApi.md#textinputprotectxss) | **POST** /validate/text-input/protect/xss | Protect text input from Cross-Site-Scripting (XSS) attacks through normalization


<a name="textinputcheckxss"></a>
# **TextInputCheckXss**
> XssProtectionResult TextInputCheckXss (string value)

Check text input for Cross-Site-Scripting (XSS) attacks

Detects XSS (Cross-Site-Scripting) attacks from text input.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class TextInputCheckXssExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TextInputApi();
            var value = value_example;  // string | User-facing text input.

            try
            {
                // Check text input for Cross-Site-Scripting (XSS) attacks
                XssProtectionResult result = apiInstance.TextInputCheckXss(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextInputApi.TextInputCheckXss: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| User-facing text input. | 

### Return type

[**XssProtectionResult**](XssProtectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="textinputcheckxssbatch"></a>
# **TextInputCheckXssBatch**
> XssProtectionBatchResponse TextInputCheckXssBatch (XssProtectionBatchRequest value)

Check and protect multiple text inputs for Cross-Site-Scripting (XSS) attacks in batch

Detects XSS (Cross-Site-Scripting) attacks from multiple text input.  Output preverses order of input items.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class TextInputCheckXssBatchExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TextInputApi();
            var value = new XssProtectionBatchRequest(); // XssProtectionBatchRequest | User-facing text input.

            try
            {
                // Check and protect multiple text inputs for Cross-Site-Scripting (XSS) attacks in batch
                XssProtectionBatchResponse result = apiInstance.TextInputCheckXssBatch(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextInputApi.TextInputCheckXssBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**XssProtectionBatchRequest**](XssProtectionBatchRequest.md)| User-facing text input. | 

### Return type

[**XssProtectionBatchResponse**](XssProtectionBatchResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="textinputprotectxss"></a>
# **TextInputProtectXss**
> XssProtectionResult TextInputProtectXss (string value)

Protect text input from Cross-Site-Scripting (XSS) attacks through normalization

Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class TextInputProtectXssExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TextInputApi();
            var value = value_example;  // string | User-facing text input.

            try
            {
                // Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
                XssProtectionResult result = apiInstance.TextInputProtectXss(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TextInputApi.TextInputProtectXss: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| User-facing text input. | 

### Return type

[**XssProtectionResult**](XssProtectionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

