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

**Return Type**

`DeletionCost`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetDeletionCostAsync();

Console.WriteLine(response);
```

## ReplaceDeletionCostAsync

Replaces the deletion cost of the current container instance

- HTTP Method: `PUT`
- Endpoint: `/v1/deletion-cost`

**Parameters**

| Name  | Type         | Required | Description       |
| :---- | :----------- | :------- | :---------------- |
| input | DeletionCost | ✅       | The request body. |

**Return Type**

`DeletionCost`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

var input = new DeletionCost(100);

var response = await client.Metadata.ReplaceDeletionCostAsync(input);

Console.WriteLine(response);
```

## ReallocateAsync

Reallocates the current container instance to another SaladCloud node

- HTTP Method: `POST`
- Endpoint: `/v1/reallocate`

**Parameters**

| Name  | Type                | Required | Description       |
| :---- | :------------------ | :------- | :---------------- |
| input | ReallocatePrototype | ✅       | The request body. |

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

var input = new ReallocatePrototype("Insufficient VRAM");

await client.Metadata.ReallocateAsync(input);
```

## RecreateAsync

Recreates the current container instance on the same SaladCloud node

- HTTP Method: `POST`
- Endpoint: `/v1/recreate`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

await client.Metadata.RecreateAsync();
```

## RestartAsync

Restarts the current container instance on the same SaladCloud node

- HTTP Method: `POST`
- Endpoint: `/v1/restart`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

await client.Metadata.RestartAsync();
```

## GetStatusAsync

Gets the health statuses of the current container instance

- HTTP Method: `GET`
- Endpoint: `/v1/status`

**Return Type**

`Status`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetStatusAsync();

Console.WriteLine(response);
```

## GetTokenAsync

Gets the identity token of the current container instance

- HTTP Method: `GET`
- Endpoint: `/v1/token`

**Return Type**

`Token`

**Example Usage Code Snippet**

```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig{
    Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetTokenAsync();

Console.WriteLine(response);
```
