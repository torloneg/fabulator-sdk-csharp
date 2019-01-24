# IO.Swagger.Api.SchemaApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSchemaV1InfoId**](SchemaApi.md#getschemav1infoid) | **GET** /schema/v1/info/{id} | 
[**PostSchemaV1GroupType**](SchemaApi.md#postschemav1grouptype) | **POST** /schema/v1/group/{type} | 
[**PostSchemaV1QuerySkipLimit**](SchemaApi.md#postschemav1queryskiplimit) | **POST** /schema/v1/query/{skip}/{limit} | 


<a name="getschemav1infoid"></a>
# **GetSchemaV1InfoId**
> string GetSchemaV1InfoId (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSchemaV1InfoIdExample
    {
        public void main()
        {
            var apiInstance = new SchemaApi();
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.GetSchemaV1InfoId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemaApi.GetSchemaV1InfoId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postschemav1grouptype"></a>
# **PostSchemaV1GroupType**
> string PostSchemaV1GroupType (string type)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSchemaV1GroupTypeExample
    {
        public void main()
        {
            var apiInstance = new SchemaApi();
            var type = type_example;  // string | 

            try
            {
                string result = apiInstance.PostSchemaV1GroupType(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemaApi.PostSchemaV1GroupType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postschemav1queryskiplimit"></a>
# **PostSchemaV1QuerySkipLimit**
> string PostSchemaV1QuerySkipLimit (decimal? skip, decimal? limit, Model11 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSchemaV1QuerySkipLimitExample
    {
        public void main()
        {
            var apiInstance = new SchemaApi();
            var skip = 8.14;  // decimal? | 
            var limit = 8.14;  // decimal? | 
            var body = new Model11(); // Model11 |  (optional) 

            try
            {
                string result = apiInstance.PostSchemaV1QuerySkipLimit(skip, limit, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemaApi.PostSchemaV1QuerySkipLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **skip** | **decimal?**|  | 
 **limit** | **decimal?**|  | 
 **body** | [**Model11**](Model11.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

