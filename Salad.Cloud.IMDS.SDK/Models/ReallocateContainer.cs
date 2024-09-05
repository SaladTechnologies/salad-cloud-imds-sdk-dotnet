using System.Text.Json.Serialization;

namespace Salad.Cloud.IMDS.SDK.Models;

/// <summary>Represents a request to reallocate a container.</summary>
public record ReallocateContainer(
    /// <value>The reason for reallocating the container. This value is reported to SaladCloud support for quality assurance of Salad Nodes.</value>
    [property: JsonPropertyName("reason")]
        string Reason
);
