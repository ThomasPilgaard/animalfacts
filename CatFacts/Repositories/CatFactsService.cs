using System.Net.Http.Json;
using System.Text;
using CatFacts.Models;
using Microsoft.Net.Http.Headers;

namespace CatFacts.Repositories;

public class CatFactsService : ICatFacts
{
    private readonly HttpClient _httpClient;
    private readonly Uri CatFactsBaseUrl = new("https://catfact.ninja");

    public CatFactsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = CatFactsBaseUrl;
        _httpClient.DefaultRequestHeaders.Add(
            HeaderNames.UserAgent, "HttpRequestsSample");
    }

    public async Task<IEnumerable<Breed>> GetCatBreeds(IEnumerable<Parameter> parameters)
    {
        return await HandlePagination<BreedResponse, Breed>("/breeds", parameters);
    }

    public async Task<IEnumerable<Fact>> GetCatFacts(IEnumerable<Parameter> parameters)
    {
        return await HandlePagination<FactResponse, Fact>("/facts", parameters);
    }

    public async Task<Fact> GetRanddomCatFact(IEnumerable<Parameter> parameters)
    {
        return await MakeGetRequest<Fact>("/fact", parameters);
    }

    private async Task<IEnumerable<E>> HandlePagination<T, E>(string path, IEnumerable<Parameter> parameters)
        where T : CatFactResponse<E>, new()
    {
        var responseData = new List<E>();
        var response = await MakeGetRequest<T>(path, parameters);

        if (response.NextPageUrl is null)
        {
            return response.Data ?? [];
        }

        responseData.AddRange(response.Data ?? []);
        var nextUrl = response.NextPageUrl;

        while (nextUrl is not null)
        {
            Uri nextUri = new(nextUrl);
            response = await MakeGetRequest<T>(nextUri.PathAndQuery, parameters);
            responseData.AddRange(response.Data ?? []);
            nextUrl = response.NextPageUrl;
        }

        return responseData;
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
}
