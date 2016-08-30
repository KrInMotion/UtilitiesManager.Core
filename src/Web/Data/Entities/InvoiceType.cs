using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Data.Entities
{
    public class InvoiceType
    {
        public InvoiceType()
        {
            Invoices = new List<Invoice>();
        }
        public int Id { get; set; }
        public string InvoiceTypeName { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
