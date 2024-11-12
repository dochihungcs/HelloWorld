namespace HelloWorld.Application.Security.Clients;

public interface ICurrentClient
{
    string? Id { get; }

    bool IsAuthenticated { get; }
}
