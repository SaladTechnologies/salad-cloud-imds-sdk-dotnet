using System.Text.Json.Serialization;

namespace Salad.Cloud.IMDS.SDK.Models;

/// <summary>The identity token of the current container instance.</summary>
public record Token(
    /// <value>The JSON Web Token (JWT) that may be used to identify the running container. The JWT may be verified using the JSON Web Key Set (JWKS) available at https://matrix-rest-api.salad.com/.well-known/workload-jwks.json.</value>
    [property: JsonPropertyName("jwt")]
        string Jwt
);
