# IO.Swagger.Api.UsersApi

All URIs are relative to *http://localhost:8003*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteUsersV1Id**](UsersApi.md#deleteusersv1id) | **DELETE** /users/v1/{id} | 
[**GetUsersV1InfoId**](UsersApi.md#getusersv1infoid) | **GET** /users/v1/info/{id} | 
[**PatchUsersV1UpdateIdFieldValue**](UsersApi.md#patchusersv1updateidfieldvalue) | **PATCH** /users/v1/update/{id}/{field}/{value} | 
[**PostUsersV1Add**](UsersApi.md#postusersv1add) | **POST** /users/v1/add | 
[**PostUsersV1Login**](UsersApi.md#postusersv1login) | **POST** /users/v1/login | 
[**PostUsersV1QuerySkipLimit**](UsersApi.md#postusersv1queryskiplimit) | **POST** /users/v1/query/{skip}/{limit} | 
[**PostUsersV1ResetPasswordToken**](UsersApi.md#postusersv1resetpasswordtoken) | **POST** /users/v1/reset_password/{token} | 
[**PostUsersV1SendPasswordReminderEmail**](UsersApi.md#postusersv1sendpasswordreminderemail) | **POST** /users/v1/send_password_reminder/{email} | 
[**PutUsersV1UpdateId**](UsersApi.md#putusersv1updateid) | **PUT** /users/v1/update/{id} | 


<a name="deleteusersv1id"></a>
# **DeleteUsersV1Id**
> string DeleteUsersV1Id (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUsersV1IdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.DeleteUsersV1Id(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUsersV1Id: " + e.Message );
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

<a name="getusersv1infoid"></a>
# **GetUsersV1InfoId**
> string GetUsersV1InfoId (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersV1InfoIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = id_example;  // string | 

            try
            {
                string result = apiInstance.GetUsersV1InfoId(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersV1InfoId: " + e.Message );
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

<a name="patchusersv1updateidfieldvalue"></a>
# **PatchUsersV1UpdateIdFieldValue**
> string PatchUsersV1UpdateIdFieldValue (string id, string field, string value)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchUsersV1UpdateIdFieldValueExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = id_example;  // string | 
            var field = field_example;  // string | 
            var value = value_example;  // string | 

            try
            {
                string result = apiInstance.PatchUsersV1UpdateIdFieldValue(id, field, value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PatchUsersV1UpdateIdFieldValue: " + e.Message );
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

<a name="postusersv1add"></a>
# **PostUsersV1Add**
> string PostUsersV1Add (Model2 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUsersV1AddExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var body = new Model2(); // Model2 |  (optional) 

            try
            {
                string result = apiInstance.PostUsersV1Add(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersV1Add: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model2**](Model2.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusersv1login"></a>
# **PostUsersV1Login**
> string PostUsersV1Login (Model3 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUsersV1LoginExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var body = new Model3(); // Model3 |  (optional) 

            try
            {
                string result = apiInstance.PostUsersV1Login(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersV1Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model3**](Model3.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusersv1queryskiplimit"></a>
# **PostUsersV1QuerySkipLimit**
> string PostUsersV1QuerySkipLimit (decimal? skip, decimal? limit, Model12 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUsersV1QuerySkipLimitExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var skip = 8.14;  // decimal? | 
            var limit = 8.14;  // decimal? | 
            var body = new Model12(); // Model12 |  (optional) 

            try
            {
                string result = apiInstance.PostUsersV1QuerySkipLimit(skip, limit, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersV1QuerySkipLimit: " + e.Message );
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
 **body** | [**Model12**](Model12.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusersv1resetpasswordtoken"></a>
# **PostUsersV1ResetPasswordToken**
> string PostUsersV1ResetPasswordToken (string token, Model8 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUsersV1ResetPasswordTokenExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var token = token_example;  // string | 
            var body = new Model8(); // Model8 |  (optional) 

            try
            {
                string result = apiInstance.PostUsersV1ResetPasswordToken(token, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersV1ResetPasswordToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**|  | 
 **body** | [**Model8**](Model8.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postusersv1sendpasswordreminderemail"></a>
# **PostUsersV1SendPasswordReminderEmail**
> string PostUsersV1SendPasswordReminderEmail (string email)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostUsersV1SendPasswordReminderEmailExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var email = email_example;  // string | 

            try
            {
                string result = apiInstance.PostUsersV1SendPasswordReminderEmail(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PostUsersV1SendPasswordReminderEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putusersv1updateid"></a>
# **PutUsersV1UpdateId**
> string PutUsersV1UpdateId (string id, Model13 body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PutUsersV1UpdateIdExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var id = id_example;  // string | 
            var body = new Model13(); // Model13 |  (optional) 

            try
            {
                string result = apiInstance.PutUsersV1UpdateId(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.PutUsersV1UpdateId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**Model13**](Model13.md)|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

