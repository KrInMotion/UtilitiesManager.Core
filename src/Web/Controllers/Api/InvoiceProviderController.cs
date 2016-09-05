using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Entities;
using Web.Data.Repositories;
using Web.ViewModels.InvoiceProvider;
using AutoMapper;

namespace Web.Controllers.Api
{
    public class InvoiceProviderController : Controller
    {
        private readonly IInvoiceProviderRepository _invoiceProviderRep;

        public InvoiceProviderController(IInvoiceProviderRepository invoiceProviderRep)
        {
            _invoiceProviderRep = invoiceProviderRep;
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
            if(ModelState.IsValid)
            {
                var entity = Mapper.Map<InvoiceProvider>(model);
                return Created("", Mapper.Map<InvoiceProviderVM>(entity));
            }
            return BadRequest(ModelState);
        }
    }
}
