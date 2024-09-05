```csharp
using Salad.Cloud.IMDS.SDK;

var client = new SaladCloudImdsSdkClient();

var response = await client.Metadata.GetContainerTokenAsync();

Console.WriteLine(response);

```
