using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.ViewModels.Invoice;
using Web.Data.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Data.Entities;
using AutoMapper;

namespace Web.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IMonthRepository _monthRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IKindRepository _kindRepository;
        private readonly IProviderRepository _providerRepository;
        public InvoiceController(IInvoiceRepository invoiceRepository, IKindRepository kindRepostory, 
            IProviderRepository providerRepository, IMonthRepository monthRepository)
        {
            _invoiceRepository = invoiceRepository;
            _kindRepository = kindRepostory;
            _providerRepository = providerRepository;
            _monthRepository = monthRepository;
        }

        [NonAction]
        protected void PrepareInvoiceModel(InvoiceFormVM model)
        {
            foreach (var item in _kindRepository.GetAll())
            {
                model.KindList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.KindName });
            }
            foreach (var item in _providerRepository.GetAll())
            {
                model.ProviderList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.ProviderName });
            }
            foreach (var item in _monthRepository.GetAll())
            {
                model.MonthList.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.MonthName });
            }

        }

        // GET: /Invoice/Index
        public IActionResult Index()
        {
            return View();
        }

        //GET: /Invoice/Create
        [HttpGet]
        public IActionResult Create()
        {
            var model = new InvoiceFormVM();
            model.MonthId = DateTime.Now.Month;
            model.Year = DateTime.Now.Year;
            PrepareInvoiceModel(model);

            return View(model);
        }

        //POST: /Invoice/Create
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(InvoiceFormVM model)
        {
            if(ModelState.IsValid)
            {
                var entity = Mapper.Map<InvoiceFormVM, Invoice>(model);
                entity.CreatedAt = DateTime.Now;
                _invoiceRepository.Create(entity);
                _invoiceRepository.Commit();
                RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        //GET: /Invoice/Copy/Id
        [HttpGet]
        public IActionResult Copy(int id)
        {
            var entity = _invoiceRepository.GetById(id);
            if (entity == null)
                return BadRequest();
            var model = Mapper.Map<Invoice, InvoiceFormVM>(entity);
            model.Id = 0;
            PrepareInvoiceModel(model);

            return View(model);
        }

        //POST: /Invoice/Copy
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Copy(InvoiceFormVM model)
        {
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<InvoiceFormVM, Invoice>(model);
                entity.UpdatedAt = DateTime.Now;
                _invoiceRepository.Create(entity);
                _invoiceRepository.Commit();
                RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
