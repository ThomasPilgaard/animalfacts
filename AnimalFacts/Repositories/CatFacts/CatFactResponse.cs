using System;
using System.Text.Json.Serialization;

namespace AnimalFacts.Repositories.CatFacts;

public class CatFactResponse<T>
{
    [JsonPropertyName("current_page")]
    public int CurrentPage { get; set; }
    [JsonPropertyName("first_page_url")]
    public string? FirstPageUrl { get; set; }
    [JsonPropertyName("from")]
    public int From { get; set; }
    [JsonPropertyName("last_page")]
    public int LastPage { get; set; }
    [JsonPropertyName("last_page_url")]
    public string? LastPageUrl { get; set; }
    [JsonPropertyName("links")]
    public IEnumerable<CatFactLink>? Links { get; set; }
    [JsonPropertyName("next_page_url")]
    public string? NextPageUrl { get; set; }
    [JsonPropertyName("path")]
    public string? Path { get; set; }
    [JsonPropertyName("path_page")]
    public int PathPage { get; set; }
    [JsonPropertyName("prev_page_url")]
    public string? PrevPageUrl { get; set; }
    [JsonPropertyName("to")]
    public int To { get; set; }
    [JsonPropertyName("total")]
    public int Total { get; set; }
    public virtual IEnumerable<T>? Data { get; set; }
}
