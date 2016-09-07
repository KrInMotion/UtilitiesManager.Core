using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Entities;
using Web.Data.Repositories;
using Web.ViewModels.InvoiceProvider;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Api
{
    public class InvoiceProviderController : Controller
    {
        private readonly IInvoiceProviderRepository _invoiceProviderRep;
        private readonly ILogger<InvoiceProviderController> _logger;

        public InvoiceProviderController(IInvoiceProviderRepository invoiceProviderRep, ILogger<InvoiceProviderController> logger)
        {
            _invoiceProviderRep = invoiceProviderRep;
            _logger = logger;
        }

        [HttpGet("api/invoiceProviders")]
        public IActionResult Get()
        {
            var entities = _invoiceProviderRep.GetAll();
            return Ok(Mapper.Map<IEnumerable<InvoiceProviderVM>>(entities));
        }

        [HttpPost("api/invoiceProviders")]
        public IActionResult Post([FromBody] InvoiceProviderVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = Mapper.Map<InvoiceProvider>(model);
                    _invoiceProviderRep.Create(entity);
                    _invoiceProviderRep.Commit();
                    return Created("", Mapper.Map<InvoiceProviderVM>(entity));
                }
            } catch (Exception ex)
            {
                _logger.LogError($"Failed to post invoice provider {ex.Message}");
                return BadRequest(ex.Message);
            }
            return BadRequest(ModelState);
        }
    }
}
