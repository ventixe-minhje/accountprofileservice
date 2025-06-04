namespace Presentation.Models;

public class UserProfileRequest
{
    public string? UserId { get; set; } 
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}
