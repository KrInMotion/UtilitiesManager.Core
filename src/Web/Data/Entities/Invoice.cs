using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Data.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNum { get; set; }
        public string Account { get; set; }
        public int InvoiceTypeId { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }
        public int InvoiceProviderId { get; set; }
        public virtual InvoiceProvider InvoiceProvider { get; set; }
        public int MonthId { get; set; }
        public virtual Month Month { get; set; }
        public int InvoiceYear { get; set; }
        public double InvoiceSum { get; set; }
        public double? PaymentSum { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
