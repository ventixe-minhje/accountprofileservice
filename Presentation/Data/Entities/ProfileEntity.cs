using System.ComponentModel.DataAnnotations;

namespace Presentation.Data.Entities;

public class ProfileEntity
{
    [Key]
    public string UserId { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}



