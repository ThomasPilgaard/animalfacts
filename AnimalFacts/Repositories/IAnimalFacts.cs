using AnimalFacts.Models;

namespace AnimalFacts.Repositories
{
    public interface IAnimalFacts<T>
    {
        Task<IEnumerable<Fact>> GetFacts(IEnumerable<Parameter> parameters);
        Task<Fact> GetRanddomFact(IEnumerable<Parameter> parameters);
        Task<IEnumerable<Breed>> GetBreeds(IEnumerable<Parameter> parameters);
    }
}
