using Presentation.Data.Entities;
using Presentation.Data;

namespace Presentation.Repositories
{
    public interface IContactInfoRepository
    {
        Task<bool> AddAsync(ContactInfoEntity entity);
    }

    public class ContactInfoRepository(DataContext context) : IContactInfoRepository
    {
        private readonly DataContext _context = context;

        public async Task<bool> AddAsync(ContactInfoEntity entity)
        {
            try
            {
                _context.ContactInfos.Add(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
