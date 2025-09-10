namespace CuriTrip.UseCases.SeePasseio;

public record SeePasseioReponse(
    string Title,
    string Description,
    List<string> PointsNames,
    string CreatorName
);