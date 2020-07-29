using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Responses
{
    
    public class WeatherForecastResponse
    {
        [DataMember(Name = "response")]
        public ResponseStatus response { get; set; }
        [DataMember(Name = "WeatherForecast")]
        public IEnumerable<WeatherForecastEntity> WeatherForecast { get; set; }
    }
}
