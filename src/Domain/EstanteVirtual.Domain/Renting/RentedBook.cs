using EstanteVirtual.Domain.Core.Entities;

namespace EstanteVirtual.Domain.Renting;

public class RentedBook : Book
{
    public DateTime RentedAt { get; set; }
    public DateTime ReturnedAt { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}