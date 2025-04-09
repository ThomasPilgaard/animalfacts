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
var randomFact = await catFacts.GetRanddomFact(parametersCatFact);

var parametersCatFacts = new List<Parameter>()
{
    //new() {Name = "max_length", Value = "20"},
    //new() {Name = "limit", Value = "1"}
};
var allFacts = await catFacts.GetFacts(parametersCatFacts);

var parametersCatBreeds = new List<Parameter>()
{
    //new() {Name = "limit", Value = "1"}
};
var breeds = await catFacts.GetBreeds(parametersCatBreeds);

Console.WriteLine($"Got {allFacts.Count()} cat facts! The first one being: '{allFacts.FirstOrDefault()?.Message}'");
Console.WriteLine($"Got {breeds.Count()} cat breeds! The first one being: '{breeds.FirstOrDefault()?.Name}'");
