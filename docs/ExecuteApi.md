# IO.Swagger.Api.ExecuteApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostExecuteV1LocalDomainKey**](ExecuteApi.md#postexecutev1localdomainkey) | **POST** /execute/v1/local/{domain}/{key} | 
[**PostExecuteV1RuleIdrule**](ExecuteApi.md#postexecutev1ruleidrule) | **POST** /execute/v1/rule/{idrule} | 
[**PostExecuteV1RuleIdruleExampleIdexample**](ExecuteApi.md#postexecutev1ruleidruleexampleidexample) | **POST** /execute/v1/rule/{idrule}/example/{idexample} | 


<a name="postexecutev1localdomainkey"></a>
# **PostExecuteV1LocalDomainKey**
> string PostExecuteV1LocalDomainKey (string domain, string key, Model5 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecuteV1LocalDomainKeyExample
    {
        public void main()
        {
            var apiInstance = new ExecuteApi();
            var domain = domain_example;  // string | 
            var key = key_example;  // string | 
            var body = new Model5(); // Model5 |  (optional) 

            try
            {
                string result = apiInstance.PostExecuteV1LocalDomainKey(domain, key, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecuteApi.PostExecuteV1LocalDomainKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**|  | 
 **key** | **string**|  | 
 **body** | [**Model5**](Model5.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutev1ruleidrule"></a>
# **PostExecuteV1RuleIdrule**
> string PostExecuteV1RuleIdrule (string idrule, Model5 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecuteV1RuleIdruleExample
    {
        public void main()
        {
            var apiInstance = new ExecuteApi();
            var idrule = idrule_example;  // string | 
            var body = new Model5(); // Model5 |  (optional) 

            try
            {
                string result = apiInstance.PostExecuteV1RuleIdrule(idrule, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecuteApi.PostExecuteV1RuleIdrule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idrule** | **string**|  | 
 **body** | [**Model5**](Model5.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postexecutev1ruleidruleexampleidexample"></a>
# **PostExecuteV1RuleIdruleExampleIdexample**
> string PostExecuteV1RuleIdruleExampleIdexample (string idrule, string idexample, string idsentence = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostExecuteV1RuleIdruleExampleIdexampleExample
    {
        public void main()
        {
            var apiInstance = new ExecuteApi();
            var idrule = idrule_example;  // string | 
            var idexample = idexample_example;  // string | 
            var idsentence = idsentence_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.PostExecuteV1RuleIdruleExampleIdexample(idrule, idexample, idsentence);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExecuteApi.PostExecuteV1RuleIdruleExampleIdexample: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idrule** | **string**|  | 
 **idexample** | **string**|  | 
 **idsentence** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

