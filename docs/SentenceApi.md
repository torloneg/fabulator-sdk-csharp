# IO.Swagger.Api.SentenceApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSentenceV1IdruleId**](SentenceApi.md#deletesentencev1idruleid) | **DELETE** /sentence/v1/{idrule}/{id} | 
[**GetSentenceV1InfoIdruleId**](SentenceApi.md#getsentencev1infoidruleid) | **GET** /sentence/v1/info/{idrule}/{id} | 
[**PostSentenceV1AddIdrule**](SentenceApi.md#postsentencev1addidrule) | **POST** /sentence/v1/add/{idrule} | 
[**PutSentenceV1UpdateIdruleId**](SentenceApi.md#putsentencev1updateidruleid) | **PUT** /sentence/v1/update/{idrule}/{id} | 


<a name="deletesentencev1idruleid"></a>
# **DeleteSentenceV1IdruleId**
> string DeleteSentenceV1IdruleId (string idrule, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSentenceV1IdruleIdExample
    {
        public void main()
        {
            var apiInstance = new SentenceApi();
            var idrule = idrule_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.DeleteSentenceV1IdruleId(idrule, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SentenceApi.DeleteSentenceV1IdruleId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idrule** | **string**|  | 
 **id** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsentencev1infoidruleid"></a>
# **GetSentenceV1InfoIdruleId**
> string GetSentenceV1InfoIdruleId (string idrule, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSentenceV1InfoIdruleIdExample
    {
        public void main()
        {
            var apiInstance = new SentenceApi();
            var idrule = idrule_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.GetSentenceV1InfoIdruleId(idrule, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SentenceApi.GetSentenceV1InfoIdruleId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idrule** | **string**|  | 
 **id** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsentencev1addidrule"></a>
# **PostSentenceV1AddIdrule**
> string PostSentenceV1AddIdrule (string idrule, Model7 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSentenceV1AddIdruleExample
    {
        public void main()
        {
            var apiInstance = new SentenceApi();
            var idrule = idrule_example;  // string | 
            var body = new Model7(); // Model7 |  (optional) 

            try
            {
                string result = apiInstance.PostSentenceV1AddIdrule(idrule, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SentenceApi.PostSentenceV1AddIdrule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idrule** | **string**|  | 
 **body** | [**Model7**](Model7.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putsentencev1updateidruleid"></a>
# **PutSentenceV1UpdateIdruleId**
> string PutSentenceV1UpdateIdruleId (string idrule, string id, Model15 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutSentenceV1UpdateIdruleIdExample
    {
        public void main()
        {
            var apiInstance = new SentenceApi();
            var idrule = idrule_example;  // string | 
            var id = id_example;  // string | 
            var body = new Model15(); // Model15 |  (optional) 

            try
            {
                string result = apiInstance.PutSentenceV1UpdateIdruleId(idrule, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SentenceApi.PutSentenceV1UpdateIdruleId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idrule** | **string**|  | 
 **id** | **string**|  | 
 **body** | [**Model15**](Model15.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

