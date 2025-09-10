using Microsoft.AspNetCore.Mvc;
using CuriTrip.UseCases.CreatePasseio;
using CuriTrip.UseCases.SeePasseio;
using CuriTrip.UseCases.EditPasseio;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace CuriTrip.EndPoints;
public static class CuriTripEndPoints
{
    public static void ConfigureCuriTripEndPoints(this WebApplication app)
    {
        //CREATE PASSEIO - POST: /user/{id}/passeio/create
        app.MapGet("user/{id}/passeio/create", async (
            Guid id,
            HttpContext http,
            [FromBody] CreatePasseioPayload payload,
            [FromServices] CreatePasseioUseCase useCase
        ) =>
        {
            var result = await useCase.Do(payload);
            if (result.IsSucess)
                return Results.Created();

            return Results.BadRequest();
        });


        //EDIT PASSEIO - PUT: /user/{id}/passeio/{id}/edit
        app.MapGet("user/{userId}/passeio/{passeioId}/{pointId}/edit", async (
            Guid userId,
            Guid passeioId,
            Guid pointId,
            HttpContext http,
            [FromBody] EditPasseioPayload payload,
            [FromServices] EditPasseioUseCase useCase
        ) =>
        {
            var userIdClaim = http.User.FindFirst(ClaimTypes.NameIdentifier);
            var UserId = userIdClaim != null ? Guid.Parse(userIdClaim.Value) : Guid.Empty;

            payload = payload with { PasseioId = passeioId, PointId = pointId};

            var result = await useCase.Do(payload);

            if (result.IsSucess)
                return Results.Ok(result);

            return Results.BadRequest();
        });


        //SEE PASSEIO - GET: /user/{id}/passeio/{id}
        app.MapGet("user/{userId}/passeio/{passeioId}", async (
            Guid userId,
            Guid passeioId,
            HttpContext http,
            [FromServices] SeePasseioUseCase useCase
        ) =>
        {
            var userIdClaim = http.User.FindFirst(ClaimTypes.NameIdentifier);
            var UserId = userIdClaim != null ? Guid.Parse(userIdClaim.Value) : Guid.Empty;

            var payload = new SeePasseioPayload
            {
                PasseioId = passeioId,
            };

            var result = await useCase.Do(payload);

            if (result.IsSucess)
                return Results.Ok(result);

            return Results.BadRequest();
        });
    }
}