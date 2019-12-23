# Cloudmersive.APIClient.NET.Validate.Api.UserAgentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserAgentParse**](UserAgentApi.md#useragentparse) | **POST** /validate/useragent/parse | Parse an HTTP User-Agent string, identify robots


<a name="useragentparse"></a>
# **UserAgentParse**
> UserAgentValidateResponse UserAgentParse (UserAgentValidateRequest request)

Parse an HTTP User-Agent string, identify robots

Uses a parsing system and database to parse the User-Agent into its structured component parts, such as Browser, Browser Version, Browser Engine, Operating System, and importantly, Robot identification.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class UserAgentParseExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new UserAgentApi();
            var request = new UserAgentValidateRequest(); // UserAgentValidateRequest | Input parse request

            try
            {
                // Parse an HTTP User-Agent string, identify robots
                UserAgentValidateResponse result = apiInstance.UserAgentParse(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserAgentApi.UserAgentParse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UserAgentValidateRequest**](UserAgentValidateRequest.md)| Input parse request | 

### Return type

[**UserAgentValidateResponse**](UserAgentValidateResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

