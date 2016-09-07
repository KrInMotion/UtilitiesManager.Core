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
        void Create(InvoiceProvider entity);
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
            return _context.SaveChanges() > 0;
        }

        public void Create(InvoiceProvider entity)
        {
            _context.InvoiceProviders.Add(entity);
        }

        public IEnumerable<InvoiceProvider> GetAll()
        {
            return _context.InvoiceProviders.ToList();
        }
    }
}
