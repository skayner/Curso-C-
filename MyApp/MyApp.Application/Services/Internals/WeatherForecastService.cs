using MyApp.Application.Dto.WeatherForecast;
using MyApp.Application.Repositories;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Services.Internals
{
    internal class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repository;

        public WeatherForecastService(IWeatherForecastRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<WeatherForecastDto> GetAll()
        {
            IEnumerable<WeatherForecast> weatherForecasts = _repository.GetAll();

            IEnumerable<WeatherForecastDto> result = weatherForecasts.Select(x =>

            new WeatherForecastDto(x.Date,
                                    x.TemperatureC,
                                    32 + (int)(x.TemperatureC / 0.5556),
                                    x.Summary));

            return result;
        }
    }
}
