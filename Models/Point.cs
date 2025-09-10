namespace CuriTrip.Models;

public class Point
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public ICollection<Passeio> AllMyPasseios { get; set; }
}