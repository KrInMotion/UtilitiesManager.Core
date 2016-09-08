using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data.Repositories
{
    public interface IProviderRepository
    {
        IEnumerable<Provider> GetAll();
        bool Commit();
        void Create(Provider entity);
    }

    public class ProviderRepository : IProviderRepository
    {
        private readonly UtilitiesDbContext _context;

        public ProviderRepository(UtilitiesDbContext context)
        {
            _context = context;

        }
        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Create(Provider entity)
        {
            _context.Providers.Add(entity);
        }

        public IEnumerable<Provider> GetAll()
        {
            return _context.Providers.ToList();
        }
    }
}
