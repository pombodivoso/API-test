using CuriTrip.Models;
using CuriTrip.UseCases.CreatePasseio;
namespace CuriTrip.Services;

public class EFCuriTripService(CuriTripDbContext ctx) : ICuriTripService
{
    public Task<Passeio> CreatePasseio(CreatePasseioPayload payload)
    {
        // var user = ctx.Users.FindAsync(u => u.Id == payload.UserId);

        // if (user == null)
        //     return "User Not Found";

        // var passeio = new Passeio
        // {
        //     Name = payload.Name,
        //     Description = payload.Description,
        //     UserId = payload.UserId,
        //     User = user
        // };

        // ctx.Passeio.Add(passeio);
        // ctx.SaveChangesAsync();
        // await return new(passeio);
        throw new NotImplementedException();
        //os retornos não funcionam por nada
    }
}

