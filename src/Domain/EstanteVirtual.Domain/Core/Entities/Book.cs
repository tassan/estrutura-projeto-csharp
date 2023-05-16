using EstanteVirtual.Domain.Core.ValueObjects;

namespace EstanteVirtual.Domain.Core.Entities;

public class Book : Entity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }
    public string Isbn { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Author} - {Publisher} - {Year} - {Isbn}";
    }
}