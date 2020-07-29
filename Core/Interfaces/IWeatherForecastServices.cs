using Core.Dtos.Entities;
using Core.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IWeatherForecastServices
    {
        public WeatherForecastResponse ObtenerTemperaturas();
    }
}
