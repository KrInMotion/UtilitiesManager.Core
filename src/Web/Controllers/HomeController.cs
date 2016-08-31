using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Repositories;
using Web.ViewModels.Invoice;

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
            var model = new List<InvoiceListVM>();
            foreach (var item in entity)
            {
                model.Add(new InvoiceListVM
                {
                    Id = item.Id,
                    InvoiceNum = item.InvoiceNum,
                    InvoiceProviderName = item.InvoiceProvider.InvoiceProviderName,
                    InvoiceTypeName = item.InvoiceType.InvoiceTypeName,
                    InvoiceDate = $"{item.Month.MonthName} {item.InvoiceYear.ToString()}",
                    InvoiceSum = item.InvoiceSum,
                    PaymentSum = item.PaymentSum
                });
            }
            return View(model);
        }
        
        // GET:/Home/ErrorStatus/{id}
        public IActionResult ErrorStatus(int id)
        {
            return View("ErrorStatus", id);
        }
    }
}