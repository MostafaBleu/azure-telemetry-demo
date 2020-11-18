using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FailureController : ControllerBase
    {
        public FailureController()
        {
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            throw new NotImplementedException();
        }

    }
}
