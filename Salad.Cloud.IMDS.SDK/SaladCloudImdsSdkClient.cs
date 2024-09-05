using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Hooks;
using Salad.Cloud.IMDS.SDK.Http.Handlers;
using Salad.Cloud.IMDS.SDK.Services;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

namespace Salad.Cloud.IMDS.SDK;

public class SaladCloudImdsSdkClient : IDisposable
{
    private readonly HttpClient _httpClient;

    public MetadataService Metadata { get; private set; }

    public SaladCloudImdsSdkClient(SaladCloudImdsSdkConfig? config = null)
    {
        var hookHandler = new HookHandler(new CustomHook());
        var retryHandler = new RetryHandler(hookHandler);
        _httpClient = new HttpClient(retryHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } }
        };

        Metadata = new MetadataService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.BaseAddress = uri;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
