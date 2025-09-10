using CuriTrip.Models;

namespace CuriTrip.UseCases.Login;

public class LoginUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<LoginReponse>> Do(LoginPayload payload)
    {
        
    }
}