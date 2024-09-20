using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Dto.WeatherForecast
{
    // Creamos el DTO de los datos que vamos a querer exponer al usuario
    public record WeatherForecastDto(DateTime Date, int TemperatureC, int TemperatureF, string? Summary);
}
