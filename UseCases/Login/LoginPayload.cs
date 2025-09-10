using System.ComponentModel.DataAnnotations;

namespace CuriTrip.UseCases.Login;

public record LoginPayload
{
    [Required]
    public string Username { get; init; }

    [Required]
    public string FullName { get; init; }

    [Required]
    [MinLength(6)]
    public string PassWord { get; init; }
}