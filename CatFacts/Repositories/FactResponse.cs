using System.Text.Json.Serialization;
using CatFacts.Models;

namespace CatFacts.Repositories;

public class FactResponse : CatFactResponse<Fact>
{
    [JsonPropertyName("data")]
    public override IEnumerable<Fact>? Data { get; set; }
}
