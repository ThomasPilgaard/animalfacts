using System;
using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.DogFacts;

public class DogResponse<T>
{
    [JsonPropertyName("data")]
    public IEnumerable<DogDataResponse<T>>? Data { get; set; }
}
