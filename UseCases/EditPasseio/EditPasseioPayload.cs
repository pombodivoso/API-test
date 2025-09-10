using System.ComponentModel.DataAnnotations;

namespace CuriTrip.UseCases.EditPasseio;

public record EditPasseioPayload
{
    [Required]
    public Guid PasseioId { get; init; }

    [Required]
    public Guid PointId { get; init; }
}