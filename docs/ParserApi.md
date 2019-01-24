# IO.Swagger.Api.ParserApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostParserV1RuleIdrule**](ParserApi.md#postparserv1ruleidrule) | **POST** /parser/v1/rule/{idrule} | 


<a name="postparserv1ruleidrule"></a>
# **PostParserV1RuleIdrule**
> string PostParserV1RuleIdrule ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostParserV1RuleIdruleExample
    {
        public void main()
        {
            var apiInstance = new ParserApi();

            try
            {
                string result = apiInstance.PostParserV1RuleIdrule();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ParserApi.PostParserV1RuleIdrule: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

