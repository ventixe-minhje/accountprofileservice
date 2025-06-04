namespace Presentation.Models;

public class ContactInfoRequest
{
    public string UserId { get; set; } = null!;
    public int ContactTypeId { get; set; }
    public string? Value { get; set; }
}
