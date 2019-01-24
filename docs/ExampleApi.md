# IO.Swagger.Api.ExampleApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteExampleV1IddomainId**](ExampleApi.md#deleteexamplev1iddomainid) | **DELETE** /example/v1/{iddomain}/{id} | 
[**GetExampleV1InfoIddomainId**](ExampleApi.md#getexamplev1infoiddomainid) | **GET** /example/v1/info/{iddomain}/{id} | 
[**PatchExampleV1UpdateIddomainIdFieldValue**](ExampleApi.md#patchexamplev1updateiddomainidfieldvalue) | **PATCH** /example/v1/update/{iddomain}/{id}/{field}/{value} | 
[**PostExampleV1AddIddomain**](ExampleApi.md#postexamplev1addiddomain) | **POST** /example/v1/add/{iddomain} | 
[**PostExampleV1QueryIddomainSkipLimit**](ExampleApi.md#postexamplev1queryiddomainskiplimit) | **POST** /example/v1/query/{iddomain}/{skip}/{limit} | 
[**PutExampleV1UpdateIddomainId**](ExampleApi.md#putexamplev1updateiddomainid) | **PUT** /example/v1/update/{iddomain}/{id} | 
[**PutExampleV1UpdateJsonIddomainId**](ExampleApi.md#putexamplev1updatejsoniddomainid) | **PUT** /example/v1/update_json/{iddomain}/{id} | 


<a name="deleteexamplev1iddomainid"></a>
# **DeleteExampleV1IddomainId**
> string DeleteExampleV1IddomainId (string iddomain, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExampleV1IddomainIdExample
    {
        public void main()
        {
            var apiInstance = new ExampleApi();
            var iddomain = iddomain_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.DeleteExampleV1IddomainId(iddomain, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExampleApi.DeleteExampleV1IddomainId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
 **id** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexamplev1infoiddomainid"></a>
# **GetExampleV1InfoIddomainId**
> string GetExampleV1InfoIddomainId (string iddomain, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExampleV1InfoIddomainIdExample
    {
        public void main()
        {
            var apiInstance = new ExampleApi();
            var iddomain = iddomain_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.GetExampleV1InfoIddomainId(iddomain, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExampleApi.GetExampleV1InfoIddomainId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
 **id** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchexamplev1updateiddomainidfieldvalue"></a>
# **PatchExampleV1UpdateIddomainIdFieldValue**
> string PatchExampleV1UpdateIddomainIdFieldValue (string iddomain, string id, string field, string value)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchExampleV1UpdateIddomainIdFieldValueExample
    {
        public void main()
        {
            var apiInstance = new ExampleApi();
            var iddomain = iddomain_example;  // string | 
            var id = id_example;  // string | 
            var field = field_example;  // string | 
            var value = value_example;  // string | 

            try
            {
                string result = apiInstance.PatchExampleV1UpdateIddomainIdFieldValue(iddomain, id, field, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExampleApi.PatchExampleV1UpdateIddomainIdFieldValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
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

<a name="postexamplev1addiddomain"></a>
# **PostExampleV1AddIddomain**
> string PostExampleV1AddIddomain (string iddomain, Model4 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExampleV1AddIddomainExample
    {
        public void main()
        {
            var apiInstance = new ExampleApi();
            var iddomain = iddomain_example;  // string | 
            var body = new Model4(); // Model4 |  (optional) 

            try
            {
                string result = apiInstance.PostExampleV1AddIddomain(iddomain, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExampleApi.PostExampleV1AddIddomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
 **body** | [**Model4**](Model4.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexamplev1queryiddomainskiplimit"></a>
# **PostExampleV1QueryIddomainSkipLimit**
> string PostExampleV1QueryIddomainSkipLimit (string iddomain, decimal? skip, decimal? limit, Model9 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExampleV1QueryIddomainSkipLimitExample
    {
        public void main()
        {
            var apiInstance = new ExampleApi();
            var iddomain = iddomain_example;  // string | 
            var skip = 8.14;  // decimal? | 
            var limit = 8.14;  // decimal? | 
            var body = new Model9(); // Model9 |  (optional) 

            try
            {
                string result = apiInstance.PostExampleV1QueryIddomainSkipLimit(iddomain, skip, limit, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExampleApi.PostExampleV1QueryIddomainSkipLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
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

<a name="putexamplev1updateiddomainid"></a>
# **PutExampleV1UpdateIddomainId**
> string PutExampleV1UpdateIddomainId (string iddomain, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutExampleV1UpdateIddomainIdExample
    {
        public void main()
        {
            var apiInstance = new ExampleApi();
            var iddomain = iddomain_example;  // string | 
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.PutExampleV1UpdateIddomainId(iddomain, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExampleApi.PutExampleV1UpdateIddomainId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
 **id** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putexamplev1updatejsoniddomainid"></a>
# **PutExampleV1UpdateJsonIddomainId**
> string PutExampleV1UpdateJsonIddomainId (string iddomain, string id, Model14 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutExampleV1UpdateJsonIddomainIdExample
    {
        public void main()
        {
            var apiInstance = new ExampleApi();
            var iddomain = iddomain_example;  // string | 
            var id = id_example;  // string | 
            var body = new Model14(); // Model14 |  (optional) 

            try
            {
                string result = apiInstance.PutExampleV1UpdateJsonIddomainId(iddomain, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExampleApi.PutExampleV1UpdateJsonIddomainId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
 **id** | **string**|  | 
 **body** | [**Model14**](Model14.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

