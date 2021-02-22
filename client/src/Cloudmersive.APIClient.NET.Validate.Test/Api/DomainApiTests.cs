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
    ///  Class for testing DomainApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DomainApiTests
    {
        private DomainApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DomainApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DomainApi
            //Assert.IsInstanceOfType(typeof(DomainApi), instance, "instance is a DomainApi");
        }

        
        /// <summary>
        /// Test DomainCheck
        /// </summary>
        [Test]
        public void DomainCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.DomainCheck(domain);
            //Assert.IsInstanceOf<CheckResponse> (response, "response is CheckResponse");
        }
        
        /// <summary>
        /// Test DomainGetTopLevelDomainFromUrl
        /// </summary>
        [Test]
        public void DomainGetTopLevelDomainFromUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateUrlRequestSyntaxOnly request = null;
            //var response = instance.DomainGetTopLevelDomainFromUrl(request);
            //Assert.IsInstanceOf<ValidateUrlResponseSyntaxOnly> (response, "response is ValidateUrlResponseSyntaxOnly");
        }
        
        /// <summary>
        /// Test DomainPhishingCheck
        /// </summary>
        [Test]
        public void DomainPhishingCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PhishingCheckRequest request = null;
            //var response = instance.DomainPhishingCheck(request);
            //Assert.IsInstanceOf<PhishingCheckResponse> (response, "response is PhishingCheckResponse");
        }
        
        /// <summary>
        /// Test DomainPost
        /// </summary>
        [Test]
        public void DomainPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.DomainPost(domain);
            //Assert.IsInstanceOf<WhoisResponse> (response, "response is WhoisResponse");
        }
        
        /// <summary>
        /// Test DomainQualityScore
        /// </summary>
        [Test]
        public void DomainQualityScoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string domain = null;
            //var response = instance.DomainQualityScore(domain);
            //Assert.IsInstanceOf<DomainQualityResponse> (response, "response is DomainQualityResponse");
        }
        
        /// <summary>
        /// Test DomainSafetyCheck
        /// </summary>
        [Test]
        public void DomainSafetyCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UrlSafetyCheckRequestFull request = null;
            //var response = instance.DomainSafetyCheck(request);
            //Assert.IsInstanceOf<UrlSafetyCheckResponseFull> (response, "response is UrlSafetyCheckResponseFull");
        }
        
        /// <summary>
        /// Test DomainSsrfCheck
        /// </summary>
        [Test]
        public void DomainSsrfCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UrlSsrfRequestFull request = null;
            //var response = instance.DomainSsrfCheck(request);
            //Assert.IsInstanceOf<UrlSsrfResponseFull> (response, "response is UrlSsrfResponseFull");
        }
        
        /// <summary>
        /// Test DomainSsrfCheckBatch
        /// </summary>
        [Test]
        public void DomainSsrfCheckBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UrlSsrfRequestBatch request = null;
            //var response = instance.DomainSsrfCheckBatch(request);
            //Assert.IsInstanceOf<UrlSsrfResponseBatch> (response, "response is UrlSsrfResponseBatch");
        }
        
        /// <summary>
        /// Test DomainUrlFull
        /// </summary>
        [Test]
        public void DomainUrlFullTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateUrlRequestFull request = null;
            //var response = instance.DomainUrlFull(request);
            //Assert.IsInstanceOf<ValidateUrlResponseFull> (response, "response is ValidateUrlResponseFull");
        }
        
        /// <summary>
        /// Test DomainUrlSyntaxOnly
        /// </summary>
        [Test]
        public void DomainUrlSyntaxOnlyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateUrlRequestSyntaxOnly request = null;
            //var response = instance.DomainUrlSyntaxOnly(request);
            //Assert.IsInstanceOf<ValidateUrlResponseSyntaxOnly> (response, "response is ValidateUrlResponseSyntaxOnly");
        }
        
    }

}
