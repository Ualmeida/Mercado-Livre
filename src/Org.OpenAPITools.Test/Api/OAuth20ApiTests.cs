/* 
 * MELI Markeplace SDK
 *
 * This is a the codebase to generate a SDK for Open Platform Marketplace
 *
 * The version of the OpenAPI document: 0.0.11
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing OAuth20Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OAuth20ApiTests : IDisposable
    {
        private OAuth20Api instance;

        public OAuth20ApiTests()
        {
            instance = new OAuth20Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OAuth20Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OAuth20Api
            //Assert.IsType(typeof(OAuth20Api), instance, "instance is a OAuth20Api");
        }

        
        /// <summary>
        /// Test Auth
        /// </summary>
        [Fact]
        public void AuthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string responseType = null;
            //string clientId = null;
            //string redirectUri = null;
            //instance.Auth(responseType, clientId, redirectUri);
            
        }
        
        /// <summary>
        /// Test GetToken
        /// </summary>
        [Fact]
        public void GetTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string grantType = null;
            //string clientId = null;
            //string clientSecret = null;
            //string redirectUri = null;
            //string code = null;
            //string refreshToken = null;
            //var response = instance.GetToken(grantType, clientId, clientSecret, redirectUri, code, refreshToken);
            //Assert.IsType<Token> (response, "response is Token");
        }
        
    }

}
