using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Entities;
using Web.Data.Repositories;
using Web.ViewModels.Provider;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Web.Controllers.Api
{
    public class ProviderController : Controller
    {
        private readonly IProviderRepository _providerRepository;
        private readonly ILogger<ProviderController> _logger;

        public ProviderController(IProviderRepository providerRepository, ILogger<ProviderController> logger)
        {
            _providerRepository = providerRepository;
            _logger = logger;
        }

        [HttpGet("api/providers")]
        public IActionResult Get()
        {
            var entities = _providerRepository.GetAll();
            return Ok(Mapper.Map<IEnumerable<ProviderVM>>(entities));
        }

        [HttpPost("api/providers")]
        public IActionResult Post([FromBody] ProviderVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var entity = Mapper.Map<Provider>(model);
                    _providerRepository.Create(entity);
                    _providerRepository.Commit();
                    return Created("", Mapper.Map<ProviderVM>(entity));
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
