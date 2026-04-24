```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

await client.Metadata.RestartAsync(Metadata1.True_);


```
