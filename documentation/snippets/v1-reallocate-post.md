```csharp
using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Models;

var client = new SaladCloudImdsSdkClient();

var input = new ReallocateContainer("commodo");

await client.Metadata.ReallocateContainerAsync(input);


```
