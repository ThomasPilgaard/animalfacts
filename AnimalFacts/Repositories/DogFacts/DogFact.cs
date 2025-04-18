using System;
using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.DogFacts;

public class DogFact
{
    [JsonPropertyName("body")]
    public string? Message { get; set; }
}
