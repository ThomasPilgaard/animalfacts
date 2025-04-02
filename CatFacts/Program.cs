using CatFacts.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHttpClient<ICatFacts, CatFactsService>();

using IHost host = builder.Build();

var catFacts = host.Services.GetService<ICatFacts>();

if (catFacts is null)
{
    Console.WriteLine("No catfacts registered!");
    return;
}

var parametersCatFact = new List<Parameter>()
{
    //new() {Name = "max_length", Value = "20"}
};
var randomFact = await catFacts.GetRanddomCatFact(parametersCatFact);

var parametersCatFacts = new List<Parameter>()
{
    //new() {Name = "max_length", Value = "20"},
    //new() {Name = "limit", Value = "1"}
};
var allFacts = await catFacts.GetCatFacts(parametersCatFacts);

var parametersCatBreeds = new List<Parameter>()
{
    //new() {Name = "limit", Value = "1"}
};
var breeds = await catFacts.GetCatBreeds(parametersCatBreeds);
