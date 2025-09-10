using CuriTrip.Models;

namespace CuriTrip.UseCases.SeePasseio;

public class SeePasseioUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<SeePasseioReponse>> Do(SeePasseioPayload payload)
    {
        var passeio = await ctx.Passeio.FindAsync(p => p.Id == payload.PasseioId);

        if (passeio == null)
            return Result<SeePasseioReponse>.Fail("Passeio Not Found");

        return Result<SeePasseioReponse>.Sucess(passeio);
    }
}