using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data.Repositories
{
    public interface IInvoiceProviderRepository
    {
        IEnumerable<InvoiceProvider> GetAll();
        bool Commit();
    }

    public class InvoiceProviderRepository : IInvoiceProviderRepository
    {
        private readonly UtilitiesDbContext _context;

        public InvoiceProviderRepository(UtilitiesDbContext context)
        {
            _context = context;

        }
        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceProvider> GetAll()
        {
            return _context.InvoiceProviders.ToList();
        }
    }
}
