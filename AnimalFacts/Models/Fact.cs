using System.Diagnostics;

namespace AnimalFacts.Models;

[DebuggerDisplay("{Message}")]
public class Fact
{
    public string? Message { get; set; }
    public int Length { get; set; }
}
