using Microsoft.AspNetCore.Identity;

namespace HWheels.Database;

public class User : IdentityUser
{
    public string? Initials { get; set; }
}