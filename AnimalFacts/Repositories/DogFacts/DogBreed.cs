using System;
using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.DogFacts;

public class DogBreed
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("hypoallergenic")]
    public bool Hypoallergenic { get; set; }
}
