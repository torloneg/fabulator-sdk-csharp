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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test DeleteUsersV1Id
        /// </summary>
        [Test]
        public void DeleteUsersV1IdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DeleteUsersV1Id(id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetUsersV1InfoId
        /// </summary>
        [Test]
        public void GetUsersV1InfoIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetUsersV1InfoId(id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PatchUsersV1UpdateIdFieldValue
        /// </summary>
        [Test]
        public void PatchUsersV1UpdateIdFieldValueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string field = null;
            //string value = null;
            //var response = instance.PatchUsersV1UpdateIdFieldValue(id, field, value);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostUsersV1Add
        /// </summary>
        [Test]
        public void PostUsersV1AddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Model2 body = null;
            //var response = instance.PostUsersV1Add(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostUsersV1Login
        /// </summary>
        [Test]
        public void PostUsersV1LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Model3 body = null;
            //var response = instance.PostUsersV1Login(body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostUsersV1QuerySkipLimit
        /// </summary>
        [Test]
        public void PostUsersV1QuerySkipLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? skip = null;
            //decimal? limit = null;
            //Model12 body = null;
            //var response = instance.PostUsersV1QuerySkipLimit(skip, limit, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostUsersV1ResetPasswordToken
        /// </summary>
        [Test]
        public void PostUsersV1ResetPasswordTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //Model8 body = null;
            //var response = instance.PostUsersV1ResetPasswordToken(token, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostUsersV1SendPasswordReminderEmail
        /// </summary>
        [Test]
        public void PostUsersV1SendPasswordReminderEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //var response = instance.PostUsersV1SendPasswordReminderEmail(email);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PutUsersV1UpdateId
        /// </summary>
        [Test]
        public void PutUsersV1UpdateIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Model13 body = null;
            //var response = instance.PutUsersV1UpdateId(id, body);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
