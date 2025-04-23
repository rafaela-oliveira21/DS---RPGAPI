using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var dados = new[] {
                new { Data = DateTime.Now.ToShortDateString(), TemperaturaC = 24, Resumo = "Ensolarado" },
                new { Data = DateTime.Now.AddDays(1).ToShortDateString(), TemperaturaC = 22, Resumo = "Nublado" }
            };

            return Ok(dados);
        }
    }
}