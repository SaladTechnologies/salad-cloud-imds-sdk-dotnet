# MetadataService

A list of all methods in the `MetadataService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description                                                           |
| :---------------------------------------------------- | :-------------------------------------------------------------------- |
| [GetDeletionCostAsync](#getdeletioncostasync)         | Gets the deletion cost of the current container instance              |
| [ReplaceDeletionCostAsync](#replacedeletioncostasync) | Replaces the deletion cost of the current container instance          |
| [ReallocateAsync](#reallocateasync)                   | Reallocates the current container instance to another SaladCloud node |
| [RecreateAsync](#recreateasync)                       | Recreates the current container instance on the same SaladCloud node  |
| [RestartAsync](#restartasync)                         | Restarts the current container instance on the same SaladCloud node   |
| [GetStatusAsync](#getstatusasync)                     | Gets the health statuses of the current container instance            |
| [GetTokenAsync](#gettokenasync)                       | Gets the identity token of the current container instance             |

## GetDeletionCostAsync

Gets the deletion cost of the current container instance

- HTTP Method: `GET`
- Endpoint: `/v1/deletion-cost`

**Parameters**

| Name     | Type      | Required | Description                                         |
| :------- | :-------- | :------- | :-------------------------------------------------- |
| metadata | Metadata1 | ✅       | A custom request header required by all operations. |

**Return Type**

`DeletionCost`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetDeletionCostAsync(Metadata1.True_);

Console.WriteLine(response);
```

## ReplaceDeletionCostAsync

Replaces the deletion cost of the current container instance

- HTTP Method: `PUT`
- Endpoint: `/v1/deletion-cost`

**Parameters**

| Name     | Type         | Required | Description                                         |
| :------- | :----------- | :------- | :-------------------------------------------------- |
| input    | DeletionCost | ✅       | The request body.                                   |
| metadata | Metadata1    | ✅       | A custom request header required by all operations. |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

var input = new DeletionCost(100);

await client.Metadata.ReplaceDeletionCostAsync(input, Metadata1.True_);
```

## ReallocateAsync

Reallocates the current container instance to another SaladCloud node

- HTTP Method: `POST`
- Endpoint: `/v1/reallocate`

**Parameters**

| Name     | Type                | Required | Description                                         |
| :------- | :------------------ | :------- | :-------------------------------------------------- |
| input    | ReallocatePrototype | ✅       | The request body.                                   |
| metadata | Metadata1           | ✅       | A custom request header required by all operations. |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

var input = new ReallocatePrototype("Insufficient VRAM");

await client.Metadata.ReallocateAsync(input, Metadata1.True_);
```

## RecreateAsync

Recreates the current container instance on the same SaladCloud node

- HTTP Method: `POST`
- Endpoint: `/v1/recreate`

**Parameters**

| Name     | Type      | Required | Description                                         |
| :------- | :-------- | :------- | :-------------------------------------------------- |
| metadata | Metadata1 | ✅       | A custom request header required by all operations. |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

await client.Metadata.RecreateAsync(Metadata1.True_);
```

## RestartAsync

Restarts the current container instance on the same SaladCloud node

- HTTP Method: `POST`
- Endpoint: `/v1/restart`

**Parameters**

| Name     | Type      | Required | Description                                         |
| :------- | :-------- | :------- | :-------------------------------------------------- |
| metadata | Metadata1 | ✅       | A custom request header required by all operations. |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

await client.Metadata.RestartAsync(Metadata1.True_);
```

## GetStatusAsync

Gets the health statuses of the current container instance

- HTTP Method: `GET`
- Endpoint: `/v1/status`

**Parameters**

| Name     | Type      | Required | Description                                         |
| :------- | :-------- | :------- | :-------------------------------------------------- |
| metadata | Metadata1 | ✅       | A custom request header required by all operations. |

**Return Type**

`Status`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetStatusAsync(Metadata1.True_);

Console.WriteLine(response);
```

## GetTokenAsync

Gets the identity token of the current container instance

- HTTP Method: `GET`
- Endpoint: `/v1/token`

**Parameters**

| Name     | Type      | Required | Description                                         |
| :------- | :-------- | :------- | :-------------------------------------------------- |
| metadata | Metadata1 | ✅       | A custom request header required by all operations. |

**Return Type**

`Token`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetTokenAsync(Metadata1.True_);

Console.WriteLine(response);
```
