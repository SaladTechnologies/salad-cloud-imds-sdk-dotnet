# MetadataService

A list of all methods in the `MetadataService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description                                             |
| :---------------------------------------------------- | :------------------------------------------------------ |
| [ReallocateContainerAsync](#reallocatecontainerasync) | Reallocates the running container to another Salad Node |
| [GetContainerStatusAsync](#getcontainerstatusasync)   | Gets the health statuses of the running container       |
| [GetContainerTokenAsync](#getcontainertokenasync)     | Gets the identity token of the running container        |

## ReallocateContainerAsync

Reallocates the running container to another Salad Node

- HTTP Method: `POST`
- Endpoint: `/v1/reallocate`

**Parameters**

| Name  | Type                | Required | Description       |
| :---- | :------------------ | :------- | :---------------- |
| input | ReallocateContainer | ✅       | The request body. |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Models;

var client = new SaladCloudImdsSdkClient();

var input = new ReallocateContainer("laborum culpa");

await client.Metadata.ReallocateContainerAsync(input);
```

## GetContainerStatusAsync

Gets the health statuses of the running container

- HTTP Method: `GET`
- Endpoint: `/v1/status`

**Return Type**

`ContainerStatus`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;

var client = new SaladCloudImdsSdkClient();

var response = await client.Metadata.GetContainerStatusAsync();

Console.WriteLine(response);
```

## GetContainerTokenAsync

Gets the identity token of the running container

- HTTP Method: `GET`
- Endpoint: `/v1/token`

**Return Type**

`ContainerToken`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;

var client = new SaladCloudImdsSdkClient();

var response = await client.Metadata.GetContainerTokenAsync();

Console.WriteLine(response);
```
