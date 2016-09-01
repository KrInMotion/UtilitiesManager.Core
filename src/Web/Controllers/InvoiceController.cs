using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels.Invoice;
using Web.Data.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceRepository _invoiceRep;
        private readonly IInvoiceTypeRepository _invoiceTypeRep;
        public InvoiceController(IInvoiceRepository invoiceRep, IInvoiceTypeRepository invoiceTypeRep)
        {
            _invoiceRep = invoiceRep;
            _invoiceTypeRep = invoiceTypeRep;
        }

        // GET: /Invoice/Index
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var invoiceTypeList = new List<SelectListItem>();
            foreach (var item in _invoiceTypeRep.GetInvoiceTypes())
            {
                invoiceTypeList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.InvoiceTypeName });
            }
            var model = new InvoiceFormVM
            {
                InvoiceTypeList = invoiceTypeList
            };
            return View(model);
        }
    }
}
