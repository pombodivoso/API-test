namespace CuriTrip;

public record Result<T>(
    T Data,
    bool IsSucess,
    string Reason
)
{
    public static Result<T> Sucess(T data)
        => new(data, true, null);

    public static Result<T> Fail(string Reason)
        => new(default, true, Reason);
}