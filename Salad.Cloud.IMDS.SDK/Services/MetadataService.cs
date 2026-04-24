using System.Net.Http.Json;
using Salad.Cloud.IMDS.SDK.Http;
using Salad.Cloud.IMDS.SDK.Http.Exceptions;
using Salad.Cloud.IMDS.SDK.Http.Extensions;
using Salad.Cloud.IMDS.SDK.Http.Handlers;
using Salad.Cloud.IMDS.SDK.Http.Serialization;
using Salad.Cloud.IMDS.SDK.Models;
using Salad.Cloud.IMDS.SDK.Validation;
using Salad.Cloud.IMDS.SDK.Validation.Extensions;

namespace Salad.Cloud.IMDS.SDK.Services;

/// <summary>
/// Service class providing access to API endpoints for MetadataService.
/// Inherits HTTP client management, JSON serialization, and streaming capabilities from the base service.
/// Each method corresponds to an API operation and handles request building, execution, and response parsing.
/// </summary>
public class MetadataService : BaseService
{
    internal MetadataService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets the deletion cost of the current container instance</summary>
    /// <param name="metadata">A custom request header required by all operations.</param>
    public async Task<DeletionCost> GetDeletionCostAsync(
        Metadata1 metadata,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(metadata, nameof(metadata));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var metadataValidationResult = new Metadata1Validator().ValidateRequired(metadata);
        validationResults.Add(metadataValidationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Get, "v1/deletion-cost")
            .SetHeader("Metadata", metadata.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var responseContent = response.EnsureSuccessfulResponse().Content;
        var contentLength = responseContent.Headers.ContentLength;

        DeletionCost result;
        if (contentLength == null || contentLength > 0)
        {
            result =
                await responseContent
                    .ReadFromJsonAsync<DeletionCost>(_jsonSerializerOptions, cancellationToken)
                    .ConfigureAwait(false)
                ?? throw new Exception("Failed to deserialize response.");
        }
        else
        {
            // Empty response body - return default instance
            result = default!;
        }

        return result;
    }

    /// <summary>Replaces the deletion cost of the current container instance</summary>
    /// <param name="metadata">A custom request header required by all operations.</param>
    public async Task ReplaceDeletionCostAsync(
        DeletionCost input,
        Metadata1 metadata,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(metadata, nameof(metadata));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var metadataValidationResult = new Metadata1Validator().ValidateRequired(metadata);
        validationResults.Add(metadataValidationResult);
        ;
        var validator = new DeletionCostValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Put, "v1/deletion-cost")
            .SetHeader("Metadata", metadata.Value)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Reallocates the current container instance to another SaladCloud node</summary>
    /// <param name="metadata">A custom request header required by all operations.</param>
    public async Task ReallocateAsync(
        ReallocatePrototype input,
        Metadata1 metadata,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(metadata, nameof(metadata));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var metadataValidationResult = new Metadata1Validator().ValidateRequired(metadata);
        validationResults.Add(metadataValidationResult);
        ;
        var validator = new ReallocatePrototypeValidator();
        var validationResult = validator.Validate(input);
        validationResults.Add(validationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Post, "v1/reallocate")
            .SetHeader("Metadata", metadata.Value)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Recreates the current container instance on the same SaladCloud node</summary>
    /// <param name="metadata">A custom request header required by all operations.</param>
    public async Task RecreateAsync(
        Metadata1 metadata,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(metadata, nameof(metadata));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var metadataValidationResult = new Metadata1Validator().ValidateRequired(metadata);
        validationResults.Add(metadataValidationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Post, "v1/recreate")
            .SetHeader("Metadata", metadata.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Restarts the current container instance on the same SaladCloud node</summary>
    /// <param name="metadata">A custom request header required by all operations.</param>
    public async Task RestartAsync(
        Metadata1 metadata,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(metadata, nameof(metadata));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var metadataValidationResult = new Metadata1Validator().ValidateRequired(metadata);
        validationResults.Add(metadataValidationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Post, "v1/restart")
            .SetHeader("Metadata", metadata.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        response.EnsureSuccessfulResponse();
    }

    /// <summary>Gets the health statuses of the current container instance</summary>
    /// <param name="metadata">A custom request header required by all operations.</param>
    public async Task<Status> GetStatusAsync(
        Metadata1 metadata,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(metadata, nameof(metadata));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var metadataValidationResult = new Metadata1Validator().ValidateRequired(metadata);
        validationResults.Add(metadataValidationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Get, "v1/status")
            .SetHeader("Metadata", metadata.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var responseContent = response.EnsureSuccessfulResponse().Content;
        var contentLength = responseContent.Headers.ContentLength;

        Status result;
        if (contentLength == null || contentLength > 0)
        {
            result =
                await responseContent
                    .ReadFromJsonAsync<Status>(_jsonSerializerOptions, cancellationToken)
                    .ConfigureAwait(false)
                ?? throw new Exception("Failed to deserialize response.");
        }
        else
        {
            // Empty response body - return default instance
            result = default!;
        }

        return result;
    }

    /// <summary>Gets the identity token of the current container instance</summary>
    /// <param name="metadata">A custom request header required by all operations.</param>
    public async Task<Token> GetTokenAsync(
        Metadata1 metadata,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(metadata, nameof(metadata));
        var validationResults = new List<FluentValidation.Results.ValidationResult> { };
        var metadataValidationResult = new Metadata1Validator().ValidateRequired(metadata);
        validationResults.Add(metadataValidationResult);

        var combinedFailures = validationResults.SelectMany(result => result.Errors).ToList();
        if (combinedFailures.Any())
        {
            throw new Http.Exceptions.ValidationException(combinedFailures);
        }

        var request = new RequestBuilder(HttpMethod.Get, "v1/token")
            .SetHeader("Metadata", metadata.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        // Standard deserialization
        var responseContent = response.EnsureSuccessfulResponse().Content;
        var contentLength = responseContent.Headers.ContentLength;

        Token result;
        if (contentLength == null || contentLength > 0)
        {
            result =
                await responseContent
                    .ReadFromJsonAsync<Token>(_jsonSerializerOptions, cancellationToken)
                    .ConfigureAwait(false)
                ?? throw new Exception("Failed to deserialize response.");
        }
        else
        {
            // Empty response body - return default instance
            result = default!;
        }

        return result;
    }
}
