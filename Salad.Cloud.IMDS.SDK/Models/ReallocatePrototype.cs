using System.Text.Json.Serialization;

namespace Salad.Cloud.IMDS.SDK.Models;

/// <summary>Represents a request to reallocate the current container instance to another SaladCloud node.</summary>
public record ReallocatePrototype(
    /// <value>The reason for reallocating the current container instance. This value is reported to SaladCloud support for quality assurance purposes of SaladCloud nodes.</value>
    [property: JsonPropertyName("reason")]
        string Reason
);
