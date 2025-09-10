using CuriTrip.Models;

namespace CuriTrip.UseCases.CreatePasseio;

public class CreatePasseioUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<CreatePasseioResponse>> Do(CreatePasseioPayload payload)
    {

    }
}