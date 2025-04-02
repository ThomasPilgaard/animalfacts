using System;
using System.Text.Json.Serialization;

namespace CatFacts.Repositories;

public class CatFactLink
{
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("label")]
    public string? Label { get; set; }
    [JsonPropertyName("active")]
    public bool Active { get; set; }
}
