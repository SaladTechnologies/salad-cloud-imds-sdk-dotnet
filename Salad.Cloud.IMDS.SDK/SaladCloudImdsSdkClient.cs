using Salad.Cloud.IMDS.SDK.Config;
using Salad.Cloud.IMDS.SDK.Http.Extensions;
using Salad.Cloud.IMDS.SDK.Http.Handlers;
using Salad.Cloud.IMDS.SDK.Services;
using Environment = Salad.Cloud.IMDS.SDK.Http.Environment;

namespace Salad.Cloud.IMDS.SDK;

/// <summary>
/// The main SDK client that provides access to all service endpoints.
/// Manages HTTP client lifecycle, authentication handlers, and service instances with centralized configuration.
/// Implements IDisposable to properly clean up HTTP resources.
/// </summary>
public class SaladCloudImdsSdkClient : IDisposable
{
    private readonly HttpClient _httpClient;

    public MetadataService Metadata { get; private set; }

    public SaladCloudImdsSdkClient(SaladCloudImdsSdkConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _httpClient = new HttpClient(retryHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } },
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
    /// Sets the base URL for the entire SDK.
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
        _httpClient.BaseAddress = uri.EnsureTrailingSlash();
    }

    /// <summary>
    /// Sets the timeout for the entire SDK.
    /// </summary>
    /// <param name="timeout">The timeout value. Must be a positive TimeSpan or Timeout.InfiniteTimeSpan.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the timeout is not valid.</exception>
    public void SetTimeout(TimeSpan timeout)
    {
        if (timeout <= TimeSpan.Zero && timeout != Timeout.InfiniteTimeSpan)
        {
            throw new ArgumentOutOfRangeException(
                nameof(timeout),
                "Timeout must be a positive value or Timeout.InfiniteTimeSpan."
            );
        }

        _httpClient.Timeout = timeout;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
