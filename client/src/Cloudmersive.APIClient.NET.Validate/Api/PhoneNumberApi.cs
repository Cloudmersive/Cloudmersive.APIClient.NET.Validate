/* 
 * validateapi
 *
 * The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Cloudmersive.APIClient.NET.Validate.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPhoneNumberApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Validate phone number (basic)
        /// </summary>
        /// <remarks>
        /// Validate a phone number by analyzing the syntax
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>PhoneNumberValidationResponse</returns>
        PhoneNumberValidationResponse PhoneNumberSyntaxOnly (PhoneNumberValidateRequest value);

        /// <summary>
        /// Validate phone number (basic)
        /// </summary>
        /// <remarks>
        /// Validate a phone number by analyzing the syntax
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>ApiResponse of PhoneNumberValidationResponse</returns>
        ApiResponse<PhoneNumberValidationResponse> PhoneNumberSyntaxOnlyWithHttpInfo (PhoneNumberValidateRequest value);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Validate phone number (basic)
        /// </summary>
        /// <remarks>
        /// Validate a phone number by analyzing the syntax
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>Task of PhoneNumberValidationResponse</returns>
        System.Threading.Tasks.Task<PhoneNumberValidationResponse> PhoneNumberSyntaxOnlyAsync (PhoneNumberValidateRequest value);

        /// <summary>
        /// Validate phone number (basic)
        /// </summary>
        /// <remarks>
        /// Validate a phone number by analyzing the syntax
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>Task of ApiResponse (PhoneNumberValidationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneNumberValidationResponse>> PhoneNumberSyntaxOnlyAsyncWithHttpInfo (PhoneNumberValidateRequest value);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PhoneNumberApi : IPhoneNumberApi
    {
        private Cloudmersive.APIClient.NET.Validate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PhoneNumberApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NET.Validate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NET.Validate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PhoneNumberApi(Cloudmersive.APIClient.NET.Validate.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Cloudmersive.APIClient.NET.Validate.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NET.Validate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Cloudmersive.APIClient.NET.Validate.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NET.Validate.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Validate phone number (basic) Validate a phone number by analyzing the syntax
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>PhoneNumberValidationResponse</returns>
        public PhoneNumberValidationResponse PhoneNumberSyntaxOnly (PhoneNumberValidateRequest value)
        {
             ApiResponse<PhoneNumberValidationResponse> localVarResponse = PhoneNumberSyntaxOnlyWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validate phone number (basic) Validate a phone number by analyzing the syntax
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>ApiResponse of PhoneNumberValidationResponse</returns>
        public ApiResponse< PhoneNumberValidationResponse > PhoneNumberSyntaxOnlyWithHttpInfo (PhoneNumberValidateRequest value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling PhoneNumberApi->PhoneNumberSyntaxOnly");

            var localVarPath = "/validate/phonenumber/basic";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (value != null && value.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneNumberSyntaxOnly", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneNumberValidationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneNumberValidationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneNumberValidationResponse)));
        }

        /// <summary>
        /// Validate phone number (basic) Validate a phone number by analyzing the syntax
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>Task of PhoneNumberValidationResponse</returns>
        public async System.Threading.Tasks.Task<PhoneNumberValidationResponse> PhoneNumberSyntaxOnlyAsync (PhoneNumberValidateRequest value)
        {
             ApiResponse<PhoneNumberValidationResponse> localVarResponse = await PhoneNumberSyntaxOnlyAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validate phone number (basic) Validate a phone number by analyzing the syntax
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">Phone number to validate in a PhoneNumberValidateRequest object.  Try a phone number such as \&quot;1.800.463.3339\&quot;, and either leave DefaultCountryCode blank or use \&quot;US\&quot;.</param>
        /// <returns>Task of ApiResponse (PhoneNumberValidationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneNumberValidationResponse>> PhoneNumberSyntaxOnlyAsyncWithHttpInfo (PhoneNumberValidateRequest value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling PhoneNumberApi->PhoneNumberSyntaxOnly");

            var localVarPath = "/validate/phonenumber/basic";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (value != null && value.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneNumberSyntaxOnly", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneNumberValidationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneNumberValidationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneNumberValidationResponse)));
        }

    }
}
