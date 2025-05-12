using Microsoft.EntityFrameworkCore;
using Presentation.Data.Entities;

namespace Presentation.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<AdressInfoEntity> AdressInfo { get; set; }
    public DbSet<AdressTypeEntity> AdressType { get; set; }
    public DbSet<ContactInfoEntity> ContactInfo { get; set; }
    public DbSet<ContactTypeEntity> ContactType { get; set; }
    public DbSet<ProfileEntity> Profiles { get; set; }
}
