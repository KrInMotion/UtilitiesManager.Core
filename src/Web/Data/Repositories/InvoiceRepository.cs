using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data.Repositories
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetLastInvoces();
        bool Commit();
    }

    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly UtilitiesDbContext _context;

        public InvoiceRepository(UtilitiesDbContext context)
        {
            _context = context;

        }
        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetLastInvoces()
        {
            return _context.Invoices
                .Include(x=>x.Month)
                .Include(x=>x.InvoiceType)
                .Include(x=>x.InvoiceProvider)
                .OrderBy(x => x.CreatedAt)
                .Take(20);
        }
    }
}
