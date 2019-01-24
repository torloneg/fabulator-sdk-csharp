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
    ///  Class for testing SchemaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SchemaApiTests
    {
        private SchemaApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SchemaApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SchemaApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SchemaApi
            //Assert.IsInstanceOfType(typeof(SchemaApi), instance, "instance is a SchemaApi");
        }

        
        /// <summary>
        /// Test GetSchemaV1InfoId
        /// </summary>
        [Test]
        public void GetSchemaV1InfoIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetSchemaV1InfoId(id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostSchemaV1GroupType
        /// </summary>
        [Test]
        public void PostSchemaV1GroupTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //var response = instance.PostSchemaV1GroupType(type);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostSchemaV1QuerySkipLimit
        /// </summary>
        [Test]
        public void PostSchemaV1QuerySkipLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? skip = null;
            //decimal? limit = null;
            //Model11 body = null;
            //var response = instance.PostSchemaV1QuerySkipLimit(skip, limit, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
