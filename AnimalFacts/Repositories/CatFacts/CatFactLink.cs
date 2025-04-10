using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.CatFacts;

public class CatFactLink
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("label")]
    public string? Label { get; set; }
    [JsonPropertyName("active")]
    public bool Active { get; set; }
}
