# Cloudmersive.APIClient.NET.Validate.Api.NameApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NameGetGender**](NameApi.md#namegetgender) | **POST** /validate/name/get-gender | Get the gender of a first name
[**NameValidateFirstName**](NameApi.md#namevalidatefirstname) | **POST** /validate/name/first | Validate a first name
[**NameValidateFullName**](NameApi.md#namevalidatefullname) | **POST** /validate/name/full-name | Parse and validate a full name
[**NameValidateLastName**](NameApi.md#namevalidatelastname) | **POST** /validate/name/last | Validate a last name


<a name="namegetgender"></a>
# **NameGetGender**
> GetGenderResponse NameGetGender (GetGenderRequest input)

Get the gender of a first name

Determines the gender of a first name (given name)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class NameGetGenderExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NameApi();
            var input = new GetGenderRequest(); // GetGenderRequest | Gender request information

            try
            {
                // Get the gender of a first name
                GetGenderResponse result = apiInstance.NameGetGender(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NameApi.NameGetGender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**GetGenderRequest**](GetGenderRequest.md)| Gender request information | 

### Return type

[**GetGenderResponse**](GetGenderResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="namevalidatefirstname"></a>
# **NameValidateFirstName**
> FirstNameValidationResponse NameValidateFirstName (FirstNameValidationRequest input)

Validate a first name

Determines if a string is a valid first name (given name)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class NameValidateFirstNameExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NameApi();
            var input = new FirstNameValidationRequest(); // FirstNameValidationRequest | Validation request information

            try
            {
                // Validate a first name
                FirstNameValidationResponse result = apiInstance.NameValidateFirstName(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NameApi.NameValidateFirstName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**FirstNameValidationRequest**](FirstNameValidationRequest.md)| Validation request information | 

### Return type

[**FirstNameValidationResponse**](FirstNameValidationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="namevalidatefullname"></a>
# **NameValidateFullName**
> FullNameValidationResponse NameValidateFullName (FullNameValidationRequest input)

Parse and validate a full name

Parses a full name string (e.g. \"Mr. Jon van der Waal Jr.\") into its component parts (and returns these component parts), and then validates whether it is a valid name string or not

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class NameValidateFullNameExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NameApi();
            var input = new FullNameValidationRequest(); // FullNameValidationRequest | Validation request information

            try
            {
                // Parse and validate a full name
                FullNameValidationResponse result = apiInstance.NameValidateFullName(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NameApi.NameValidateFullName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**FullNameValidationRequest**](FullNameValidationRequest.md)| Validation request information | 

### Return type

[**FullNameValidationResponse**](FullNameValidationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="namevalidatelastname"></a>
# **NameValidateLastName**
> LastNameValidationResponse NameValidateLastName (LastNameValidationRequest input)

Validate a last name

Determines if a string is a valid last name (surname)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Example
{
    public class NameValidateLastNameExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new NameApi();
            var input = new LastNameValidationRequest(); // LastNameValidationRequest | Validation request information

            try
            {
                // Validate a last name
                LastNameValidationResponse result = apiInstance.NameValidateLastName(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NameApi.NameValidateLastName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**LastNameValidationRequest**](LastNameValidationRequest.md)| Validation request information | 

### Return type

[**LastNameValidationResponse**](LastNameValidationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

