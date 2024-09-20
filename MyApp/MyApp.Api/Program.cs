using Microsoft.AspNetCore.Mvc;
using MyApp.Infrastructure;
using MyApp.Application;
using MyApp.Api.Routes;
using FluentValidation;
using MyApp.Application.UseCases.Products.CreateProduct;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Text.Json;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMyAppInfrastructure(builder.Configuration);

builder.Services.AddMyAppApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapProducts();

app.UseStaticFiles();

app.UseRouting();

app.Run();
