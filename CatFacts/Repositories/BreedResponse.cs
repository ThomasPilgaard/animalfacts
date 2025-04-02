using System.Text.Json.Serialization;
using CatFacts.Models;

namespace CatFacts.Repositories;

public class BreedResponse : CatFactResponse<Breed>
{
    [JsonPropertyName("data")]
    public override IEnumerable<Breed>? Data { get; set; }
}
