using System.Text.Json.Serialization;
using AnimalFacts.Models;

namespace AnimalFacts.Repositories.CatFacts;

public class BreedResponse : CatFactResponse<Breed>
{
    [JsonPropertyName("data")]
    public override IEnumerable<Breed>? Data { get; set; }
}
