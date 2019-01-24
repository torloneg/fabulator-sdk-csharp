# IO.Swagger.Api.DomainApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteDomainV1Id**](DomainApi.md#deletedomainv1id) | **DELETE** /domain/v1/{id} | 
[**GetDomainV1InfoId**](DomainApi.md#getdomainv1infoid) | **GET** /domain/v1/info/{id} | 
[**PatchDomainV1UpdateIdFieldValue**](DomainApi.md#patchdomainv1updateidfieldvalue) | **PATCH** /domain/v1/update/{id}/{field}/{value} | 
[**PostDomainV1Add**](DomainApi.md#postdomainv1add) | **POST** /domain/v1/add | 
[**PostDomainV1QuerySkipLimit**](DomainApi.md#postdomainv1queryskiplimit) | **POST** /domain/v1/query/{skip}/{limit} | 
[**PutDomainV1UpdateId**](DomainApi.md#putdomainv1updateid) | **PUT** /domain/v1/update/{id} | 


<a name="deletedomainv1id"></a>
# **DeleteDomainV1Id**
> string DeleteDomainV1Id (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDomainV1IdExample
    {
        public void main()
        {
            var apiInstance = new DomainApi();
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.DeleteDomainV1Id(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.DeleteDomainV1Id: " + e.Message );
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

<a name="getdomainv1infoid"></a>
# **GetDomainV1InfoId**
> string GetDomainV1InfoId (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDomainV1InfoIdExample
    {
        public void main()
        {
            var apiInstance = new DomainApi();
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.GetDomainV1InfoId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.GetDomainV1InfoId: " + e.Message );
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

<a name="patchdomainv1updateidfieldvalue"></a>
# **PatchDomainV1UpdateIdFieldValue**
> string PatchDomainV1UpdateIdFieldValue (string id, string field, string value)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchDomainV1UpdateIdFieldValueExample
    {
        public void main()
        {
            var apiInstance = new DomainApi();
            var id = id_example;  // string | 
            var field = field_example;  // string | 
            var value = value_example;  // string | 

            try
            {
                string result = apiInstance.PatchDomainV1UpdateIdFieldValue(id, field, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.PatchDomainV1UpdateIdFieldValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **field** | **string**|  | 
 **value** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdomainv1add"></a>
# **PostDomainV1Add**
> string PostDomainV1Add (Model1 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDomainV1AddExample
    {
        public void main()
        {
            var apiInstance = new DomainApi();
            var body = new Model1(); // Model1 |  (optional) 

            try
            {
                string result = apiInstance.PostDomainV1Add(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.PostDomainV1Add: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model1**](Model1.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdomainv1queryskiplimit"></a>
# **PostDomainV1QuerySkipLimit**
> string PostDomainV1QuerySkipLimit (decimal? skip, decimal? limit, Model9 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostDomainV1QuerySkipLimitExample
    {
        public void main()
        {
            var apiInstance = new DomainApi();
            var skip = 8.14;  // decimal? | 
            var limit = 8.14;  // decimal? | 
            var body = new Model9(); // Model9 |  (optional) 

            try
            {
                string result = apiInstance.PostDomainV1QuerySkipLimit(skip, limit, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.PostDomainV1QuerySkipLimit: " + e.Message );
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
 **body** | [**Model9**](Model9.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putdomainv1updateid"></a>
# **PutDomainV1UpdateId**
> string PutDomainV1UpdateId (string id, Model1 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutDomainV1UpdateIdExample
    {
        public void main()
        {
            var apiInstance = new DomainApi();
            var id = id_example;  // string | 
            var body = new Model1(); // Model1 |  (optional) 

            try
            {
                string result = apiInstance.PutDomainV1UpdateId(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DomainApi.PutDomainV1UpdateId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Model1**](Model1.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

