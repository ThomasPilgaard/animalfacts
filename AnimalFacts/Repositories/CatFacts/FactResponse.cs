using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.CatFacts;

public class FactResponse : CatFactResponse<CatFact>
{
    [JsonPropertyName("data")]
    public override IEnumerable<CatFact>? Data { get; set; }
}
