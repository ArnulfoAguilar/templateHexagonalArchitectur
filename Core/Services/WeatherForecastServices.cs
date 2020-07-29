using AutoMapper;
using Core.Dtos.Entities;
using Core.Dtos.Responses;
using Core.Interfaces;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class WeatherForecastServices : IWeatherForecastServices
    {
        private readonly IWeatherForecastRepository _repository;
        private readonly IMapper _mapper;
        public WeatherForecastServices(IWeatherForecastRepository repository, 
                                        IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public WeatherForecastResponse ObtenerTemperaturas()
        {
            var resultado = _mapper.Map<WeatherForecastResponse>(_repository.ObtenerTemperaturas());

            return resultado;
        }
    }
}
