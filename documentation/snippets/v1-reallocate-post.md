```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;

var config = new SaladCloudImdsSdkConfig{};

var client = new SaladCloudImdsSdkClient(config);

var input = new ReallocatePrototype("Insufficient VRAM");

await client.Metadata.ReallocateAsync(input, Metadata1.True_);


```
