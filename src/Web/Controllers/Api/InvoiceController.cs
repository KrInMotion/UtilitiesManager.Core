using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Entities;
using Web.Data.Repositories;

namespace Web.Controllers.Api
{
    public class InvoiceController : Controller
    {
        private readonly IMonthRepository _monthRep;
        private readonly IInvoiceRepository _invoiceRep;
        private readonly IInvoiceTypeRepository _invoiceTypeRep;
        private readonly IInvoiceProviderRepository _invoiceProviderRep;

        public InvoiceController(IInvoiceRepository invoiceRep, IInvoiceTypeRepository invoiceTypeRep,
            IInvoiceProviderRepository invoiceProviderRep, IMonthRepository monthRep)
        {
            _invoiceRep = invoiceRep;
            _invoiceTypeRep = invoiceTypeRep;
            _invoiceProviderRep = invoiceProviderRep;
            _monthRep = monthRep;
        }

        [HttpGet("api/invoices")]
        public IActionResult Get()
        {
            var entity = _invoiceRep.GetAll();
            return Ok(entity);
        }
    }
}
