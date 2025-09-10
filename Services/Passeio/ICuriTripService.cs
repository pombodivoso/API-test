using CuriTrip.Models;
namespace CuriTrip.Services;

public interface ICuriTripService
{
    Task<Passeio> CreatePasseio(string Name, string Description, Guid UserId);
}