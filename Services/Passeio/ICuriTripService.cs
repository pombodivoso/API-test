using CuriTrip.Models;
namespace CuriTrip.Services;
using CuriTrip.UseCases.CreatePasseio;

public interface ICuriTripService
{
    Task<Passeio> CreatePasseio(CreatePasseioPayload payload);
}