using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

namespace Salad.Cloud.IMDS.SDK.Config;

/// <summary>
/// Configuration options for the SaladCloudImdsSdkClient.
/// </summary>
public record SaladCloudImdsSdkConfig(
    /// <value>The environment to use for the SDK.</value>
    Environment? Environment = null
);
