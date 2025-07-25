using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.Filters.Base;

/// <summary>
/// An abstract generic object for handling filtering during querying
/// </summary>
public abstract class FilterBase
{
    [JsonPropertyName("field")]
    [JsonProperty("field")]
    public string Field { get; set; } = null!;
}