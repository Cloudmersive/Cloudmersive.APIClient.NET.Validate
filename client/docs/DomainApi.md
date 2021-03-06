# Cloudmersive.APIClient.NET.Validate.Api.DomainApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DomainCheck**](DomainApi.md#domaincheck) | **POST** /validate/domain/check | Validate a domain name
[**DomainGetTopLevelDomainFromUrl**](DomainApi.md#domaingettopleveldomainfromurl) | **POST** /validate/domain/url/get-top-level-domain | Get top-level domain name from URL
[**DomainIsAdminPath**](DomainApi.md#domainisadminpath) | **POST** /validate/domain/url/is-admin-path | Check if path is a high-risk or vulnerable server administration path
[**DomainPhishingCheck**](DomainApi.md#domainphishingcheck) | **POST** /validate/domain/url/phishing-threat-check | Check a URL for Phishing threats
[**DomainPost**](DomainApi.md#domainpost) | **POST** /validate/domain/whois | Get WHOIS information for a domain
[**DomainQualityScore**](DomainApi.md#domainqualityscore) | **POST** /validate/domain/quality-score | Validate a domain name&#39;s quality score
[**DomainSafetyCheck**](DomainApi.md#domainsafetycheck) | **POST** /validate/domain/url/safety-threat-check | Check a URL for safety threats
[**DomainSsrfCheck**](DomainApi.md#domainssrfcheck) | **POST** /validate/domain/url/ssrf-threat-check | Check a URL for SSRF threats
[**DomainSsrfCheckBatch**](DomainApi.md#domainssrfcheckbatch) | **POST** /validate/domain/url/ssrf-threat-check/batch | Check a URL for SSRF threats in batches
[**DomainUrlFull**](DomainApi.md#domainurlfull) | **POST** /validate/domain/url/full | Validate a URL fully
[**DomainUrlHtmlSsrfCheck**](DomainApi.md#domainurlhtmlssrfcheck) | **POST** /validate/domain/url/ssrf-threat-check/html-embedded | Check a URL for HTML embedded SSRF threats
[**DomainUrlSyntaxOnly**](DomainApi.md#domainurlsyntaxonly) | **POST** /validate/domain/url/syntax-only | Validate a URL syntactically


<a name="domaincheck"></a>
# **DomainCheck**
> CheckResponse DomainCheck (string domain)

Validate a domain name

Check whether a domain name is valid or not.  API performs a live validation by contacting DNS services to validate the existence of the domain name.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainCheckExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var domain = domain_example;  // string | Domain name to check, for example \"cloudmersive.com\".  The input is a string so be sure to enclose it in double-quotes.

            try
            {
                // Validate a domain name
                CheckResponse result = apiInstance.DomainCheck(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| Domain name to check, for example \&quot;cloudmersive.com\&quot;.  The input is a string so be sure to enclose it in double-quotes. | 

### Return type

[**CheckResponse**](CheckResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domaingettopleveldomainfromurl"></a>
# **DomainGetTopLevelDomainFromUrl**
> ValidateUrlResponseSyntaxOnly DomainGetTopLevelDomainFromUrl (ValidateUrlRequestSyntaxOnly request)

Get top-level domain name from URL

Gets the top-level domain name from a URL, such as mydomain.com.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainGetTopLevelDomainFromUrlExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new ValidateUrlRequestSyntaxOnly(); // ValidateUrlRequestSyntaxOnly | Input URL information

            try
            {
                // Get top-level domain name from URL
                ValidateUrlResponseSyntaxOnly result = apiInstance.DomainGetTopLevelDomainFromUrl(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainGetTopLevelDomainFromUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ValidateUrlRequestSyntaxOnly**](ValidateUrlRequestSyntaxOnly.md)| Input URL information | 

### Return type

[**ValidateUrlResponseSyntaxOnly**](ValidateUrlResponseSyntaxOnly.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainisadminpath"></a>
# **DomainIsAdminPath**
> IsAdminPathResponse DomainIsAdminPath (string value)

Check if path is a high-risk or vulnerable server administration path

Check if the input URL or relative path is a server Administration Path, and therefore a risk or vulnerability for remote access.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainIsAdminPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var value = value_example;  // string | URL or relative path to check, e.g. \"/admin/login\".  The input is a string so be sure to enclose it in double-quotes.

            try
            {
                // Check if path is a high-risk or vulnerable server administration path
                IsAdminPathResponse result = apiInstance.DomainIsAdminPath(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainIsAdminPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**| URL or relative path to check, e.g. \&quot;/admin/login\&quot;.  The input is a string so be sure to enclose it in double-quotes. | 

### Return type

[**IsAdminPathResponse**](IsAdminPathResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainphishingcheck"></a>
# **DomainPhishingCheck**
> PhishingCheckResponse DomainPhishingCheck (PhishingCheckRequest request)

Check a URL for Phishing threats

Checks if an input URL is at risk of being an Phishing (fake login page, or other page designed to collect information via social engineering) threat or attack.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainPhishingCheckExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new PhishingCheckRequest(); // PhishingCheckRequest | Input URL request

            try
            {
                // Check a URL for Phishing threats
                PhishingCheckResponse result = apiInstance.DomainPhishingCheck(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainPhishingCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PhishingCheckRequest**](PhishingCheckRequest.md)| Input URL request | 

### Return type

[**PhishingCheckResponse**](PhishingCheckResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainpost"></a>
# **DomainPost**
> WhoisResponse DomainPost (string domain)

Get WHOIS information for a domain

Validate whether a domain name exists, and also return the full WHOIS record for that domain name.  WHOIS records include all the registration details of the domain name, such as information about the domain's owners.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainPostExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var domain = domain_example;  // string | Domain name to check, for example \"cloudmersive.com\".   The input is a string so be sure to enclose it in double-quotes.

            try
            {
                // Get WHOIS information for a domain
                WhoisResponse result = apiInstance.DomainPost(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| Domain name to check, for example \&quot;cloudmersive.com\&quot;.   The input is a string so be sure to enclose it in double-quotes. | 

### Return type

[**WhoisResponse**](WhoisResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainqualityscore"></a>
# **DomainQualityScore**
> DomainQualityResponse DomainQualityScore (string domain)

Validate a domain name's quality score

Check the quality of a domain name.  Supports over 9 million domain names.  Higher quality scores indicate more trust and authority in the domain name, with values ranging from 0.0 (low quality) to 10.0 (maximum quality).

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainQualityScoreExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var domain = domain_example;  // string | Domain name to check, for example \"cloudmersive.com\".

            try
            {
                // Validate a domain name's quality score
                DomainQualityResponse result = apiInstance.DomainQualityScore(domain);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainQualityScore: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| Domain name to check, for example \&quot;cloudmersive.com\&quot;. | 

### Return type

[**DomainQualityResponse**](DomainQualityResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainsafetycheck"></a>
# **DomainSafetyCheck**
> UrlSafetyCheckResponseFull DomainSafetyCheck (UrlSafetyCheckRequestFull request)

Check a URL for safety threats

Checks if an input URL is at risk of being a safety threat through malware, unwanted software, or social engineering threats.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainSafetyCheckExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new UrlSafetyCheckRequestFull(); // UrlSafetyCheckRequestFull | Input URL request

            try
            {
                // Check a URL for safety threats
                UrlSafetyCheckResponseFull result = apiInstance.DomainSafetyCheck(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainSafetyCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UrlSafetyCheckRequestFull**](UrlSafetyCheckRequestFull.md)| Input URL request | 

### Return type

[**UrlSafetyCheckResponseFull**](UrlSafetyCheckResponseFull.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainssrfcheck"></a>
# **DomainSsrfCheck**
> UrlSsrfResponseFull DomainSsrfCheck (UrlSsrfRequestFull request)

Check a URL for SSRF threats

Checks if an input URL is at risk of being an SSRF (Server-side request forgery) threat or attack.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainSsrfCheckExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new UrlSsrfRequestFull(); // UrlSsrfRequestFull | Input URL request

            try
            {
                // Check a URL for SSRF threats
                UrlSsrfResponseFull result = apiInstance.DomainSsrfCheck(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainSsrfCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UrlSsrfRequestFull**](UrlSsrfRequestFull.md)| Input URL request | 

### Return type

[**UrlSsrfResponseFull**](UrlSsrfResponseFull.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainssrfcheckbatch"></a>
# **DomainSsrfCheckBatch**
> UrlSsrfResponseBatch DomainSsrfCheckBatch (UrlSsrfRequestBatch request)

Check a URL for SSRF threats in batches

Batch-checks if input URLs are at risk of being an SSRF (Server-side request forgery) threat or attack.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainSsrfCheckBatchExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new UrlSsrfRequestBatch(); // UrlSsrfRequestBatch | Input URL request as a batch of multiple URLs

            try
            {
                // Check a URL for SSRF threats in batches
                UrlSsrfResponseBatch result = apiInstance.DomainSsrfCheckBatch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainSsrfCheckBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UrlSsrfRequestBatch**](UrlSsrfRequestBatch.md)| Input URL request as a batch of multiple URLs | 

### Return type

[**UrlSsrfResponseBatch**](UrlSsrfResponseBatch.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainurlfull"></a>
# **DomainUrlFull**
> ValidateUrlResponseFull DomainUrlFull (ValidateUrlRequestFull request)

Validate a URL fully

Validate whether a URL is syntactically valid (does not check endpoint for validity), whether it exists, and whether the endpoint is up and passes virus scan checks.  Accepts various types of input and produces a well-formed URL as output.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainUrlFullExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new ValidateUrlRequestFull(); // ValidateUrlRequestFull | Input URL request

            try
            {
                // Validate a URL fully
                ValidateUrlResponseFull result = apiInstance.DomainUrlFull(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainUrlFull: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ValidateUrlRequestFull**](ValidateUrlRequestFull.md)| Input URL request | 

### Return type

[**ValidateUrlResponseFull**](ValidateUrlResponseFull.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainurlhtmlssrfcheck"></a>
# **DomainUrlHtmlSsrfCheck**
> UrlHtmlSsrfResponseFull DomainUrlHtmlSsrfCheck (UrlHtmlSsrfRequestFull request)

Check a URL for HTML embedded SSRF threats

Checks if an input URL HTML is at risk of containing one or more embedded SSRF (Server-side request forgery) threats or attacks.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainUrlHtmlSsrfCheckExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new UrlHtmlSsrfRequestFull(); // UrlHtmlSsrfRequestFull | Input URL request

            try
            {
                // Check a URL for HTML embedded SSRF threats
                UrlHtmlSsrfResponseFull result = apiInstance.DomainUrlHtmlSsrfCheck(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainUrlHtmlSsrfCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**UrlHtmlSsrfRequestFull**](UrlHtmlSsrfRequestFull.md)| Input URL request | 

### Return type

[**UrlHtmlSsrfResponseFull**](UrlHtmlSsrfResponseFull.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="domainurlsyntaxonly"></a>
# **DomainUrlSyntaxOnly**
> ValidateUrlResponseSyntaxOnly DomainUrlSyntaxOnly (ValidateUrlRequestSyntaxOnly request)

Validate a URL syntactically

Validate whether a URL is syntactically valid (does not check endpoint for validity).  Accepts various types of input and produces a well-formed URL as output.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DomainUrlSyntaxOnlyExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DomainApi();
            var request = new ValidateUrlRequestSyntaxOnly(); // ValidateUrlRequestSyntaxOnly | Input URL information

            try
            {
                // Validate a URL syntactically
                ValidateUrlResponseSyntaxOnly result = apiInstance.DomainUrlSyntaxOnly(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DomainUrlSyntaxOnly: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ValidateUrlRequestSyntaxOnly**](ValidateUrlRequestSyntaxOnly.md)| Input URL information | 

### Return type

[**ValidateUrlResponseSyntaxOnly**](ValidateUrlResponseSyntaxOnly.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

