# IO.Swagger.Api.RandomDataApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](RandomDataApi.md#create) | **POST** /api/RandomData/Create | 
[**CreateMany**](RandomDataApi.md#createmany) | **POST** /api/RandomData/CreateMany | 
[**Delete**](RandomDataApi.md#delete) | **DELETE** /api/RandomData/Delete | 
[**DeleteMany**](RandomDataApi.md#deletemany) | **DELETE** /api/RandomData/DeleteMany | 
[**Paginate**](RandomDataApi.md#paginate) | **POST** /api/RandomData/Paginate | 
[**Update**](RandomDataApi.md#update) | **PUT** /api/RandomData/Update | 
[**UpdateMany**](RandomDataApi.md#updatemany) | **PUT** /api/RandomData/UpdateMany | 


<a name="create"></a>
# **Create**
> RandomDataCollection Create (BaseRequestRandomDataCollection randomDataCollection)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            
            var apiInstance = new RandomDataApi();
            var randomDataCollection = new BaseRequestRandomDataCollection(); // BaseRequestRandomDataCollection |  (optional) 

            try
            {
                RandomDataCollection result = apiInstance.Create(randomDataCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RandomDataApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **randomDataCollection** | [**BaseRequestRandomDataCollection**](BaseRequestRandomDataCollection.md)|  | [optional] 

### Return type

[**RandomDataCollection**](RandomDataCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmany"></a>
# **CreateMany**
> PaginationResultsRandomDataCollection CreateMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateManyExample
    {
        public void main()
        {
            
            var apiInstance = new RandomDataApi();
            var randomDataCollection = new BaseRequestIEnumerableRandomDataCollection(); // BaseRequestIEnumerableRandomDataCollection |  (optional) 

            try
            {
                PaginationResultsRandomDataCollection result = apiInstance.CreateMany(randomDataCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RandomDataApi.CreateMany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **randomDataCollection** | [**BaseRequestIEnumerableRandomDataCollection**](BaseRequestIEnumerableRandomDataCollection.md)|  | [optional] 

### Return type

[**PaginationResultsRandomDataCollection**](PaginationResultsRandomDataCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> bool? Delete (BaseRequestRandomDataCollection randomDataCollection)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            
            var apiInstance = new RandomDataApi();
            var randomDataCollection = new BaseRequestRandomDataCollection(); // BaseRequestRandomDataCollection |  (optional) 

            try
            {
                bool? result = apiInstance.Delete(randomDataCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RandomDataApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **randomDataCollection** | [**BaseRequestRandomDataCollection**](BaseRequestRandomDataCollection.md)|  | [optional] 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemany"></a>
# **DeleteMany**
> bool? DeleteMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteManyExample
    {
        public void main()
        {
            
            var apiInstance = new RandomDataApi();
            var randomDataCollection = new BaseRequestIEnumerableRandomDataCollection(); // BaseRequestIEnumerableRandomDataCollection |  (optional) 

            try
            {
                bool? result = apiInstance.DeleteMany(randomDataCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RandomDataApi.DeleteMany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **randomDataCollection** | [**BaseRequestIEnumerableRandomDataCollection**](BaseRequestIEnumerableRandomDataCollection.md)|  | [optional] 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paginate"></a>
# **Paginate**
> PaginationResultsRandomDataCollection Paginate (BaseRequestPaginateRandomDataCollection paginate)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PaginateExample
    {
        public void main()
        {
            
            var apiInstance = new RandomDataApi();
            var paginate = new BaseRequestPaginateRandomDataCollection(); // BaseRequestPaginateRandomDataCollection |  (optional) 

            try
            {
                PaginationResultsRandomDataCollection result = apiInstance.Paginate(paginate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RandomDataApi.Paginate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paginate** | [**BaseRequestPaginateRandomDataCollection**](BaseRequestPaginateRandomDataCollection.md)|  | [optional] 

### Return type

[**PaginationResultsRandomDataCollection**](PaginationResultsRandomDataCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> RandomDataCollection Update (BaseRequestRandomDataCollection randomDataCollection)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateExample
    {
        public void main()
        {
            
            var apiInstance = new RandomDataApi();
            var randomDataCollection = new BaseRequestRandomDataCollection(); // BaseRequestRandomDataCollection |  (optional) 

            try
            {
                RandomDataCollection result = apiInstance.Update(randomDataCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RandomDataApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **randomDataCollection** | [**BaseRequestRandomDataCollection**](BaseRequestRandomDataCollection.md)|  | [optional] 

### Return type

[**RandomDataCollection**](RandomDataCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemany"></a>
# **UpdateMany**
> PaginationResultsRandomDataCollection UpdateMany (BaseRequestIEnumerableRandomDataCollection randomDataCollection)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateManyExample
    {
        public void main()
        {
            
            var apiInstance = new RandomDataApi();
            var randomDataCollection = new BaseRequestIEnumerableRandomDataCollection(); // BaseRequestIEnumerableRandomDataCollection |  (optional) 

            try
            {
                PaginationResultsRandomDataCollection result = apiInstance.UpdateMany(randomDataCollection);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RandomDataApi.UpdateMany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **randomDataCollection** | [**BaseRequestIEnumerableRandomDataCollection**](BaseRequestIEnumerableRandomDataCollection.md)|  | [optional] 

### Return type

[**PaginationResultsRandomDataCollection**](PaginationResultsRandomDataCollection.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

