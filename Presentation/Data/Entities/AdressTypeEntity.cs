using System.ComponentModel.DataAnnotations;

namespace Presentation.Data.Entities;

public class AdressTypeEntity
{
    [Key]
    public int Id { get; set; }
    public string AdressType { get; set; } = null!;
}



