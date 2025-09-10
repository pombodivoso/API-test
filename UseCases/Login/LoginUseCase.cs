using CuriTrip.Models;
using CuriTrip.Services.JWT;

namespace CuriTrip.UseCases.Login;

public class LoginUseCase(CuriTripDbContext ctx)
{
    public async Task<Result<LoginReponse>> Do(LoginPayload payload)
    {
        var user = ctx.Users.FirstOrDefault(u => u.Name == payload.UserName);

        if (user == null)
            return Result<LoginReponse>.Fail("User Not Found");

        var jwt = JWTService.CreateToken(new(
            user.Id, user.Name
        ));

        return Result<LoginReponse>.Sucess(new LoginReponse(jwt));
    }
}