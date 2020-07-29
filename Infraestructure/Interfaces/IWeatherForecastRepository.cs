using Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Interfaces
{
    public interface IWeatherForecastRepository
    {
        public WeatherForecastResponse ObtenerTemperaturas();
    }
}
