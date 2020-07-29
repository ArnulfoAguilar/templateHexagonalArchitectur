using Core.Dtos.Entities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Core.Dtos.Responses
{
    public class WeatherForecastResponse
    {
        [DataMember(Name = "response")]
        public ResponseStatus response { get; set; }
        [DataMember(Name = "WeatherForecast")]
        public IEnumerable<WeatherForecastEntity> WeatherForecast { get; set; }
    }
}
