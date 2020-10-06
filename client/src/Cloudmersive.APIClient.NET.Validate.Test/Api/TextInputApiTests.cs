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
    ///  Class for testing TextInputApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TextInputApiTests
    {
        private TextInputApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TextInputApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TextInputApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TextInputApi
            //Assert.IsInstanceOfType(typeof(TextInputApi), instance, "instance is a TextInputApi");
        }

        
        /// <summary>
        /// Test TextInputCheckXss
        /// </summary>
        [Test]
        public void TextInputCheckXssTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string value = null;
            //var response = instance.TextInputCheckXss(value);
            //Assert.IsInstanceOf<XssProtectionResult> (response, "response is XssProtectionResult");
        }
        
        /// <summary>
        /// Test TextInputProtectXss
        /// </summary>
        [Test]
        public void TextInputProtectXssTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string value = null;
            //var response = instance.TextInputProtectXss(value);
            //Assert.IsInstanceOf<XssProtectionResult> (response, "response is XssProtectionResult");
        }
        
    }

}
