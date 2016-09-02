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

        [NonAction]
        protected void PrepareInvoiceModel(InvoiceFormVM model)
        {
            model.MonthId = DateTime.Now.Month;
            model.Year = DateTime.Now.Year;
            foreach (var item in _invoiceTypeRep.GetAll())
            {
                model.InvoiceTypeList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.InvoiceTypeName });
            }
            foreach (var item in _invoiceProviderRep.GetAll())
            {
                model.InvoiceProviderList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.InvoiceProviderName });
            }
            foreach (var item in _monthRep.GetAll())
            {
                model.MonthList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.MonthName });
            }

        }

        // GET: /Invoice/Index
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new InvoiceFormVM();
            PrepareInvoiceModel(model);

            return View(model);
        }
    }
}
