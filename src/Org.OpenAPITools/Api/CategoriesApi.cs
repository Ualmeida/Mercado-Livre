/* 
 * MELI Markeplace SDK
 *
 * This is a the codebase to generate a SDK for Open Platform Marketplace
 *
 * The version of the OpenAPI document: 0.0.13
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICategoriesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Return by category.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        void CategoriesCategoryIdGet (string categoryId);

        /// <summary>
        /// Return by category.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> CategoriesCategoryIdGetWithHttpInfo (string categoryId);
        /// <summary>
        /// Return a categories by site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns></returns>
        void SitesSiteIdCategoriesGet (string siteId);

        /// <summary>
        /// Return a categories by site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SitesSiteIdCategoriesGetWithHttpInfo (string siteId);
        /// <summary>
        /// Predictor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        void SitesSiteIdDomainDiscoverySearchGet (string siteId, string q, string limit);

        /// <summary>
        /// Predictor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SitesSiteIdDomainDiscoverySearchGetWithHttpInfo (string siteId, string q, string limit);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICategoriesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Return by category.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CategoriesCategoryIdGetAsync (string categoryId);

        /// <summary>
        /// Return by category.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CategoriesCategoryIdGetAsyncWithHttpInfo (string categoryId);
        /// <summary>
        /// Return a categories by site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SitesSiteIdCategoriesGetAsync (string siteId);

        /// <summary>
        /// Return a categories by site.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SitesSiteIdCategoriesGetAsyncWithHttpInfo (string siteId);
        /// <summary>
        /// Predictor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SitesSiteIdDomainDiscoverySearchGetAsync (string siteId, string q, string limit);

        /// <summary>
        /// Predictor
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SitesSiteIdDomainDiscoverySearchGetAsyncWithHttpInfo (string siteId, string q, string limit);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICategoriesApi : ICategoriesApiSync, ICategoriesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CategoriesApi : ICategoriesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CategoriesApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CategoriesApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CategoriesApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CategoriesApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        /// Return by category. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public void CategoriesCategoryIdGet (string categoryId)
        {
             CategoriesCategoryIdGetWithHttpInfo(categoryId);
        }

        /// <summary>
        /// Return by category. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> CategoriesCategoryIdGetWithHttpInfo (string categoryId)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'categoryId' when calling CategoriesApi->CategoriesCategoryIdGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (categoryId != null)
                localVarRequestOptions.PathParameters.Add("category_id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(categoryId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/categories/{category_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CategoriesCategoryIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return by category. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task CategoriesCategoryIdGetAsync (string categoryId)
        {
             await CategoriesCategoryIdGetAsyncWithHttpInfo(categoryId);

        }

        /// <summary>
        /// Return by category. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> CategoriesCategoryIdGetAsyncWithHttpInfo (string categoryId)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'categoryId' when calling CategoriesApi->CategoriesCategoryIdGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (categoryId != null)
                localVarRequestOptions.PathParameters.Add("category_id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(categoryId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/categories/{category_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CategoriesCategoryIdGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return a categories by site. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns></returns>
        public void SitesSiteIdCategoriesGet (string siteId)
        {
             SitesSiteIdCategoriesGetWithHttpInfo(siteId);
        }

        /// <summary>
        /// Return a categories by site. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> SitesSiteIdCategoriesGetWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'siteId' when calling CategoriesApi->SitesSiteIdCategoriesGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (siteId != null)
                localVarRequestOptions.PathParameters.Add("site_id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(siteId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/sites/{site_id}/categories", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SitesSiteIdCategoriesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return a categories by site. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SitesSiteIdCategoriesGetAsync (string siteId)
        {
             await SitesSiteIdCategoriesGetAsyncWithHttpInfo(siteId);

        }

        /// <summary>
        /// Return a categories by site. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> SitesSiteIdCategoriesGetAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'siteId' when calling CategoriesApi->SitesSiteIdCategoriesGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (siteId != null)
                localVarRequestOptions.PathParameters.Add("site_id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(siteId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/sites/{site_id}/categories", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SitesSiteIdCategoriesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Predictor 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public void SitesSiteIdDomainDiscoverySearchGet (string siteId, string q, string limit)
        {
             SitesSiteIdDomainDiscoverySearchGetWithHttpInfo(siteId, q, limit);
        }

        /// <summary>
        /// Predictor 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> SitesSiteIdDomainDiscoverySearchGetWithHttpInfo (string siteId, string q, string limit)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'siteId' when calling CategoriesApi->SitesSiteIdDomainDiscoverySearchGet");

            // verify the required parameter 'q' is set
            if (q == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'q' when calling CategoriesApi->SitesSiteIdDomainDiscoverySearchGet");

            // verify the required parameter 'limit' is set
            if (limit == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'limit' when calling CategoriesApi->SitesSiteIdDomainDiscoverySearchGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (siteId != null)
                localVarRequestOptions.PathParameters.Add("site_id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(siteId)); // path parameter
            if (q != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "q", q));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/sites/{site_id}/domain_discovery/search", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SitesSiteIdDomainDiscoverySearchGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Predictor 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SitesSiteIdDomainDiscoverySearchGetAsync (string siteId, string q, string limit)
        {
             await SitesSiteIdDomainDiscoverySearchGetAsyncWithHttpInfo(siteId, q, limit);

        }

        /// <summary>
        /// Predictor 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> SitesSiteIdDomainDiscoverySearchGetAsyncWithHttpInfo (string siteId, string q, string limit)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'siteId' when calling CategoriesApi->SitesSiteIdDomainDiscoverySearchGet");

            // verify the required parameter 'q' is set
            if (q == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'q' when calling CategoriesApi->SitesSiteIdDomainDiscoverySearchGet");

            // verify the required parameter 'limit' is set
            if (limit == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'limit' when calling CategoriesApi->SitesSiteIdDomainDiscoverySearchGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (siteId != null)
                localVarRequestOptions.PathParameters.Add("site_id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(siteId)); // path parameter
            if (q != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "q", q));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/sites/{site_id}/domain_discovery/search", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SitesSiteIdDomainDiscoverySearchGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
