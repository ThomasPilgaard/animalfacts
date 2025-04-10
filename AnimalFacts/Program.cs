using AnimalFacts.Models;
using AnimalFacts.Repositories;
using AnimalFacts.Repositories.CatFacts;
using AnimalFacts.Repositories.DogFacts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHttpClient<IAnimalFacts<CatFactsService>, CatFactsService>();
builder.Services.AddHttpClient<IAnimalFacts<DogFactService>, DogFactService>();

using IHost host = builder.Build();

var catFacts = host.Services.GetService<IAnimalFacts<CatFactsService>>();
var dogFacts = host.Services.GetService<IAnimalFacts<DogFactService>>();


if (catFacts is null)
{
    Console.WriteLine("No catfacts registered!");
    return;
}

if (dogFacts is null)
{
    Console.WriteLine("No dogfacts registered!");
    return;
}

var parametersCatFact = new List<Parameter>()
{
    //new() {Name = "max_length", Value = "20"}
};
Fact randomCatFact = await catFacts.GetRanddomFact(parametersCatFact);

var parametersCatFacts = new List<Parameter>()
{
    //new() {Name = "max_length", Value = "20"},
    //new() {Name = "limit", Value = "1"}
};
IEnumerable<Fact> allCatFacts = await catFacts.GetFacts(parametersCatFacts);

var parametersCatBreeds = new List<Parameter>()
{
    //new() {Name = "limit", Value = "1"}
};
IEnumerable<Breed> catBreeds = await catFacts.GetBreeds(parametersCatBreeds);

Console.WriteLine($"Got random CatFact: '{randomCatFact.Message}' with length: {randomCatFact.Length} characters.");
Console.WriteLine($"Got {allCatFacts.Count()} cat facts! The first one being: '{allCatFacts.FirstOrDefault()?.Message}'");
Console.WriteLine($"Got {catBreeds.Count()} cat breeds! The first one being: '{catBreeds.FirstOrDefault()?.Name}'");
