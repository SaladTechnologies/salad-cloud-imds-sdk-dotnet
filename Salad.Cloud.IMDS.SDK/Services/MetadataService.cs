using System.Net.Http.Json;
using Salad.Cloud.IMDS.SDK.Http;
using Salad.Cloud.IMDS.SDK.Http.Serialization;
using Salad.Cloud.IMDS.SDK.Models;

namespace Salad.Cloud.IMDS.SDK.Services;

public class MetadataService : BaseService
{
    internal MetadataService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Reallocates the running container to another Salad Node</summary>
    public async Task ReallocateContainerAsync(
        ReallocateContainer input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "v1/reallocate")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Gets the health statuses of the running container</summary>
    public async Task<ContainerStatus> GetContainerStatusAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "v1/status").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ContainerStatus>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets the identity token of the running container</summary>
    public async Task<ContainerToken> GetContainerTokenAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "v1/token").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ContainerToken>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
