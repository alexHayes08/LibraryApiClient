using System;
using System.Net.Http;
using System.Text;
using System.Web;
using ApertureLabs.LibraryApi.Client.Models;
using LibraryServerApi.Models;
using Newtonsoft.Json;

namespace ApertureLabs.LibraryApi.Client.Services
{
    public class ApiService
    {
        #region Fields

        private static readonly HttpClient httpClient;

        private readonly ApiServiceOptions apiServiceOptions;

        #endregion

        #region Constructor

        static ApiService()
        {
            httpClient = new HttpClient();
        }

        public ApiService(ApiServiceOptions apiServiceOptions)
        {
            this.apiServiceOptions = apiServiceOptions;
        }

        #endregion

        #region Methods

        public V SendAndConvert<V, T>(HttpMethod method, Uri relativeUri, T data)
        {
            var response = Send(method, relativeUri, data);

            var content = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
                throw new Exception(content);

            var asObj = JsonConvert.DeserializeObject<V>(content);

            return asObj;
        }

        public HttpResponseMessage Send(HttpMethod method, Uri relativeUri)
        {
            var url = BuildUri(relativeUri);
            var request = new HttpRequestMessage
            {
                RequestUri = url,
                Method = method
            };

            var task = httpClient.SendAsync(request);
            task.Wait();

            return task.Result;
        }

        public HttpResponseMessage Send<T>(HttpMethod method, Uri relativeUri, T data)
        {
            var url = BuildUri(relativeUri);
            var content = BuildContent(data);
            var request = new HttpRequestMessage
            {
                RequestUri = url,
                Content = content,
                Method = method
            };

            var task = httpClient.SendAsync(request);
            task.Wait();

            return task.Result;
        }

        private Uri BuildUri(Uri relativeUri)
        {
            var uriBuilder = new UriBuilder(new Uri(
                apiServiceOptions.ServerUri,
                relativeUri));

            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["key"] = apiServiceOptions.Key;
            uriBuilder.Query = query.ToString();
            var url = uriBuilder.ToString();

            return new Uri(url);
        }

        private StringContent BuildContent<T>(T data)
        {
            var baseRequest = new BaseRequest<T>
            {
                Data = data,
                OwnerToken = apiServiceOptions.OwnerToken
            };

            var asStr = JsonConvert.SerializeObject(baseRequest);

            return new StringContent(asStr, Encoding.UTF8, "application/json");
        }

        #endregion
    }
}
