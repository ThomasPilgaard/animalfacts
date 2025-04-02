using CatFacts.Models;

namespace CatFacts.Repositories;

public interface ICatFacts
{
    Task<IEnumerable<Fact>> GetCatFacts(IEnumerable<Parameter> parameters);
    Task<Fact> GetRanddomCatFact(IEnumerable<Parameter> parameters);
    Task<IEnumerable<Breed>> GetCatBreeds(IEnumerable<Parameter> parameters);
}
