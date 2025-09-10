using System.ComponentModel.DataAnnotations;

namespace CuriTrip.UseCases.CreatePasseio;

public record CreatePasseioPayload
{
    [Required]
    [MaxLength(20)]
    public string Name { get; init; }

    [Required]
    [MinLength(40)]
    [MaxLength(200)]
    public string Description { get; init; }

    [Required]
    public Guid UserId { get; init; }
}