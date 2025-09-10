using CuriTrip.Models;

namespace CuriTrip.UseCases.CreatePasseio;

public class CreatePasseioUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<CreatePasseioResponse>> Do(CreatePasseioPayload payload)
    {
        var user = await ctx.Users.FindAsync(u => u.Id == payload.UserId);

        if (user == null)
            return Result<CreatePasseioResponse>.Fail("User Not Found");

        var passeio = new Passeio
        {
            Name = payload.Name,
            Description = payload.Description,
            UserId = payload.UserId,
            User = user
        };

        ctx.Passeio.Add(passeio);
        await ctx.SaveChangesAsync();
        return Result<CreatePasseioResponse>.Sucess(new(passeio.Id));
    }
}