# Cloudmersive.APIClient.NET.Validate.Api.DateTimeApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DateTimeGetNowSimple**](DateTimeApi.md#datetimegetnowsimple) | **GET** /validate/date-time/get/now | Get current date and time as of now
[**DateTimeGetPublicHolidays**](DateTimeApi.md#datetimegetpublicholidays) | **POST** /validate/date-time/get/holidays | Get public holidays in the specified country and year
[**DateTimeParseNaturalLanguageDateTime**](DateTimeApi.md#datetimeparsenaturallanguagedatetime) | **POST** /validate/date-time/parse/date-time/natural-language | Parses a free-form natural language date and time string into a date and time
[**DateTimeParseStandardDateTime**](DateTimeApi.md#datetimeparsestandarddatetime) | **POST** /validate/date-time/parse/date-time/structured | Parses a standardized date and time string into a date and time


<a name="datetimegetnowsimple"></a>
# **DateTimeGetNowSimple**
> DateTimeNowResult DateTimeGetNowSimple ()

Get current date and time as of now

Gets the current date and time.  Response time is syncronized with atomic clocks, and represents a monotonic, centrally available, consistent clock.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DateTimeGetNowSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DateTimeApi();

            try
            {
                // Get current date and time as of now
                DateTimeNowResult result = apiInstance.DateTimeGetNowSimple();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DateTimeApi.DateTimeGetNowSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DateTimeNowResult**](DateTimeNowResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datetimegetpublicholidays"></a>
# **DateTimeGetPublicHolidays**
> PublicHolidaysResponse DateTimeGetPublicHolidays (GetPublicHolidaysRequest input)

Get public holidays in the specified country and year

Enumerates all public holidays in a given country for a given year.  Supports over 100 countries.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DateTimeGetPublicHolidaysExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DateTimeApi();
            var input = new GetPublicHolidaysRequest(); // GetPublicHolidaysRequest | Input request

            try
            {
                // Get public holidays in the specified country and year
                PublicHolidaysResponse result = apiInstance.DateTimeGetPublicHolidays(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DateTimeApi.DateTimeGetPublicHolidays: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**GetPublicHolidaysRequest**](GetPublicHolidaysRequest.md)| Input request | 

### Return type

[**PublicHolidaysResponse**](PublicHolidaysResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datetimeparsenaturallanguagedatetime"></a>
# **DateTimeParseNaturalLanguageDateTime**
> DateTimeStandardizedParseResponse DateTimeParseNaturalLanguageDateTime (DateTimeNaturalLanguageParseRequest input)

Parses a free-form natural language date and time string into a date and time

Parses an unstructured, free-form, natural language date and time string into a date time object.  This is intended for lightweight human-entered input, such as \"tomorrow at 3pm\" or \"tuesday\".

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DateTimeParseNaturalLanguageDateTimeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DateTimeApi();
            var input = new DateTimeNaturalLanguageParseRequest(); // DateTimeNaturalLanguageParseRequest | Input request

            try
            {
                // Parses a free-form natural language date and time string into a date and time
                DateTimeStandardizedParseResponse result = apiInstance.DateTimeParseNaturalLanguageDateTime(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DateTimeApi.DateTimeParseNaturalLanguageDateTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DateTimeNaturalLanguageParseRequest**](DateTimeNaturalLanguageParseRequest.md)| Input request | 

### Return type

[**DateTimeStandardizedParseResponse**](DateTimeStandardizedParseResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="datetimeparsestandarddatetime"></a>
# **DateTimeParseStandardDateTime**
> DateTimeStandardizedParseResponse DateTimeParseStandardDateTime (DateTimeStandardizedParseRequest input)

Parses a standardized date and time string into a date and time

Parses a structured date and time string into a date time object.  This is intended for standardized date strings that adhere to formatting conventions, rather than natural language input.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class DateTimeParseStandardDateTimeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new DateTimeApi();
            var input = new DateTimeStandardizedParseRequest(); // DateTimeStandardizedParseRequest | Input request

            try
            {
                // Parses a standardized date and time string into a date and time
                DateTimeStandardizedParseResponse result = apiInstance.DateTimeParseStandardDateTime(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DateTimeApi.DateTimeParseStandardDateTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DateTimeStandardizedParseRequest**](DateTimeStandardizedParseRequest.md)| Input request | 

### Return type

[**DateTimeStandardizedParseResponse**](DateTimeStandardizedParseResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

