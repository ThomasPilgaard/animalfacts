using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AnimalFacts.Models;

[DebuggerDisplay("{Name}")]
public class Breed
{
    [JsonPropertyName("breed")]
    public string? Name { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("origin")]
    public string? Origin { get; set; }
    [JsonPropertyName("coat")]
    public string? Coat { get; set; }
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}
