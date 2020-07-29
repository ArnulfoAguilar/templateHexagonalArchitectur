using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Core.Dtos.Entities;
using Domain.Entities;

namespace Core
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //Dtos -> Domain
            CreateMap<Dtos.Responses.WeatherForecastResponse, Domain.Responses.WeatherForecastResponse>().ReverseMap();
            CreateMap<Dtos.Entities.WeatherForecastEntity, Domain.Entities.WeatherForecastEntity>().ReverseMap();
            CreateMap<Dtos.Entities.ResponseStatus, Domain.Entities.ResponseStatus>().ReverseMap();

            CreateMap<Domain.Responses.WeatherForecastResponse, Dtos.Responses.WeatherForecastResponse>().ReverseMap();
        }
    }
}
