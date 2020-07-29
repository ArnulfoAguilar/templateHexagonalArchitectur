using Domain.Entities;
using Domain.Responses;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraestructure.Repositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public WeatherForecastResponse ObtenerTemperaturas()
        {
            WeatherForecastResponse resultado;
            try
            {
                var rng = new Random();
                 resultado = new WeatherForecastResponse()
                {
                    WeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecastEntity
                    {
                        Date = DateTime.Now.AddDays(index),
                        TemperatureC = rng.Next(-20, 55),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    })
                    .ToArray(),
                    response = new ResponseStatus
                    {
                        mensaje = "Transaccion realizada con exito",
                        codigo = 200
                    }
                };
            }
            catch (Exception ex)
            {
                 resultado = new WeatherForecastResponse()
                {
                    response = new ResponseStatus
                    {
                        mensaje = "Ocurrio un error al tratar de obtener los datos " +ex.Message,
                        codigo = 404
                    }
                };
            }
            return resultado;
        }
    }
}
