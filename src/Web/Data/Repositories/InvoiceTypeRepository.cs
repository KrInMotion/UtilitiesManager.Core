using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data.Entities;

namespace Web.Data.Repositories
{
    public interface IInvoiceTypeRepository
    {
        IEnumerable<InvoiceType> GetInvoiceTypes();
        IEnumerable<InvoiceType> GetInvoiceTypesByName(string name);
        InvoiceType GetInvoiceType(int id);
        bool Commit();
        void SaveInvoiceType(InvoiceType entity);
    }

    public class InvoiceTypeRepository : IInvoiceTypeRepository
    {
        private readonly UtilitiesDbContext _context;

        public InvoiceTypeRepository(UtilitiesDbContext context)
        {
            _context = context;

        }
        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public InvoiceType GetInvoiceType(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceType> GetInvoiceTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceType> GetInvoiceTypesByName(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveInvoiceType(InvoiceType entity)
        {
            throw new NotImplementedException();
        }
    }
}
