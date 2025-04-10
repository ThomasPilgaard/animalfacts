using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.CatFacts;

[DebuggerDisplay("{Message}")]
public class CatFact
{
    [JsonPropertyName("fact")]
    public string? Message { get; set; }
    [JsonPropertyName("length")]
    public int Length { get; set; }
}
