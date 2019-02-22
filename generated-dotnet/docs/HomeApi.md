# IO.Swagger.Api.HomeApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Version**](HomeApi.md#version) | **GET** /api/Version | Gets the version of this instance.


<a name="version"></a>
# **Version**
> void Version ()

Gets the version of this instance.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class VersionExample
    {
        public void main()
        {
            
            var apiInstance = new HomeApi();

            try
            {
                // Gets the version of this instance.
                apiInstance.Version();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HomeApi.Version: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

