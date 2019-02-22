# IO.Swagger.Api.LockRecordApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Paginate**](LockRecordApi.md#paginate) | **POST** /api/LockRecord/Paginate | Paginates the {LockRecord}s.
[**Retrieve**](LockRecordApi.md#retrieve) | **POST** /api/LockRecord/Retrieve | Retrieves the specified identifier.


<a name="paginate"></a>
# **Paginate**
> PaginationResultsLockRecord Paginate (BaseRequestPaginateLockRecord paginate)

Paginates the {LockRecord}s.

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
            
            var apiInstance = new LockRecordApi();
            var paginate = new BaseRequestPaginateLockRecord(); // BaseRequestPaginateLockRecord | The paginate. (optional) 

            try
            {
                // Paginates the {LockRecord}s.
                PaginationResultsLockRecord result = apiInstance.Paginate(paginate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockRecordApi.Paginate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paginate** | [**BaseRequestPaginateLockRecord**](BaseRequestPaginateLockRecord.md)| The paginate. | [optional] 

### Return type

[**PaginationResultsLockRecord**](PaginationResultsLockRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieve"></a>
# **Retrieve**
> LockRecord Retrieve (BaseRequestString id)

Retrieves the specified identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveExample
    {
        public void main()
        {
            
            var apiInstance = new LockRecordApi();
            var id = new BaseRequestString(); // BaseRequestString | The identifier. (optional) 

            try
            {
                // Retrieves the specified identifier.
                LockRecord result = apiInstance.Retrieve(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockRecordApi.Retrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**BaseRequestString**](BaseRequestString.md)| The identifier. | [optional] 

### Return type

[**LockRecord**](LockRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

