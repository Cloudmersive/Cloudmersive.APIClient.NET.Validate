# Cloudmersive.APIClient.NET.Validate.Api.LeadEnrichmentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadEnrichmentEnrichLead**](LeadEnrichmentApi.md#leadenrichmentenrichlead) | **POST** /validate/lead-enrichment/lead/enrich | Enrich an input lead with additional fields of data


<a name="leadenrichmentenrichlead"></a>
# **LeadEnrichmentEnrichLead**
> LeadEnrichmentResponse LeadEnrichmentEnrichLead (LeadEnrichmentRequest request)

Enrich an input lead with additional fields of data

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class LeadEnrichmentEnrichLeadExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new LeadEnrichmentApi();
            var request = new LeadEnrichmentRequest(); // LeadEnrichmentRequest | Input lead with known fields set, and unknown fields left blank (null)

            try
            {
                // Enrich an input lead with additional fields of data
                LeadEnrichmentResponse result = apiInstance.LeadEnrichmentEnrichLead(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeadEnrichmentApi.LeadEnrichmentEnrichLead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**LeadEnrichmentRequest**](LeadEnrichmentRequest.md)| Input lead with known fields set, and unknown fields left blank (null) | 

### Return type

[**LeadEnrichmentResponse**](LeadEnrichmentResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

