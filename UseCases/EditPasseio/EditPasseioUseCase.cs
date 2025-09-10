using CuriTrip.Models;

namespace CuriTrip.UseCases.EditPasseio;

public class EditPasseioUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<EditPasseioResponse>> Do(EditPasseioResponse payload)
    {
        
    }
}