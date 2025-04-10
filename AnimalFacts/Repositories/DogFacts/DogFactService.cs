using AnimalFacts.Models;
using Microsoft.Net.Http.Headers;

namespace AnimalFacts.Repositories.DogFacts;

public class DogFactService : IAnimalFacts<DogFactService>
{
    private readonly HttpClient _httpClient;
    private readonly Uri FactsBaseUrl = new("https://dogapi.dog/api/v2");

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

    public Task<Fact> GetRanddomFact(IEnumerable<Parameter> parameters)
    {
        throw new NotImplementedException();
    }
}
