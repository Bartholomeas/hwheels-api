using HWheels.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HWheels.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpGet("me")]
    [Authorize]
    public async Task<IActionResult> GetMe()
    {
        try
        {
            return Ok("xd");
        }
        catch (Exception err)
        {
            return NotFound("xd");
        }
    }
}


// app.MapGet("users/me", async (ClaimsPrincipal claims, AppDbContext context) =>
// {
//     string userId = claims.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
//     return await context.Users.FindAsync(userId);
// }).RequireAuthorization();
