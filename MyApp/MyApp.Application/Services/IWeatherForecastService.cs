using MyApp.Application.Dto.WeatherForecast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Services
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastDto> GetAll();
    }
}
