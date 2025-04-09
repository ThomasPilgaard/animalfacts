using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AnimalFacts.Models;

[DebuggerDisplay("{Message}")]
public class Fact
{
    [JsonPropertyName("fact")]
    public string? Message { get; set; }
    [JsonPropertyName("length")]
    public int Length { get; set; }
}
