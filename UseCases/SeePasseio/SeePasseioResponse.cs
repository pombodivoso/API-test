namespace CuriTrip.UseCases.SeePasseio;

public record SeePasseioReponse(
    string Title,
    string Description,
    IEnumerable<string> PointsNames,
    string CreatorName
);