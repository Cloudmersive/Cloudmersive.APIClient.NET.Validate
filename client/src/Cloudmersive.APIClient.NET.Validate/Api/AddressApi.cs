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
    public interface IAddressApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Parse an unstructured input text string into an international, formatted address
        /// </summary>
        /// <remarks>
        /// Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>ParseAddressResponse</returns>
        ParseAddressResponse AddressParseString (ParseAddressRequest input);

        /// <summary>
        /// Parse an unstructured input text string into an international, formatted address
        /// </summary>
        /// <remarks>
        /// Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>ApiResponse of ParseAddressResponse</returns>
        ApiResponse<ParseAddressResponse> AddressParseStringWithHttpInfo (ParseAddressRequest input);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Parse an unstructured input text string into an international, formatted address
        /// </summary>
        /// <remarks>
        /// Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>Task of ParseAddressResponse</returns>
        System.Threading.Tasks.Task<ParseAddressResponse> AddressParseStringAsync (ParseAddressRequest input);

        /// <summary>
        /// Parse an unstructured input text string into an international, formatted address
        /// </summary>
        /// <remarks>
        /// Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>Task of ApiResponse (ParseAddressResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParseAddressResponse>> AddressParseStringAsyncWithHttpInfo (ParseAddressRequest input);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddressApi : IAddressApi
    {
        private Cloudmersive.APIClient.NET.Validate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NET.Validate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NET.Validate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddressApi(Cloudmersive.APIClient.NET.Validate.Client.Configuration configuration = null)
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
        /// Parse an unstructured input text string into an international, formatted address Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>ParseAddressResponse</returns>
        public ParseAddressResponse AddressParseString (ParseAddressRequest input)
        {
             ApiResponse<ParseAddressResponse> localVarResponse = AddressParseStringWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Parse an unstructured input text string into an international, formatted address Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>ApiResponse of ParseAddressResponse</returns>
        public ApiResponse< ParseAddressResponse > AddressParseStringWithHttpInfo (ParseAddressRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling AddressApi->AddressParseString");

            var localVarPath = "/validate/address/parse";
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
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
                Exception exception = ExceptionFactory("AddressParseString", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ParseAddressResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParseAddressResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParseAddressResponse)));
        }

        /// <summary>
        /// Parse an unstructured input text string into an international, formatted address Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>Task of ParseAddressResponse</returns>
        public async System.Threading.Tasks.Task<ParseAddressResponse> AddressParseStringAsync (ParseAddressRequest input)
        {
             ApiResponse<ParseAddressResponse> localVarResponse = await AddressParseStringAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Parse an unstructured input text string into an international, formatted address Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NET.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input parse request</param>
        /// <returns>Task of ApiResponse (ParseAddressResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParseAddressResponse>> AddressParseStringAsyncWithHttpInfo (ParseAddressRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling AddressApi->AddressParseString");

            var localVarPath = "/validate/address/parse";
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

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
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
                Exception exception = ExceptionFactory("AddressParseString", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ParseAddressResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParseAddressResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParseAddressResponse)));
        }

    }
}
