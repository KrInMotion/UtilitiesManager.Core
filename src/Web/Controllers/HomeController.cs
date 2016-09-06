using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Repositories;
using Web.ViewModels.Invoice;
using AutoMapper;
using Web.Data.Entities;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInvoiceRepository _invoiceRep;
        public HomeController(IInvoiceRepository invoiceRep)
        {
            _invoiceRep = invoiceRep;
        }

        // GET:/Home/Index
        public IActionResult Index()
        {
            var entity = _invoiceRep.GetLastInvoces();
            var model = Mapper.Map<IEnumerable<Invoice>, IEnumerable<InvoiceListVM>>(entity);
            return View(model);
        }
        
        // GET:/Home/ErrorStatus/{id}
        public IActionResult ErrorStatus(int id)
        {
            return View("ErrorStatus", id);
        }
    }
}