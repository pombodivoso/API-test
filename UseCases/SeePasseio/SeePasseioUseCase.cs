using CuriTrip.Models;

namespace CuriTrip.UseCases.SeePasseio;

public class SeePasseioUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<SeePasseioReponse>> Do(SeePasseioPayload payload)
    {
        
    }
}