using CuriTrip.Models;

namespace CuriTrip.UseCases.EditPasseio;

public class EditPasseioUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<EditPasseioResponse>> Do(EditPasseioPayload payload)
    {
        var passeio = await ctx.Passeio.FindAsync(p => p.Id == payload.PasseioId);

        if (passeio == null)
            return Result<EditPasseioResponse>.Fail("Passeio Not Found");

        var point = await ctx.Points.FindAsync(p => p.Id == payload.PointId);
        //por que AS flechas não funcionam?

        if (point == null)
            return Result<EditPasseioResponse>.Fail("Point Not Found");

        passeio.AllPoints.Add(point);
        await ctx.SaveChangesAsync();

        return Result<EditPasseioResponse>.Sucess(null);
    }
}