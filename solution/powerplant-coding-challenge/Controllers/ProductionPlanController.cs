using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerPlantCodingChallenge.Models;
using PowerPlantCodingChallenge.Services;
using System;
using System.Collections.Generic;

namespace PowerPlantCodingChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductionPlanController : ControllerBase
    {
        private readonly ILogger<ProductionPlanController> _logger;

        public ProductionPlanController(ILogger<ProductionPlanController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public List<ProductionPlan> Post(PayLoad payLoad)
        {
            try
            {
                return CalculateService.Calculate(payLoad);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                throw;
            }
        }
    }
}