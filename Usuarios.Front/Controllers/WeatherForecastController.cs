using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dtos.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Usuarios.Front.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastServices _services;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastServices services)
        {
            _logger = logger;
            _services = services;
        }

        [HttpGet]
        public IEnumerable<WeatherForecastEntity> Get()
        {
            var respuesta = _services.ObtenerTemperaturas();
            return respuesta.WeatherForecast;
        }
    }
}
