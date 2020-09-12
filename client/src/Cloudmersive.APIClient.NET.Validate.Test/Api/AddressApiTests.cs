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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.Validate.Client;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Model;

namespace Cloudmersive.APIClient.NET.Validate.Test
{
    /// <summary>
    ///  Class for testing AddressApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressApiTests
    {
        private AddressApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AddressApi
            //Assert.IsInstanceOfType(typeof(AddressApi), instance, "instance is a AddressApi");
        }

        
        /// <summary>
        /// Test AddressCheckEUMembership
        /// </summary>
        [Test]
        public void AddressCheckEUMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateCountryRequest input = null;
            //var response = instance.AddressCheckEUMembership(input);
            //Assert.IsInstanceOf<ValidateCountryResponse> (response, "response is ValidateCountryResponse");
        }
        
        /// <summary>
        /// Test AddressCountry
        /// </summary>
        [Test]
        public void AddressCountryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateCountryRequest input = null;
            //var response = instance.AddressCountry(input);
            //Assert.IsInstanceOf<ValidateCountryResponse> (response, "response is ValidateCountryResponse");
        }
        
        /// <summary>
        /// Test AddressCountryList
        /// </summary>
        [Test]
        public void AddressCountryListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AddressCountryList();
            //Assert.IsInstanceOf<CountryListResult> (response, "response is CountryListResult");
        }
        
        /// <summary>
        /// Test AddressGetCountryCurrency
        /// </summary>
        [Test]
        public void AddressGetCountryCurrencyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateCountryRequest input = null;
            //var response = instance.AddressGetCountryCurrency(input);
            //Assert.IsInstanceOf<ValidateCountryResponse> (response, "response is ValidateCountryResponse");
        }
        
        /// <summary>
        /// Test AddressGetTimezone
        /// </summary>
        [Test]
        public void AddressGetTimezoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetTimezonesRequest input = null;
            //var response = instance.AddressGetTimezone(input);
            //Assert.IsInstanceOf<GetTimezonesResponse> (response, "response is GetTimezonesResponse");
        }
        
        /// <summary>
        /// Test AddressParseString
        /// </summary>
        [Test]
        public void AddressParseStringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ParseAddressRequest input = null;
            //var response = instance.AddressParseString(input);
            //Assert.IsInstanceOf<ParseAddressResponse> (response, "response is ParseAddressResponse");
        }
        
        /// <summary>
        /// Test AddressValidateAddress
        /// </summary>
        [Test]
        public void AddressValidateAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateAddressRequest input = null;
            //var response = instance.AddressValidateAddress(input);
            //Assert.IsInstanceOf<ValidateAddressResponse> (response, "response is ValidateAddressResponse");
        }
        
        /// <summary>
        /// Test AddressValidateCity
        /// </summary>
        [Test]
        public void AddressValidateCityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateCityRequest input = null;
            //var response = instance.AddressValidateCity(input);
            //Assert.IsInstanceOf<ValidateCityResponse> (response, "response is ValidateCityResponse");
        }
        
        /// <summary>
        /// Test AddressValidatePostalCode
        /// </summary>
        [Test]
        public void AddressValidatePostalCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidatePostalCodeRequest input = null;
            //var response = instance.AddressValidatePostalCode(input);
            //Assert.IsInstanceOf<ValidatePostalCodeResponse> (response, "response is ValidatePostalCodeResponse");
        }
        
        /// <summary>
        /// Test AddressValidateState
        /// </summary>
        [Test]
        public void AddressValidateStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateStateRequest input = null;
            //var response = instance.AddressValidateState(input);
            //Assert.IsInstanceOf<ValidateStateResponse> (response, "response is ValidateStateResponse");
        }
        
    }

}
