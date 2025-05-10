using System.Net.Http.Json;
using Salad.Cloud.IMDS.SDK.Http;
using Salad.Cloud.IMDS.SDK.Http.Exceptions;
using Salad.Cloud.IMDS.SDK.Http.Extensions;
using Salad.Cloud.IMDS.SDK.Http.Serialization;
using Salad.Cloud.IMDS.SDK.Models;
using Salad.Cloud.IMDS.SDK.Validation;
using Salad.Cloud.IMDS.SDK.Validation.Extensions;

namespace Salad.Cloud.IMDS.SDK.Services;

public class MetadataService : BaseService
{
    internal MetadataService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the deletion cost of the current container instance</summary>
    public async Task<DeletionCost> GetDeletionCostAsync(
        CancellationToken cancellationToken = default
    )
    {
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Get, "v1/deletion-cost").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<DeletionCost>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Replaces the deletion cost of the current container instance</summary>
    public async Task<DeletionCost> ReplaceDeletionCostAsync(
        DeletionCost input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Put, "v1/deletion-cost")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<DeletionCost>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Reallocates the current container instance to another SaladCloud node</summary>
    public async Task ReallocateAsync(
        ReallocatePrototype input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Post, "v1/reallocate")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Recreates the current container instance on the same SaladCloud node</summary>
    public async Task RecreateAsync(CancellationToken cancellationToken = default)
    {
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Post, "v1/recreate").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Restarts the current container instance on the same SaladCloud node</summary>
    public async Task RestartAsync(CancellationToken cancellationToken = default)
    {
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Post, "v1/restart").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Gets the health statuses of the current container instance</summary>
    public async Task<Status> GetStatusAsync(CancellationToken cancellationToken = default)
    {
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Get, "v1/status").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<Status>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets the identity token of the current container instance</summary>
    public async Task<Token> GetTokenAsync(CancellationToken cancellationToken = default)
    {
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Get, "v1/token").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<Token>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
