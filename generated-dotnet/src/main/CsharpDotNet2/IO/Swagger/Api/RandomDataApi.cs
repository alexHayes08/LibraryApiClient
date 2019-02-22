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
    public interface IRandomDataApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param>
        /// <returns>RandomDataCollection</returns>
        RandomDataCollection Create (BaseRequestRandomDataCollection randomDataCollection);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param>
        /// <returns>PaginationResultsRandomDataCollection</returns>
        PaginationResultsRandomDataCollection CreateMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param>
        /// <returns>bool?</returns>
        bool? Delete (BaseRequestRandomDataCollection randomDataCollection);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param>
        /// <returns>bool?</returns>
        bool? DeleteMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="paginate"></param>
        /// <returns>PaginationResultsRandomDataCollection</returns>
        PaginationResultsRandomDataCollection Paginate (BaseRequestPaginateRandomDataCollection paginate);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param>
        /// <returns>RandomDataCollection</returns>
        RandomDataCollection Update (BaseRequestRandomDataCollection randomDataCollection);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param>
        /// <returns>PaginationResultsRandomDataCollection</returns>
        PaginationResultsRandomDataCollection UpdateMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RandomDataApi : IRandomDataApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RandomDataApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RandomDataApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RandomDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RandomDataApi(String basePath)
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
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param> 
        /// <returns>RandomDataCollection</returns>            
        public RandomDataCollection Create (BaseRequestRandomDataCollection randomDataCollection)
        {
            
    
            var path = "/api/RandomData/Create";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(randomDataCollection); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Create: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RandomDataCollection) ApiClient.Deserialize(response.Content, typeof(RandomDataCollection), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param> 
        /// <returns>PaginationResultsRandomDataCollection</returns>            
        public PaginationResultsRandomDataCollection CreateMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection)
        {
            
    
            var path = "/api/RandomData/CreateMany";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(randomDataCollection); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateMany: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginationResultsRandomDataCollection) ApiClient.Deserialize(response.Content, typeof(PaginationResultsRandomDataCollection), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param> 
        /// <returns>bool?</returns>            
        public bool? Delete (BaseRequestRandomDataCollection randomDataCollection)
        {
            
    
            var path = "/api/RandomData/Delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(randomDataCollection); // http body (model) parameter
    
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
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param> 
        /// <returns>bool?</returns>            
        public bool? DeleteMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection)
        {
            
    
            var path = "/api/RandomData/DeleteMany";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(randomDataCollection); // http body (model) parameter
    
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
        ///  
        /// </summary>
        /// <param name="paginate"></param> 
        /// <returns>PaginationResultsRandomDataCollection</returns>            
        public PaginationResultsRandomDataCollection Paginate (BaseRequestPaginateRandomDataCollection paginate)
        {
            
    
            var path = "/api/RandomData/Paginate";
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
    
            return (PaginationResultsRandomDataCollection) ApiClient.Deserialize(response.Content, typeof(PaginationResultsRandomDataCollection), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param> 
        /// <returns>RandomDataCollection</returns>            
        public RandomDataCollection Update (BaseRequestRandomDataCollection randomDataCollection)
        {
            
    
            var path = "/api/RandomData/Update";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(randomDataCollection); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Update: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Update: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RandomDataCollection) ApiClient.Deserialize(response.Content, typeof(RandomDataCollection), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="randomDataCollection"></param> 
        /// <returns>PaginationResultsRandomDataCollection</returns>            
        public PaginationResultsRandomDataCollection UpdateMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection)
        {
            
    
            var path = "/api/RandomData/UpdateMany";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(randomDataCollection); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMany: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMany: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaginationResultsRandomDataCollection) ApiClient.Deserialize(response.Content, typeof(PaginationResultsRandomDataCollection), response.Headers);
        }
    
    }
}
