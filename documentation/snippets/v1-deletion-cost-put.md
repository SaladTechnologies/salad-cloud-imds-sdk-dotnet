```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

var input = new DeletionCost(100);

await client.Metadata.ReplaceDeletionCostAsync(input, Metadata1.True_);


```
