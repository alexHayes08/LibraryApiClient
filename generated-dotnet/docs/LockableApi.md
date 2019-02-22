# IO.Swagger.Api.LockableApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallLock**](LockableApi.md#calllock) | **POST** /api/Lockable/Lock | Locks the specified lockable.
[**Create**](LockableApi.md#create) | **POST** /api/Lockable/Create | Creates the specified lockable.
[**CreateMany**](LockableApi.md#createmany) | **POST** /api/Lockable/CreateMany | Bulk version of create.
[**Delete**](LockableApi.md#delete) | **DELETE** /api/Lockable/Delete | Deletes the specified identifier.
[**DeleteMany**](LockableApi.md#deletemany) | **DELETE** /api/Lockable/DeleteMany | Deletes the many.
[**Paginate**](LockableApi.md#paginate) | **POST** /api/Lockable/Paginate | Paginates.
[**Retrieve**](LockableApi.md#retrieve) | **POST** /api/Lockable/Retrieve | Retrieves the specified identifier.
[**RetrieveReadOnly**](LockableApi.md#retrievereadonly) | **POST** /api/Lockable/RetrieveReadOnly | Retrieves a lockable that has read only locks or no locks.
[**RetrieveReadWrite**](LockableApi.md#retrievereadwrite) | **POST** /api/Lockable/RetrieveReadWrite | Retrieves a lockable that has no locks on it.
[**Unlock**](LockableApi.md#unlock) | **POST** /api/Lockable/Unlock | Unlocks a lockable.
[**Update**](LockableApi.md#update) | **PUT** /api/Lockable/Update | Updates the specified lockable.
[**UpdateMany**](LockableApi.md#updatemany) | **PUT** /api/Lockable/UpdateMany | Updates the many.


<a name="calllock"></a>
# **CallLock**
> LockResponse CallLock (BaseRequestLockRequest lockRequest)

Locks the specified lockable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CallLockExample
    {
        public void main()
        {
            
            var apiInstance = new LockableApi();
            var lockRequest = new BaseRequestLockRequest(); // BaseRequestLockRequest | The lock request. (optional) 

            try
            {
                // Locks the specified lockable.
                LockResponse result = apiInstance.CallLock(lockRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.CallLock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockRequest** | [**BaseRequestLockRequest**](BaseRequestLockRequest.md)| The lock request. | [optional] 

### Return type

[**LockResponse**](LockResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> Lockable Create (BaseRequestLockable lockable)

Creates the specified lockable.

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
            
            var apiInstance = new LockableApi();
            var lockable = new BaseRequestLockable(); // BaseRequestLockable | The lockable. (optional) 

            try
            {
                // Creates the specified lockable.
                Lockable result = apiInstance.Create(lockable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockable** | [**BaseRequestLockable**](BaseRequestLockable.md)| The lockable. | [optional] 

### Return type

[**Lockable**](Lockable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmany"></a>
# **CreateMany**
> PaginationResultsLockable CreateMany (BaseRequestIEnumerableLockable lockables)

Bulk version of create.

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
            
            var apiInstance = new LockableApi();
            var lockables = new BaseRequestIEnumerableLockable(); // BaseRequestIEnumerableLockable | The lockables. (optional) 

            try
            {
                // Bulk version of create.
                PaginationResultsLockable result = apiInstance.CreateMany(lockables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.CreateMany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockables** | [**BaseRequestIEnumerableLockable**](BaseRequestIEnumerableLockable.md)| The lockables. | [optional] 

### Return type

[**PaginationResultsLockable**](PaginationResultsLockable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> bool? Delete (BaseRequestString id)

Deletes the specified identifier.

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
            
            var apiInstance = new LockableApi();
            var id = new BaseRequestString(); // BaseRequestString | The identifier. (optional) 

            try
            {
                // Deletes the specified identifier.
                bool? result = apiInstance.Delete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.Delete: " + e.Message );
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

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemany"></a>
# **DeleteMany**
> bool? DeleteMany (BaseRequestIEnumerableString ids)

Deletes the many.

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
            
            var apiInstance = new LockableApi();
            var ids = new BaseRequestIEnumerableString(); // BaseRequestIEnumerableString | The ids. (optional) 

            try
            {
                // Deletes the many.
                bool? result = apiInstance.DeleteMany(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.DeleteMany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**BaseRequestIEnumerableString**](BaseRequestIEnumerableString.md)| The ids. | [optional] 

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
> PaginationResultsLockable Paginate (BaseRequestPaginateLockable paginate)

Paginates.

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
            
            var apiInstance = new LockableApi();
            var paginate = new BaseRequestPaginateLockable(); // BaseRequestPaginateLockable | The paginate. (optional) 

            try
            {
                // Paginates.
                PaginationResultsLockable result = apiInstance.Paginate(paginate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.Paginate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paginate** | [**BaseRequestPaginateLockable**](BaseRequestPaginateLockable.md)| The paginate. | [optional] 

### Return type

[**PaginationResultsLockable**](PaginationResultsLockable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrieve"></a>
# **Retrieve**
> Lockable Retrieve (string ownerToken, string data)

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
            
            var apiInstance = new LockableApi();
            var ownerToken = ownerToken_example;  // string |  (optional) 
            var data = data_example;  // string |  (optional) 

            try
            {
                // Retrieves the specified identifier.
                Lockable result = apiInstance.Retrieve(ownerToken, data);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.Retrieve: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ownerToken** | **string**|  | [optional] 
 **data** | **string**|  | [optional] 

### Return type

[**Lockable**](Lockable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievereadonly"></a>
# **RetrieveReadOnly**
> LockResponse RetrieveReadOnly (BaseRequestIEnumerableString categories)

Retrieves a lockable that has read only locks or no locks.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveReadOnlyExample
    {
        public void main()
        {
            
            var apiInstance = new LockableApi();
            var categories = new BaseRequestIEnumerableString(); // BaseRequestIEnumerableString | The categories. (optional) 

            try
            {
                // Retrieves a lockable that has read only locks or no locks.
                LockResponse result = apiInstance.RetrieveReadOnly(categories);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.RetrieveReadOnly: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categories** | [**BaseRequestIEnumerableString**](BaseRequestIEnumerableString.md)| The categories. | [optional] 

### Return type

[**LockResponse**](LockResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievereadwrite"></a>
# **RetrieveReadWrite**
> LockResponse RetrieveReadWrite (BaseRequestIEnumerableString categories)

Retrieves a lockable that has no locks on it.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveReadWriteExample
    {
        public void main()
        {
            
            var apiInstance = new LockableApi();
            var categories = new BaseRequestIEnumerableString(); // BaseRequestIEnumerableString | The categories. (optional) 

            try
            {
                // Retrieves a lockable that has no locks on it.
                LockResponse result = apiInstance.RetrieveReadWrite(categories);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.RetrieveReadWrite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categories** | [**BaseRequestIEnumerableString**](BaseRequestIEnumerableString.md)| The categories. | [optional] 

### Return type

[**LockResponse**](LockResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlock"></a>
# **Unlock**
> UnlockResponse Unlock (BaseRequestUnlockRequest unlockRequest)

Unlocks a lockable.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnlockExample
    {
        public void main()
        {
            
            var apiInstance = new LockableApi();
            var unlockRequest = new BaseRequestUnlockRequest(); // BaseRequestUnlockRequest | The unlock request. (optional) 

            try
            {
                // Unlocks a lockable.
                UnlockResponse result = apiInstance.Unlock(unlockRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.Unlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unlockRequest** | [**BaseRequestUnlockRequest**](BaseRequestUnlockRequest.md)| The unlock request. | [optional] 

### Return type

[**UnlockResponse**](UnlockResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="update"></a>
# **Update**
> Lockable Update (BaseRequestLockable lockable)

Updates the specified lockable.

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
            
            var apiInstance = new LockableApi();
            var lockable = new BaseRequestLockable(); // BaseRequestLockable | The lockable. (optional) 

            try
            {
                // Updates the specified lockable.
                Lockable result = apiInstance.Update(lockable);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.Update: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockable** | [**BaseRequestLockable**](BaseRequestLockable.md)| The lockable. | [optional] 

### Return type

[**Lockable**](Lockable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemany"></a>
# **UpdateMany**
> PaginationResultsLockable UpdateMany (BaseRequestIEnumerableLockable lockables)

Updates the many.

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
            
            var apiInstance = new LockableApi();
            var lockables = new BaseRequestIEnumerableLockable(); // BaseRequestIEnumerableLockable | The lockables. (optional) 

            try
            {
                // Updates the many.
                PaginationResultsLockable result = apiInstance.UpdateMany(lockables);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LockableApi.UpdateMany: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lockables** | [**BaseRequestIEnumerableLockable**](BaseRequestIEnumerableLockable.md)| The lockables. | [optional] 

### Return type

[**PaginationResultsLockable**](PaginationResultsLockable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

