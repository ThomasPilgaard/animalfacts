using System.Diagnostics;

namespace AnimalFacts.Models;

[DebuggerDisplay("{Name}")]
public class Breed
{
    public string? Name { get; set; }
}
