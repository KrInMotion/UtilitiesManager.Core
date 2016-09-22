using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Data.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Account { get; set; }
        public int KindId { get; set; }
        public virtual Kind Kind { get; set; }
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }
        public int MonthId { get; set; }
        public virtual Month Month { get; set; }
        public int Year { get; set; }
        public decimal Sum { get; set; }
        public decimal Debt { get; set; }
        public decimal Penalty { get; set; }
        public decimal PaymentSum { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
