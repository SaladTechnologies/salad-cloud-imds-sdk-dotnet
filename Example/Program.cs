using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig { Environment = Environment.Default };

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetContainerStatusAsync();

Console.WriteLine(response);
