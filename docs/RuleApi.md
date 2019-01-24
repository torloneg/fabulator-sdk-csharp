# IO.Swagger.Api.RuleApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRuleV1Id**](RuleApi.md#deleterulev1id) | **DELETE** /rule/v1/{id} | 
[**GetRuleV1InfoId**](RuleApi.md#getrulev1infoid) | **GET** /rule/v1/info/{id} | 
[**PatchRuleV1UpdateIdFieldValue**](RuleApi.md#patchrulev1updateidfieldvalue) | **PATCH** /rule/v1/update/{id}/{field}/{value} | 
[**PostRuleV1AddIddomain**](RuleApi.md#postrulev1addiddomain) | **POST** /rule/v1/add/{iddomain} | 
[**PostRuleV1QueryIddomainSkipLimit**](RuleApi.md#postrulev1queryiddomainskiplimit) | **POST** /rule/v1/query/{iddomain}/{skip}/{limit} | 
[**PutRuleV1UpdateIddomainId**](RuleApi.md#putrulev1updateiddomainid) | **PUT** /rule/v1/update/{iddomain}/{id} | 


<a name="deleterulev1id"></a>
# **DeleteRuleV1Id**
> string DeleteRuleV1Id (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRuleV1IdExample
    {
        public void main()
        {
            var apiInstance = new RuleApi();
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.DeleteRuleV1Id(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.DeleteRuleV1Id: " + e.Message );
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

<a name="getrulev1infoid"></a>
# **GetRuleV1InfoId**
> string GetRuleV1InfoId (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRuleV1InfoIdExample
    {
        public void main()
        {
            var apiInstance = new RuleApi();
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.GetRuleV1InfoId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.GetRuleV1InfoId: " + e.Message );
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

<a name="patchrulev1updateidfieldvalue"></a>
# **PatchRuleV1UpdateIdFieldValue**
> string PatchRuleV1UpdateIdFieldValue (string id, string field, string value)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchRuleV1UpdateIdFieldValueExample
    {
        public void main()
        {
            var apiInstance = new RuleApi();
            var id = id_example;  // string | 
            var field = field_example;  // string | 
            var value = value_example;  // string | 

            try
            {
                string result = apiInstance.PatchRuleV1UpdateIdFieldValue(id, field, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.PatchRuleV1UpdateIdFieldValue: " + e.Message );
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

<a name="postrulev1addiddomain"></a>
# **PostRuleV1AddIddomain**
> string PostRuleV1AddIddomain (string iddomain, Model6 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRuleV1AddIddomainExample
    {
        public void main()
        {
            var apiInstance = new RuleApi();
            var iddomain = iddomain_example;  // string | 
            var body = new Model6(); // Model6 |  (optional) 

            try
            {
                string result = apiInstance.PostRuleV1AddIddomain(iddomain, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.PostRuleV1AddIddomain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iddomain** | **string**|  | 
 **body** | [**Model6**](Model6.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postrulev1queryiddomainskiplimit"></a>
# **PostRuleV1QueryIddomainSkipLimit**
> string PostRuleV1QueryIddomainSkipLimit (string iddomain, decimal? skip, decimal? limit, Model9 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostRuleV1QueryIddomainSkipLimitExample
    {
        public void main()
        {
            var apiInstance = new RuleApi();
            var iddomain = iddomain_example;  // string | 
            var skip = 8.14;  // decimal? | 
            var limit = 8.14;  // decimal? | 
            var body = new Model9(); // Model9 |  (optional) 

            try
            {
                string result = apiInstance.PostRuleV1QueryIddomainSkipLimit(iddomain, skip, limit, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.PostRuleV1QueryIddomainSkipLimit: " + e.Message );
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

<a name="putrulev1updateiddomainid"></a>
# **PutRuleV1UpdateIddomainId**
> string PutRuleV1UpdateIddomainId (string id, string iddomain, Model6 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutRuleV1UpdateIddomainIdExample
    {
        public void main()
        {
            var apiInstance = new RuleApi();
            var id = id_example;  // string | 
            var iddomain = iddomain_example;  // string | 
            var body = new Model6(); // Model6 |  (optional) 

            try
            {
                string result = apiInstance.PutRuleV1UpdateIddomainId(id, iddomain, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RuleApi.PutRuleV1UpdateIddomainId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **iddomain** | **string**|  | 
 **body** | [**Model6**](Model6.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

