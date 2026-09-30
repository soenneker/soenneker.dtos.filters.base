using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.Filters.Base;

/// <summary>
/// Defines the target field shared by structured API query filters.
/// </summary>
[PublicOpenApiObject]
public abstract class FilterBase
{
    /// <summary>
    /// Serializable field name to evaluate; supported names are determined by the queried resource.
    /// </summary>
    [JsonPropertyName("field")]
    public required string Field { get; set; }
}
