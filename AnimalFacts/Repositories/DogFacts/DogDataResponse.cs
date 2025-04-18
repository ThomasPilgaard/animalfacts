using System;
using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.DogFacts;

public class DogDataResponse<T>
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("attributes")]
    public T? Attributes { get; set; }
}
