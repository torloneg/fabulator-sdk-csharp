/* 
 * Fabulator API
 *
 * Endpoint Fabulator project
 *
 * OpenAPI spec version: 1.0.0
 * Contact: torloneg@gmail.com
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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing RuleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RuleApiTests
    {
        private RuleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RuleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RuleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RuleApi
            //Assert.IsInstanceOfType(typeof(RuleApi), instance, "instance is a RuleApi");
        }

        
        /// <summary>
        /// Test DeleteRuleV1Id
        /// </summary>
        [Test]
        public void DeleteRuleV1IdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DeleteRuleV1Id(id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetRuleV1InfoId
        /// </summary>
        [Test]
        public void GetRuleV1InfoIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetRuleV1InfoId(id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PatchRuleV1UpdateIdFieldValue
        /// </summary>
        [Test]
        public void PatchRuleV1UpdateIdFieldValueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string field = null;
            //string value = null;
            //var response = instance.PatchRuleV1UpdateIdFieldValue(id, field, value);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostRuleV1AddIddomain
        /// </summary>
        [Test]
        public void PostRuleV1AddIddomainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iddomain = null;
            //Model6 body = null;
            //var response = instance.PostRuleV1AddIddomain(iddomain, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostRuleV1QueryIddomainSkipLimit
        /// </summary>
        [Test]
        public void PostRuleV1QueryIddomainSkipLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string iddomain = null;
            //decimal? skip = null;
            //decimal? limit = null;
            //Model9 body = null;
            //var response = instance.PostRuleV1QueryIddomainSkipLimit(iddomain, skip, limit, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PutRuleV1UpdateIddomainId
        /// </summary>
        [Test]
        public void PutRuleV1UpdateIddomainIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string iddomain = null;
            //Model6 body = null;
            //var response = instance.PutRuleV1UpdateIddomainId(id, iddomain, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
