using EstanteVirtual.Domain.Core.ValueObjects;

namespace EstanteVirtual.Domain.Core.Entities;

public class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Birth Birth { get; set; }
}