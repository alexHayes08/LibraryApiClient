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
    public interface ILockableApi
    {
        /// <summary>
        /// Locks the specified lockable. 
        /// </summary>
        /// <param name="lockRequest">The lock request.</param>
        /// <returns>LockResponse</returns>
        LockResponse Lock (BaseRequestLockRequest lockRequest);
        /// <summary>
        /// Creates the specified lockable. 
        /// </summary>
        /// <param name="lockable">The lockable.</param>
        /// <returns>Lockable</returns>
        Lockable Create (BaseRequestLockable lockable);
        /// <summary>
        /// Bulk version of create. 
        /// </summary>
        /// <param name="lockables">The lockables.</param>
        /// <returns>PaginationResultsLockable</returns>
        PaginationResultsLockable CreateMany (BaseRequestIEnumerableLockable lockables);
        /// <summary>
        /// Deletes the specified identifier. 
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>bool?</returns>
        bool? Delete (BaseRequestString id);
        /// <summary>
        /// Deletes the many. 
        /// </summary>
        /// <param name="ids">The ids.</param>
        /// <returns>bool?</returns>
        bool? DeleteMany (BaseRequestIEnumerableString ids);
        /// <summary>
        /// Paginates. 
        /// </summary>
        /// <param name="paginate">The paginate.</param>
        /// <returns>PaginationResultsLockable</returns>
        PaginationResultsLockable Paginate (BaseRequestPaginateLockable paginate);
        /// <summary>
        /// Retrieves the specified identifier. 
        /// </summary>
        /// <param name="ownerToken"></param>
        /// <param name="data"></param>
        /// <returns>Lockable</returns>
        Lockable Retrieve (string ownerToken, string data);
        /// <summary>
        /// Retrieves a lockable that has read only locks or no locks. 
        /// </summary>
        /// <param name="categories">The categories.</param>
        /// <returns>LockResponse</returns>
        LockResponse RetrieveReadOnly (BaseRequestIEnumerableString categories);
        /// <summary>
        /// Retrieves a lockable that has no locks on it. 
        /// </summary>
        /// <param name="categories">The categories.</param>
        /// <returns>LockResponse</returns>
        LockResponse RetrieveReadWrite (BaseRequestIEnumerableString categories);
        /// <summary>
        /// Unlocks a lockable. 
        /// </summary>
        /// <param name="unlockRequest">The unlock request.</param>
        /// <returns>UnlockResponse</returns>
        UnlockResponse Unlock (BaseRequestUnlockRequest unlockRequest);
        /// <summary>
        /// Updates the specified lockable. 
        /// </summary>
        /// <param name="lockable">The lockable.</param>
        /// <returns>Lockable</returns>
        Lockable Update (BaseRequestLockable lockable);
        /// <summary>
        /// Updates the many. 
        /// </summary>
        /// <param name="lockables">The lockables.</param>
        /// <returns>PaginationResultsLockable</returns>
        PaginationResultsLockable UpdateMany (BaseRequestIEnumerableLockable lockables);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LockableApi : ILockableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockableApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LockableApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LockableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LockableApi(String basePath)
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
        /// Locks the specified lockable. 
        /// </summary>
        /// <param name="lockRequest">The lock request.</param> 
        /// <returns>LockResponse</returns>            
        public LockResponse Lock (BaseRequestLockRequest lockRequest)
        {
            
    
            var path = "/api/Lockable/Lock";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(lockRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CallLock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CallLock: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LockResponse) ApiClient.Deserialize(response.Content, typeof(LockResponse), response.Headers);
        }
    
        /// <summary>
        /// Creates the specified lockable. 
        /// </summary>
        /// <param name="lockable">The lockable.</param> 
        /// <returns>Lockable</returns>            
        public Lockable Create (BaseRequestLockable lockable)
        {
            
    
            var path = "/api/Lockable/Create";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(lockable); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Lockable) ApiClient.Deserialize(response.Content, typeof(Lockable), response.Headers);
        }
    
        /// <summary>
        /// Bulk version of create. 
        /// </summary>
        /// <param name="lockables">The lockables.</param> 
        /// <returns>PaginationResultsLockable</returns>            
        public PaginationResultsLockable CreateMany (BaseRequestIEnumerableLockable lockables)
        {
            
    
            var path = "/api/Lockable/CreateMany";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(lockables); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMany: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginationResultsLockable) ApiClient.Deserialize(response.Content, typeof(PaginationResultsLockable), response.Headers);
        }
    
        /// <summary>
        /// Deletes the specified identifier. 
        /// </summary>
        /// <param name="id">The identifier.</param> 
        /// <returns>bool?</returns>            
        public bool? Delete (BaseRequestString id)
        {
            
    
            var path = "/api/Lockable/Delete";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Delete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Delete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Deletes the many. 
        /// </summary>
        /// <param name="ids">The ids.</param> 
        /// <returns>bool?</returns>            
        public bool? DeleteMany (BaseRequestIEnumerableString ids)
        {
            
    
            var path = "/api/Lockable/DeleteMany";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(ids); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMany: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Paginates. 
        /// </summary>
        /// <param name="paginate">The paginate.</param> 
        /// <returns>PaginationResultsLockable</returns>            
        public PaginationResultsLockable Paginate (BaseRequestPaginateLockable paginate)
        {
            
    
            var path = "/api/Lockable/Paginate";
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
    
            return (PaginationResultsLockable) ApiClient.Deserialize(response.Content, typeof(PaginationResultsLockable), response.Headers);
        }
    
        /// <summary>
        /// Retrieves the specified identifier. 
        /// </summary>
        /// <param name="ownerToken"></param> 
        /// <param name="data"></param> 
        /// <returns>Lockable</returns>            
        public Lockable Retrieve (string ownerToken, string data)
        {
            
    
            var path = "/api/Lockable/Retrieve";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ownerToken != null) queryParams.Add("OwnerToken", ApiClient.ParameterToString(ownerToken)); // query parameter
 if (data != null) queryParams.Add("Data", ApiClient.ParameterToString(data)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Retrieve: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Lockable) ApiClient.Deserialize(response.Content, typeof(Lockable), response.Headers);
        }
    
        /// <summary>
        /// Retrieves a lockable that has read only locks or no locks. 
        /// </summary>
        /// <param name="categories">The categories.</param> 
        /// <returns>LockResponse</returns>            
        public LockResponse RetrieveReadOnly (BaseRequestIEnumerableString categories)
        {
            
    
            var path = "/api/Lockable/RetrieveReadOnly";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(categories); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RetrieveReadOnly: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RetrieveReadOnly: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LockResponse) ApiClient.Deserialize(response.Content, typeof(LockResponse), response.Headers);
        }
    
        /// <summary>
        /// Retrieves a lockable that has no locks on it. 
        /// </summary>
        /// <param name="categories">The categories.</param> 
        /// <returns>LockResponse</returns>            
        public LockResponse RetrieveReadWrite (BaseRequestIEnumerableString categories)
        {
            
    
            var path = "/api/Lockable/RetrieveReadWrite";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(categories); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RetrieveReadWrite: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RetrieveReadWrite: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LockResponse) ApiClient.Deserialize(response.Content, typeof(LockResponse), response.Headers);
        }
    
        /// <summary>
        /// Unlocks a lockable. 
        /// </summary>
        /// <param name="unlockRequest">The unlock request.</param> 
        /// <returns>UnlockResponse</returns>            
        public UnlockResponse Unlock (BaseRequestUnlockRequest unlockRequest)
        {
            
    
            var path = "/api/Lockable/Unlock";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(unlockRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Unlock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Unlock: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnlockResponse) ApiClient.Deserialize(response.Content, typeof(UnlockResponse), response.Headers);
        }
    
        /// <summary>
        /// Updates the specified lockable. 
        /// </summary>
        /// <param name="lockable">The lockable.</param> 
        /// <returns>Lockable</returns>            
        public Lockable Update (BaseRequestLockable lockable)
        {
            
    
            var path = "/api/Lockable/Update";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(lockable); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Update: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Lockable) ApiClient.Deserialize(response.Content, typeof(Lockable), response.Headers);
        }
    
        /// <summary>
        /// Updates the many. 
        /// </summary>
        /// <param name="lockables">The lockables.</param> 
        /// <returns>PaginationResultsLockable</returns>            
        public PaginationResultsLockable UpdateMany (BaseRequestIEnumerableLockable lockables)
        {
            
    
            var path = "/api/Lockable/UpdateMany";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(lockables); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMany: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginationResultsLockable) ApiClient.Deserialize(response.Content, typeof(PaginationResultsLockable), response.Headers);
        }
    
    }
}
