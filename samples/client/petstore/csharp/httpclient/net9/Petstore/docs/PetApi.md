# Org.OpenAPITools.Api.PetApi

All URIs are relative to *http://petstore.swagger.io:80/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddPet**](PetApi.md#addpet) | **POST** /pet | Add a new pet to the store |
| [**DeletePet**](PetApi.md#deletepet) | **DELETE** /pet/{petId} | Deletes a pet |
| [**FindPetsByStatus**](PetApi.md#findpetsbystatus) | **GET** /pet/findByStatus | Finds Pets by status |
| [**FindPetsByTags**](PetApi.md#findpetsbytags) | **GET** /pet/findByTags | Finds Pets by tags |
| [**GetPetById**](PetApi.md#getpetbyid) | **GET** /pet/{petId} | Find pet by ID |
| [**UpdatePet**](PetApi.md#updatepet) | **PUT** /pet | Update an existing pet |
| [**UpdatePetWithForm**](PetApi.md#updatepetwithform) | **POST** /pet/{petId} | Updates a pet in the store with form data |
| [**UploadFile**](PetApi.md#uploadfile) | **POST** /pet/{petId}/uploadImage | uploads an image |
| [**UploadFileWithRequiredFile**](PetApi.md#uploadfilewithrequiredfile) | **POST** /fake/{petId}/uploadImageWithRequiredFile | uploads an image (required) |

<a id="addpet"></a>
# **AddPet**
> void AddPet (Pet pet)

Add a new pet to the store

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddPetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var pet = new Pet(); // Pet | Pet object that needs to be added to the store

            try
            {
                // Add a new pet to the store
                apiInstance.AddPet(pet);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.AddPet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddPetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a new pet to the store
    apiInstance.AddPetWithHttpInfo(pet);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.AddPetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pet** | [**Pet**](Pet.md) | Pet object that needs to be added to the store |  |

### Return type

void (empty response body)

### Authorization

[petstore_auth](../README.md#petstore_auth), [http_signature_test](../README.md#http_signature_test)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **405** | Invalid input |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepet"></a>
# **DeletePet**
> void DeletePet (long petId, string? apiKey = null)

Deletes a pet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeletePetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var petId = 789L;  // long | Pet id to delete
            var apiKey = "apiKey_example";  // string? |  (optional) 

            try
            {
                // Deletes a pet
                apiInstance.DeletePet(petId, apiKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.DeletePet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a pet
    apiInstance.DeletePetWithHttpInfo(petId, apiKey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.DeletePetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **long** | Pet id to delete |  |
| **apiKey** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[petstore_auth](../README.md#petstore_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Invalid pet value |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findpetsbystatus"></a>
# **FindPetsByStatus**
> List&lt;Pet&gt; FindPetsByStatus (List<string> status)

Finds Pets by status

Multiple status values can be provided with comma separated strings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindPetsByStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var status = new List<string>(); // List<string> | Status values that need to be considered for filter

            try
            {
                // Finds Pets by status
                List<Pet> result = apiInstance.FindPetsByStatus(status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.FindPetsByStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindPetsByStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finds Pets by status
    ApiResponse<List<Pet>> response = apiInstance.FindPetsByStatusWithHttpInfo(status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.FindPetsByStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **status** | [**List&lt;string&gt;**](string.md) | Status values that need to be considered for filter |  |

### Return type

[**List&lt;Pet&gt;**](Pet.md)

### Authorization

[petstore_auth](../README.md#petstore_auth), [http_signature_test](../README.md#http_signature_test)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Invalid status value |  -  |
| **2XX** | Anything within 200-299 |  -  |
| **4XX** | Anything within 400-499 |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="findpetsbytags"></a>
# **FindPetsByTags**
> List&lt;Pet&gt; FindPetsByTags (List<string> tags)

Finds Pets by tags

Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FindPetsByTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var tags = new List<string>(); // List<string> | Tags to filter by

            try
            {
                // Finds Pets by tags
                List<Pet> result = apiInstance.FindPetsByTags(tags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.FindPetsByTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FindPetsByTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finds Pets by tags
    ApiResponse<List<Pet>> response = apiInstance.FindPetsByTagsWithHttpInfo(tags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.FindPetsByTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tags** | [**List&lt;string&gt;**](string.md) | Tags to filter by |  |

### Return type

[**List&lt;Pet&gt;**](Pet.md)

### Authorization

[petstore_auth](../README.md#petstore_auth), [http_signature_test](../README.md#http_signature_test)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Invalid tag value |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpetbyid"></a>
# **GetPetById**
> Pet GetPetById (long petId)

Find pet by ID

Returns a single pet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure API key authorization: api_key
            config.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api-key", "Bearer");
            // Configure API key authorization: api_key_query
            config.AddApiKey("api_key_query", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("api_key_query", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var petId = 789L;  // long | ID of pet to return

            try
            {
                // Find pet by ID
                Pet result = apiInstance.GetPetById(petId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.GetPetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Find pet by ID
    ApiResponse<Pet> response = apiInstance.GetPetByIdWithHttpInfo(petId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.GetPetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **long** | ID of pet to return |  |

### Return type

[**Pet**](Pet.md)

### Authorization

[api_key](../README.md#api_key), [api_key_query](../README.md#api_key_query)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Invalid ID supplied |  -  |
| **404** | Pet not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepet"></a>
# **UpdatePet**
> void UpdatePet (Pet pet)

Update an existing pet

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var pet = new Pet(); // Pet | Pet object that needs to be added to the store

            try
            {
                // Update an existing pet
                apiInstance.UpdatePet(pet);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.UpdatePet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing pet
    apiInstance.UpdatePetWithHttpInfo(pet);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.UpdatePetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pet** | [**Pet**](Pet.md) | Pet object that needs to be added to the store |  |

### Return type

void (empty response body)

### Authorization

[petstore_auth](../README.md#petstore_auth), [http_signature_test](../README.md#http_signature_test)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Invalid ID supplied |  -  |
| **404** | Pet not found |  -  |
| **405** | Validation exception |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatepetwithform"></a>
# **UpdatePetWithForm**
> void UpdatePetWithForm (long petId, string? name = null, string? status = null)

Updates a pet in the store with form data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePetWithFormExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var petId = 789L;  // long | ID of pet that needs to be updated
            var name = "name_example";  // string? | Updated name of the pet (optional) 
            var status = "status_example";  // string? | Updated status of the pet (optional) 

            try
            {
                // Updates a pet in the store with form data
                apiInstance.UpdatePetWithForm(petId, name, status);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.UpdatePetWithForm: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePetWithFormWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a pet in the store with form data
    apiInstance.UpdatePetWithFormWithHttpInfo(petId, name, status);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.UpdatePetWithFormWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **long** | ID of pet that needs to be updated |  |
| **name** | **string?** | Updated name of the pet | [optional]  |
| **status** | **string?** | Updated status of the pet | [optional]  |

### Return type

void (empty response body)

### Authorization

[petstore_auth](../README.md#petstore_auth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **405** | Invalid input |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadfile"></a>
# **UploadFile**
> ApiResponse UploadFile (long petId, string? additionalMetadata = null, FileParameter? file = null)

uploads an image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UploadFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var petId = 789L;  // long | ID of pet to update
            var additionalMetadata = "additionalMetadata_example";  // string? | Additional data to pass to server (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter? | file to upload (optional) 

            try
            {
                // uploads an image
                ApiResponse result = apiInstance.UploadFile(petId, additionalMetadata, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.UploadFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // uploads an image
    ApiResponse<ApiResponse> response = apiInstance.UploadFileWithHttpInfo(petId, additionalMetadata, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.UploadFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **long** | ID of pet to update |  |
| **additionalMetadata** | **string?** | Additional data to pass to server | [optional]  |
| **file** | **FileParameter?****FileParameter?** | file to upload | [optional]  |

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[petstore_auth](../README.md#petstore_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadfilewithrequiredfile"></a>
# **UploadFileWithRequiredFile**
> ApiResponse UploadFileWithRequiredFile (long petId, FileParameter requiredFile, string? additionalMetadata = null)

uploads an image (required)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UploadFileWithRequiredFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://petstore.swagger.io:80/v2";
            // Configure OAuth2 access token for authorization: petstore_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PetApi(httpClient, config, httpClientHandler);
            var petId = 789L;  // long | ID of pet to update
            var requiredFile = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // FileParameter | file to upload
            var additionalMetadata = "additionalMetadata_example";  // string? | Additional data to pass to server (optional) 

            try
            {
                // uploads an image (required)
                ApiResponse result = apiInstance.UploadFileWithRequiredFile(petId, requiredFile, additionalMetadata);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PetApi.UploadFileWithRequiredFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFileWithRequiredFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // uploads an image (required)
    ApiResponse<ApiResponse> response = apiInstance.UploadFileWithRequiredFileWithHttpInfo(petId, requiredFile, additionalMetadata);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PetApi.UploadFileWithRequiredFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **petId** | **long** | ID of pet to update |  |
| **requiredFile** | **FileParameter****FileParameter** | file to upload |  |
| **additionalMetadata** | **string?** | Additional data to pass to server | [optional]  |

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[petstore_auth](../README.md#petstore_auth)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

