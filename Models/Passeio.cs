namespace CuriTrip.Models;

public class Passeio
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public ICollection<Point> AllPoints { get; set; }
    public Guid UserId { get; set; }
    public required User User { get; set; }
}