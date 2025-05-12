using Microsoft.EntityFrameworkCore;
using Presentation.Data;
using Presentation.Data.Entities;

namespace Presentation.Repositories;

public abstract class BaseRepository<TEntity> where TEntity : class
{
    protected readonly DataContext _context;
    protected readonly DbSet<TEntity> _table;

    protected BaseRepository(DataContext context)
    {
        _context = context;
        _table = _context.Set<TEntity>();
    }
}

public class ProfileRepository(DataContext context) : BaseRepository<ProfileEntity>(context), IProfileRepository 
{
}
