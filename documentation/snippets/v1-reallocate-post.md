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
