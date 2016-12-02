using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Repositories;
using Web.ViewModels.Invoice;
using AutoMapper;
using Web.Data.Entities;
using Web.ViewModels;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private int _pageSize = 5;
        public HomeController(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        // GET:/Home/Index/Page{page}
        public IActionResult Index(string successMessage, int page = 1)
        {
            if (!string.IsNullOrEmpty(successMessage))
            {
                ViewBag.SuccessMessage = successMessage;
            }

            var entity = _invoiceRepository.GetLastInvoces();

            var model = new InvoiceListVM
            {
                Invoices = Mapper.Map<IEnumerable<Invoice>, IEnumerable<InvoiceListItemVM>>(entity.Skip((page - 1) * _pageSize).Take(_pageSize)),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = _pageSize,
                    TotalItems = entity.Count()
                }
            };
                
            return View(model);
        }
        
        // GET:/Home/ErrorStatus/{id}
        public IActionResult ErrorStatus(int id)
        {
            return View("ErrorStatus", id);
        }
    }
}