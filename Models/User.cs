namespace CuriTrip.Models;

public class User
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string FullName { get; set; }
    public required string Password { get; set; }
    public ICollection<Passeio> AllPasseios { get; set; }
}