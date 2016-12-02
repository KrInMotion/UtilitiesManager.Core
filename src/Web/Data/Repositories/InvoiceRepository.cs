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
        IEnumerable<Invoice> GetAll();

        bool Commit();
        void Create(Invoice entity);
        Invoice GetById(int id, bool includeDependencies=false);
        Invoice GetByIdNoTrack(int id, bool includeDependencies = false);
        void Delete(Invoice entity);
        void Update(Invoice entity);
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
            return _context.SaveChanges()>0;
        }

        public void Create(Invoice entity)
        {
            _context.Invoices.Add(entity);
        }

        public Invoice GetById(int id, bool includeDependencies = false)
        {
            if (includeDependencies)
            {
                return _context.Invoices
                    .Include(x=>x.Kind)
                    .Include(x=>x.Month)
                    .Include(x=>x.Provider)
                    .SingleOrDefault(x => x.Id == id);
            }
            else
            {
                return _context.Invoices.SingleOrDefault(x => x.Id == id);
            }
        }
        public Invoice GetByIdNoTrack(int id, bool includeDependencies = false)
        {
            if (includeDependencies)
            {
                return _context.Invoices
                    .AsNoTracking()
                    .Include(x => x.Kind)
                    .Include(x => x.Month)
                    .Include(x => x.Provider)
                    .SingleOrDefault(x => x.Id == id);
            }
            else
            {
                return _context.Invoices
                    .AsNoTracking()
                    .SingleOrDefault(x => x.Id == id);
            }
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _context.Invoices
                .Include(x => x.Month)
                .Include(x => x.Kind)
                .Include(x => x.Provider)
                .ToList();
        }

        public IEnumerable<Invoice> GetLastInvoces()
        {
            return _context.Invoices
                .Include(x=>x.Month)
                .Include(x=>x.Kind)
                .Include(x=>x.Provider)
                .OrderBy(x => x.CreatedAt);
        }

        public void Delete(Invoice entity)
        {
            _context.Invoices.Remove(entity);
        }

        public void Update(Invoice entity)
        {
            _context.Invoices.Attach(entity);
            _context.Entry<Invoice>(entity).State = EntityState.Modified;
        }
    }
}
