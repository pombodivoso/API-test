using Microsoft.AspNetCore.Mvc;
using CuriTrip.UseCases.Login;
using CuriTrip;
namespace CuriTrip.EndPoints;
public static class AuthEndPoints
{
    public static void ConfigureAuthEndPoints(this WebApplication app)
    {
        app.MapPost("auth", async(
            [FromBody]LoginPayload payload,
            [FromServices]LoginUseCase useCase) =>
            {
                var result = await useCase.Do(payload);
                if (!result.IsSucess)
                    return Results.BadRequest();

                return Results.Ok(result.Data);
            }
        );
    }
}