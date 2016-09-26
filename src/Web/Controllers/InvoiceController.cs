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

        //GET: /Invoice/Detail/id
        public IActionResult Detail(int id)
        {
            var entity = _invoiceRepository.GetByIdNoTrack(id, includeDependencies: true);
            if (entity == null)
                return NotFound();
            var model = Mapper.Map<Invoice, InvoiceDetailVM>(entity);
            return View(model);
        }

        //GET: /Invoice/Create
        [HttpGet]
        public IActionResult Create()
        {
            var model = new InvoiceFormVM();
            model.Number = "Без номера";
            model.MonthId = DateTime.Now.Month;
            model.Year = DateTime.Now.Year;
            PrepareInvoiceModel(model);
            return View(model);
        }

        //POST: /Invoice/Create
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(InvoiceFormVM model)
        {
            if(model.PaymentSum!=0 && model.PaymentDate==null)
                ModelState.AddModelError("", "Указана сумма оплаты, но не указана дата оплаты!");
            if(ModelState.IsValid)
            {
                var entity = Mapper.Map<InvoiceFormVM, Invoice>(model);
                entity.CreatedAt = DateTime.Now;
                _invoiceRepository.Create(entity);
                _invoiceRepository.Commit();
                return RedirectToAction("Index", "Home", new { statusMessage = "Документ успешно создан" });
            }
            PrepareInvoiceModel(model);
            return View(model);
        }

        //GET: /Invoice/Edit/Id
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var entity = _invoiceRepository.GetByIdNoTrack(id);
            if (entity == null)
                return NotFound();
            var model = Mapper.Map<Invoice, InvoiceFormVM>(entity);
            PrepareInvoiceModel(model);
            return View(model);
        }

        //POST: /Invoice/Edit
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(InvoiceFormVM model)
        {
            if (_invoiceRepository.GetByIdNoTrack(model.DocumentId, true) == null)
                return NotFound();
            if (model.PaymentSum != 0 && model.PaymentDate == null)
                ModelState.AddModelError("", "Указана сумма оплаты, но не указана дата оплаты!");
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<InvoiceFormVM, Invoice>(model);
                entity.Id = model.DocumentId;
                entity.UpdatedAt = DateTime.Now;
                _invoiceRepository.Update(entity);
                _invoiceRepository.Commit();
                return RedirectToAction("Index", "Home", new { statusMessage = "Документ отредактирован" });
            }
            PrepareInvoiceModel(model);
            return View(model);
        }

        //GET: /Invoice/Copy/Id
        [HttpGet]
        public IActionResult Copy(int id)
        {
            var entity = _invoiceRepository.GetByIdNoTrack(id);
            if (entity == null)
                return BadRequest();
            var model = Mapper.Map<Invoice, InvoiceFormVM>(entity);
            PrepareInvoiceModel(model);
            return View("create", model);
        }

        //GET: /Invoice/Delete/Id
        [HttpGet]
        public IActionResult Delete(int id, string errorMessage)
        {
            var entity = _invoiceRepository.GetByIdNoTrack(id, true);
            if (entity == null)
                return NotFound();
            var model = Mapper.Map<Invoice, InvoiceDetailVM>(entity);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                ViewBag.ErrorMessage = $"К сожалению возникла ошибка: {errorMessage}";
            }
            return View(model);
        }

        //POST: /Invoice/Delete/Id
        [HttpPost, ValidateAntiForgeryToken, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var entity = _invoiceRepository.GetByIdNoTrack(id, includeDependencies: false);
            if (entity == null)
                return NotFound();
            try
            {
                _invoiceRepository.Delete(entity);
                _invoiceRepository.Commit();
                return RedirectToAction("Index", "Home", new { statusMessage = "Документ успешно удален" });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Delete", new { id = id, errorMessage = ex.Message });
            }
        }
    }
}
