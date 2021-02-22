/* 
 * validateapi
 *
 * The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Cloudmersive.APIClient.NET.Validate.Api;
using Cloudmersive.APIClient.NET.Validate.Model;
using Cloudmersive.APIClient.NET.Validate.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Cloudmersive.APIClient.NET.Validate.Test
{
    /// <summary>
    ///  Class for testing PhishingCheckResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PhishingCheckResponseTests
    {
        // TODO uncomment below to declare an instance variable for PhishingCheckResponse
        //private PhishingCheckResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PhishingCheckResponse
            //instance = new PhishingCheckResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PhishingCheckResponse
        /// </summary>
        [Test]
        public void PhishingCheckResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PhishingCheckResponse
            //Assert.IsInstanceOfType<PhishingCheckResponse> (instance, "variable 'instance' is a PhishingCheckResponse");
        }


        /// <summary>
        /// Test the property 'CleanURL'
        /// </summary>
        [Test]
        public void CleanURLTest()
        {
            // TODO unit test for the property 'CleanURL'
        }
        /// <summary>
        /// Test the property 'ThreatType'
        /// </summary>
        [Test]
        public void ThreatTypeTest()
        {
            // TODO unit test for the property 'ThreatType'
        }

    }

}
