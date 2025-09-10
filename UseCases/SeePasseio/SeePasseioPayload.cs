using System.ComponentModel.DataAnnotations;

namespace CuriTrip.UseCases.SeePasseio;

public record SeePasseioPayload
{
    [Required]
    public Guid PasseioId { get; init; }	
}
