using Salad.Cloud.IMDS.SDK;
using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Models;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

var config = new SaladCloudImdsSdkConfig { };

var client = new SaladCloudImdsSdkClient(config);

var response = await client.Metadata.GetDeletionCostAsync(Metadata1.True_);

Console.WriteLine(response);
