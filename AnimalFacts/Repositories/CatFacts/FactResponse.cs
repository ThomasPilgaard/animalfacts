using System.Text.Json.Serialization;
using AnimalFacts.Models;

namespace AnimalFacts.Repositories.CatFacts;

public class FactResponse : CatFactResponse<Fact>
{
    [JsonPropertyName("data")]
    public override IEnumerable<Fact>? Data { get; set; }
}
