using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILockRecordApi
    {
        /// <summary>
        /// Paginates the {LockRecord}s. 
        /// </summary>
        /// <param name="paginate">The paginate.</param>
        /// <returns>PaginationResultsLockRecord</returns>
        PaginationResultsLockRecord Paginate (BaseRequestPaginateLockRecord paginate);
        /// <summary>
        /// Retrieves the specified identifier. 
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>LockRecord</returns>
        LockRecord Retrieve (BaseRequestString id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LockRecordApi : ILockRecordApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockRecordApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LockRecordApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LockRecordApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LockRecordApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Paginates the {LockRecord}s. 
        /// </summary>
        /// <param name="paginate">The paginate.</param> 
        /// <returns>PaginationResultsLockRecord</returns>            
        public PaginationResultsLockRecord Paginate (BaseRequestPaginateLockRecord paginate)
        {
            
    
            var path = "/api/LockRecord/Paginate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(paginate); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Paginate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Paginate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginationResultsLockRecord) ApiClient.Deserialize(response.Content, typeof(PaginationResultsLockRecord), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the specified identifier. 
        /// </summary>
        /// <param name="id">The identifier.</param> 
        /// <returns>LockRecord</returns>            
        public LockRecord Retrieve (BaseRequestString id)
        {
            
    
            var path = "/api/LockRecord/Retrieve";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(id); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LockRecord) ApiClient.Deserialize(response.Content, typeof(LockRecord), response.Headers);
        }
    
    }
}
