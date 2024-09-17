# SaladCloudImdsSdk C# SDK 0.9.0-alpha.3

Welcome to the SaladCloudImdsSdk SDK documentation. This guide will help you get started with integrating and using the SaladCloudImdsSdk SDK in your project.

## Versions

- API version: `0.9.0-alpha.1`
- SDK version: `0.9.0-alpha.3`

## About the API

The SaladCloud Instance Metadata Service (IMDS). Please refer to the [SaladCloud API Documentation](https://docs.salad.com/api-reference) for more details.

## Table of Contents

- [Setup & Configuration](#setup--configuration)
  - [Supported Language Versions](#supported-language-versions)
  - [Installation](#installation)
- [Sample Usage](#sample-usage)
- [Services](#services)
- [Models](#models)
- [License](#license)

# Setup & Configuration

## Supported Language Versions

This SDK is compatible with the following versions: `C# >= .NET 6`

## Installation

To get started with the SDK, we recommend installing using `nuget`:

```bash
dotnet add package Salad.Cloud.IMDS.SDK
```

# Sample Usage

Below is a comprehensive example demonstrating how to authenticate and call a simple endpoint:

```cs
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig
{
  Environment = Environment.Default
};

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetContainerStatusAsync();

Console.WriteLine(response);

```

## Services

The SDK provides various services to interact with the API.

<details> 
<summary>Below is a list of all available services with links to their detailed documentation:</summary>

| Name                                                         |
| :----------------------------------------------------------- |
| [MetadataService](documentation/services/MetadataService.md) |

</details>

## Models

The SDK includes several models that represent the data structures used in API requests and responses. These models help in organizing and managing the data efficiently.

<details> 
<summary>Below is a list of all available models with links to their detailed documentation:</summary>

| Name                                                               | Description                                              |
| :----------------------------------------------------------------- | :------------------------------------------------------- |
| [ReallocateContainer](documentation/models/ReallocateContainer.md) | Represents a request to reallocate a container.          |
| [ContainerStatus](documentation/models/ContainerStatus.md)         | Represents the health statuses of the running container. |
| [ContainerToken](documentation/models/ContainerToken.md)           | Represents the identity token of the running container.  |

</details>

## License

This SDK is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more details.
