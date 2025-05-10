using System.Text.Json.Serialization;

namespace Salad.Cloud.IMDS.SDK.Models;

/// <summary>The deletion cost of the current container instance.</summary>
public record DeletionCost(
    /// <value>An integer value that identifies the relative cost to the application running across the container group if the current container instance is deleted. A higher value indicates a higher cost, and a lower value indicates a lower cost. If the container group is scaled down, the scheduler will attempt to delete the container instances with the lowest deletion costs first.</value>
    [property: JsonPropertyName("deletion_cost")]
        long DeletionCost1
);
