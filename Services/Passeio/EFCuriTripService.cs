using CuriTrip.Models;
using CuriTrip.UseCases.CreatePasseio;
namespace CuriTrip.Services;

public class EFCuriTripService(CuriTripDbContext ctx) : ICuriTripService
{
    public Task<Passeio> CreatePasseio(string Name, string Description, Guid UserId)
    {
        // var user = ctx.Users.FindAsync(u => u.Id == payload.UserId);

        // var passeio = new Passeio
        // {
        //     Name = payload.Name,
        //     Description = payload.Description,
        //     UserId = payload.UserId,
        //     User = user
        // };

        // ctx.Passeio.Add(passeio);
        // ctx.SaveChangesAsync();
        // return passeio.Id;
        throw new NotImplementedException();
    }
}

