using MyApp.Application.Dto.WeatherForecast;
using MyApp.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Api.Routes
{
    public static class WeatherForecastRoutes
    {
        public static IEndpointRouteBuilder MapWeatherForecast(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("/weatherforecast", ([FromServices] IWeatherForecastService service) =>
            {
                var result = service.GetAll();

                return Results.Ok(result);
            })
            .WithName("GetWeatherForecast")
            .Produces<IEnumerable<WeatherForecastDto>>(StatusCodes.Status200OK, "application/json");

            return builder;
        }
    }
}
