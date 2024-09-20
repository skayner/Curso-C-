using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Application.Data;
using MyApp.Application.Repositories;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMyAppInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IMyAppContext, MyAppContext>(o =>
                o.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

            return services;
        }
    }
}
