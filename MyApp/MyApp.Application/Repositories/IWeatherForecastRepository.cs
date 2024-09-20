using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Repositories
{
    // Interfaz para abstraer codigo
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> GetAll();
    }
}
