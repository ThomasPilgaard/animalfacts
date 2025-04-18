using System.Net.Http.Json;
using System.Text;
using AnimalFacts.Models;
using Microsoft.Net.Http.Headers;

namespace AnimalFacts.Repositories.DogFacts;

public class DogFactService : IAnimalFacts<DogFactService>
{
    private readonly HttpClient _httpClient;
    private readonly Uri FactsBaseUrl = new("https://dogapi.dog/api/v2/");

    public DogFactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = FactsBaseUrl;
        _httpClient.DefaultRequestHeaders.Add(
            HeaderNames.UserAgent, "HttpRequestsSample");
    }

    public Task<IEnumerable<Breed>> GetBreeds(IEnumerable<Parameter> parameters)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Fact>> GetFacts(IEnumerable<Parameter> parameters)
    {
        throw new NotImplementedException();
    }

    public async Task<Fact> GetRanddomFact(IEnumerable<Parameter> parameters)
    {
        var fact = await MakeGetRequest<DogResponse<DogFact>>("facts", parameters);
        return ConvertDogFactToFact(fact.Data.FirstOrDefault().Attributes);
    }

    private async Task<T> MakeGetRequest<T>(string path, IEnumerable<Parameter> parameters) where T : new()
    {
        var queryString = QueryBuilder(parameters);
        return await _httpClient.GetFromJsonAsync<T>($"{path}{queryString}") ?? new T();
    }

    private static string QueryBuilder(IEnumerable<Parameter> parameters)
    {
        var queryString = new StringBuilder();

        foreach (var param in parameters)
        {
            if (parameters.First() == param)
            {
                queryString.Append('?');
            }
            else
            {
                queryString.Append('&');
            }

            queryString.Append($"{param.Name}={param.Value}");
        }

        return queryString.ToString();
    }

    private static Fact ConvertDogFactToFact(DogFact fact)
    {
        return new Fact
        {
            Message = fact.Message,
            Length = !string.IsNullOrWhiteSpace(fact.Message) ? fact.Message.Length : 0
        };
    }
}
