using Microsoft.EntityFrameworkCore;
using Presentation.Data.Entities;

namespace Presentation.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<ProfileEntity> Profiles { get; set; }
    public DbSet<ContactTypeEntity> ContactType { get; set; }
    public DbSet<ContactInfoEntity> ContactInfos { get; set; }
    public DbSet<AdressTypeEntity> AdressTypes { get; set; }
    public DbSet<AdressInfoEntity> AdressInfos { get; set; }
}
