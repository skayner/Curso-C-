using Microsoft.Extensions.DependencyInjection;
using MyApp.Application.Services.Internals;
using MyApp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Application.Data;

namespace MyApp.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMyAppApplication(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();

            services.AddMediatR(typeof(IMyAppContext));

            return services;
        }
    }
}
