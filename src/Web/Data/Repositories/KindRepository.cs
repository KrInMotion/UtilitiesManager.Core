using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data.Repositories
{
    public interface IKindRepository
    {
        IEnumerable<Kind> GetAll();
        IEnumerable<Kind> GetByName(string name);
        Kind Get(int id);
        bool Commit();
        void Create(Kind entity);
    }

    public class KindRepository : IKindRepository
    {
        private readonly UtilitiesDbContext _context;

        public KindRepository(UtilitiesDbContext context)
        {
            _context = context;

        }
        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public Kind Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kind> GetAll()
        {
            return _context.Kinds.ToList();
        }

        public IEnumerable<Kind> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Create(Kind entity)
        {
            throw new NotImplementedException();
        }
    }
}
