using System.Security.Claims;

namespace HelloWorld.Application.Security.Users;

public class CurrentUser : ICurrentUser
{
    public bool IsAuthenticated { get; }
    public Guid? Id { get; }
    public string? UserName { get; }
    public string? Name { get; }
    public string? SurName { get; }
    public string? PhoneNumber { get; }
    public bool PhoneNumberVerified { get; }
    public string? Email { get; }
    public bool EmailVerified { get; }
    public Guid? TenantId { get; }
    public string[] Roles { get; }
    
    public Claim? FindClaim(string claimType)
    {
        throw new NotImplementedException();
    }

    public Claim[] FindClaims(string claimType)
    {
        throw new NotImplementedException();
    }

    public Claim[] GetAllClaims()
    {
        throw new NotImplementedException();
    }

    public bool IsInRole(string roleName)
    {
        throw new NotImplementedException();
    }
}
