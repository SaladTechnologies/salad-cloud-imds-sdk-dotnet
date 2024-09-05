using System.Text.Json.Serialization;

namespace Salad.Cloud.IMDS.SDK.Models;

/// <summary>Represents the identity token of the running container.</summary>
public record ContainerToken(
    /// <value>The JSON Web Token (JWT) that may be used to identify the running container. The JWT may be verified using the JSON Web Key Set (JWKS) available at https://matrix-rest-api.salad.com/.well-known/stash-jwks.json.</value>
    [property: JsonPropertyName("jwt")]
        string Jwt
);
