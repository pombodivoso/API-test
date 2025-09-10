using System.ComponentModel.DataAnnotations;

namespace CuriTrip.UseCases.Login;

public record LoginPayload
{
    [Required]
    public string UserName { get; init; }

    [Required]
    [MinLength(6)]
    public string PassWord { get; init; }
}