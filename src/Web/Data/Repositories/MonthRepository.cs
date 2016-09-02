using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data.Repositories
{
    public interface IMonthRepository
    {
        IEnumerable<Month> GetAll();
        bool Commit();
    }

    public class MonthRepository : IMonthRepository
    {
        private readonly UtilitiesDbContext _context;

        public MonthRepository(UtilitiesDbContext context)
        {
            _context = context;

        }
        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Month> GetAll()
        {
            return _context.Months.ToList();
        }
    }
}
