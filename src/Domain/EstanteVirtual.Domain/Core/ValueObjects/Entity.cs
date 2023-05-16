namespace EstanteVirtual.Domain.Core.ValueObjects;

public class Entity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool Deleted { get; set; }
}