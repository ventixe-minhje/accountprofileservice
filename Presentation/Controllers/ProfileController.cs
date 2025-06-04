using Microsoft.AspNetCore.Mvc;
using Presentation.Data;
using Presentation.Data.Entities;
using Presentation.Models;

namespace Presentation.Controllers;


// Generated with help from chat GTP 4.0
[ApiController]
[Route("api/profiles")]
public class ProfileController(DataContext context) : ControllerBase
{
    private readonly DataContext _context = context;

    [HttpPost]
    public async Task<IActionResult> Create(UserProfileRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.UserId))
            return BadRequest("UserId is missing.");

        var entity = new ProfileEntity
        {
            UserId = request.UserId!,
            FirstName = request.FirstName,
            LastName = request.LastName
        };

        _context.Profiles.Add(entity);
        await _context.SaveChangesAsync();

        return Ok();
    }
}
