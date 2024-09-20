using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Application.Dto.WeatherForecast;
using MyApp.Application.Repositories;
using MyApp.Domain.Entities;

namespace MyApp.Infrastructure.Repositories
{
    // Creamos repositorio de datos que se utilizaran en Program.cs para mostrar la info sobre el clima
    internal class WeatherForecastRepository : IWeatherForecastRepository
    {
        public IEnumerable<WeatherForecast> GetAll()
        {
            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateTime.Now.AddDays(index),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
                .ToArray();

            return forecast;
        }
    }
}
