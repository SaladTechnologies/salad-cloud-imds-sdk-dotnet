```csharp
using Salad.Cloud.IMDS.SDK;

var client = new SaladCloudImdsSdkClient();

var response = await client.Metadata.GetContainerStatusAsync();

Console.WriteLine(response);

```
