using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.CatFacts;

public class BreedResponse : CatFactResponse<CatBreed>
{
    [JsonPropertyName("data")]
    public override IEnumerable<CatBreed>? Data { get; set; }
}
