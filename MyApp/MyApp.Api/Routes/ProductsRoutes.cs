using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.UseCases.Products.CreateProduct;
using MyApp.Application.UseCases.Products.DeleteProduct;
using MyApp.Application.UseCases.Products.GetAllProducts;
using MyApp.Api.Extensions.ResultExtensions;
using Microsoft.EntityFrameworkCore.Metadata;
using MyApp.Application.UseCases.Products.GetProductById;
using MyApp.Application.UseCases.Products.PutProduct;

namespace MyApp.Api.Routes
{
    public static class ProductsRoutes
    {
        public static IEndpointRouteBuilder MapProducts(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("/Products", async ([FromServices] IMediator mediator)
                => Results.Ok(await mediator.Send(new GetAllProductsRequest())))
            .WithName("GetProducts")
            .Produces<IEnumerable<GetAllProductsResponse>>(StatusCodes.Status200OK, "application/json");

            builder.MapPost("/Products", async ([FromServices] IMediator mediator, [FromBody] CreateProductRequest request)
                => Results.Ok(await mediator.Send(request)))
            .WithName("CreateProducts")
            .Produces<CreateProductResponse>(StatusCodes.Status200OK, "application/json");

            builder.MapDelete("/Products/{id}", async ([FromServices] IMediator mediator, [FromRoute] int id)
                => Results.Ok(await mediator.Send(new DeleteProductRequest(id))))
            .WithName("DeleteProducts");

            builder.MapPut("/Products", async ([FromServices] IMediator mediator, [FromBody] UpdateProductRequest request)
                => Results.Ok(await mediator.Send(request)))
                .WithName("UpdateProducts")
                .Produces<UpdateProductResponse>(StatusCodes.Status200OK, "application/json");

            builder.MapGet("/Products/{id}", async ([FromServices] IMediator mediator, [FromRoute] int id)
                => Results.Ok(await mediator.Send(new GetProductByIdRequest(id))))
                .WithName("GetProductById")
                .Produces<GetProductByIdResponse>(StatusCodes.Status200OK, "application/json");

            return builder;
        }
    }
}