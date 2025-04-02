using System.Diagnostics;
using System.Text.Json.Serialization;

namespace CatFacts.Models;

[DebuggerDisplay("{Message}")]
public class Fact
{
    [JsonPropertyName("fact")]
    public string? Message { get; set; }
    [JsonPropertyName("length")]
    public int Length { get; set; }
}
