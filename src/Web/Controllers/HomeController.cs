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
        private readonly IInvoiceRepository _invoiceRepository;
        public HomeController(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        // GET:/Home/Index
        public IActionResult Index(string statusMessage)
        {
            if (!string.IsNullOrEmpty(statusMessage))
            {
                ViewBag.StatusMessage = statusMessage;
            }

            var entity = _invoiceRepository.GetLastInvoces();
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